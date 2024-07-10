using OfficeOpenXml;
using StoreManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_NhaCungCap : Form
    {
        public F_NhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }

       public void LoadData()
       {
            dgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.GetAllNhaCungCap();
       }
		public void LoadTimKiemNCC(string keyword)
		{
			dgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.GetNhaCungCapByKeyword(keyword);
		}
		public void InsertNhaCungCap()
        {
            //string pattern = @"^\d{11}$";

            string tenNCC = txbTenNCC.Text;
            string soDienThoai = txbSoDienThoai.Text;
            string diaChi = txbDiaChi.Text;
            if(tenNCC.Length == 0 || soDienThoai.Length ==0 || diaChi.Length ==0)
            {
                MessageBox.Show("Không được để trống!");
                return;
            }
            if(NhaCungCapDAO.Instance.InsertNhaCungCap(tenNCC, soDienThoai, diaChi))
            {
                LoadData();
            }
        }
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
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            InsertNhaCungCap();
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if((int) dgvNhaCungCap.CurrentRow.Cells[2].Value == 5)
            {
                MessageBox.Show("Không cho phép sửa đối tượng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvNhaCungCap.Columns[e.ColumnIndex].Name == "update")
            {
                int id =Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString());
                string tenNCC = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
                string soDienThoai = dgvNhaCungCap.CurrentRow.Cells[4].Value.ToString();
                string diaChi = dgvNhaCungCap.CurrentRow.Cells[5].Value.ToString();
                if (MessageBox.Show("Sửa " + e.RowIndex + e.ColumnIndex + id + tenNCC + soDienThoai + " này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    NhaCungCapDAO.Instance.UpdateNhaCungCap(id, tenNCC, soDienThoai, diaChi);
                }
            }
            else if (dgvNhaCungCap.Columns[e.ColumnIndex].Name == "delete")
            {
                int id = (int) dgvNhaCungCap.CurrentRow.Cells[2].Value;
                if (MessageBox.Show("Xoá loại sản phẩm này?"+id, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    NhaCungCapDAO.Instance.DeleteNhaCungCapByID(id);
                    LoadData();
                }
            }
            
        }

		private void btnSearch_Click(object sender, EventArgs e)
		{
            string keyword = txbTimKiem.Text;
            LoadTimKiemNCC(keyword);
		}

		private void txbTimKiem_TextChanged(object sender, EventArgs e)
		{
			string keyword = txbTimKiem.Text;
			LoadTimKiemNCC(keyword);
		}


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Xuất danh sách phiếu nhập hàng";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgvNhaCungCap, saveFileDialog.FileName);
            }
        }

        private void F_NhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}
