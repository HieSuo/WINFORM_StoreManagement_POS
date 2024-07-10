using OfficeOpenXml;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.GUI.CustomDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_QuanLyHangHoa : Form
    {
        private List<SanPham> listSanPham;
        public F_QuanLyHangHoa()
        {
            InitializeComponent();
            listSanPham = new List<SanPham>();
            LoadData();
            LoadLoaiSanPhamIntoComboBox();
        }
        #region method
        // Load data method
        public void LoadData()
        {
            listSanPham.Clear();
            listSanPham = SanPhamDAO.Instance.GetAllSanPham();
            dgvSanPham.DataSource = SanPhamDAO.Instance.GetAllSanPham();
        }
        public void LoadLoaiSanPhamIntoComboBox()
        {
            LoaiSanPham lspAll = new LoaiSanPham("ALL", "Tất cả");
            cbLoaiSanPham.Items.Add(lspAll);
            List<LoaiSanPham> listSP = LoaiSanPhamDAO.Instance.GetAllLoaiSanPham();

            foreach (LoaiSanPham lsp in listSP)
            {
                cbLoaiSanPham.Items.Add(lsp);
            }
            cbLoaiSanPham.DisplayMember = "tenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "id";
   
        }
        
        // Excel method
        private void ExportToExcel(DataGridView dataGridViewm, string filePath)
        {

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
                int totalCols = dataGridViewm.Columns.Count;
                int totalRows = dataGridViewm.Rows.Count;
                // Writing headers
                for (int i = 1; i <= totalCols; i++)
                {
                    worksheet.Cells[1, i].Value = dataGridViewm.Columns[i - 1].HeaderText;
                }
                // Writing cells
                for (int i = 0; i < totalRows; i++)
                {
                    for (int j = 0; j < totalCols; j++)
                    {
                        //worksheet.Cells[i + 2, j + 1].Value = dataGridViewm.Rows[i].Cells[j].Value.ToString();
                        if (dataGridViewm.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridViewm.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1].Value = "NULL";
                        }
                    }
                }
                worksheet.Cells.AutoFitColumns();
                //save file
                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }
        }
        #endregion


        #region event
        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Xuất danh sách phiếu nhập hàng";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgvSanPham, saveFileDialog.FileName);
            }
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           foreach(DataGridViewRow row in dgvSanPham.Rows)
           {
                int soluong = Convert.ToInt32(row.Cells["soluong"].Value);
                if (soluong < 10)
                {
                    row.Cells["soluong"].Style.BackColor = Color.Yellow;
                }
				if (soluong < 5)
				{
					row.Cells["soluong"].Style.BackColor = Color.Red;
				}
				string trangThai = row.Cells["trangthai"].Value.ToString();
                if(trangThai == "Ngừng bán")
                {
                    row.DefaultCellStyle.BackColor = Color.Aqua;

                }
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SanPham sp = listSanPham[e.RowIndex];
                DialogChiTietSanPham dialogChiTietSanPham = new DialogChiTietSanPham(sp);
                dialogChiTietSanPham.UpdateSanPhamEV += DialogChiTietSanPham_UpdateSanPhamEV;
                dialogChiTietSanPham.ShowDialog();
            }
        }

        private void DialogChiTietSanPham_UpdateSanPhamEV(object sender, EventArgs e)
        {
            LoadData();
            NoticeDialog.Show(new NoticeDialog("Thông báo", "Cập nhật sản phẩm thành công!"));
        }
        #endregion

        private void cbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSanPham.Clear();
            if ( (cbLoaiSanPham.SelectedItem as LoaiSanPham).Id != "ALL")
            {
                listSanPham = SanPhamDAO.Instance.GetSanPhamByLoaiHang((cbLoaiSanPham.SelectedItem as LoaiSanPham).Id);
                dgvSanPham.DataSource = listSanPham;
            }
            else
            {
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            listSanPham.Clear();
            listSanPham = SanPhamDAO.Instance.GetSanPhamByKeyWord(txbTimKiem.Text);
            dgvSanPham.DataSource = listSanPham; 
        }

		private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
		{
			listSanPham.Clear();
			listSanPham = SanPhamDAO.Instance.GetSanPhamByTrangThai(cbTrangThai.Text);
			dgvSanPham.DataSource = listSanPham;
		}
	}
}
