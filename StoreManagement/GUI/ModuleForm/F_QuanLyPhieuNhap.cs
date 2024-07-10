using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml;
using System.IO;
using StoreManagement.GUI.CustomDialog;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_QuanLyPhieuNhap : Form
    {
        private List<PhieuNhap> listPhieuNhap;
        public F_QuanLyPhieuNhap()
        {
           
            InitializeComponent();
            LoadPhieuNhap();
        }
        public void LoadPhieuNhap()
        {
            listPhieuNhap = PhieuNhapDAO.Instance.GetAllPhieuNhap();
            foreach(PhieuNhap pn in listPhieuNhap)
            {
                dgvPhieuNhap.Rows.Add(pn.Id, pn.NgayTao, pn.IdNCC+"-"+NhaCungCapDAO.Instance.GetNhaCungCapByID(pn.IdNCC).TenNCC,pn.IdNguoiTao+"-"+ AccountDAO.Instance.GetAccountByUserName(pn.IdNguoiTao).DisplayName, pn.TongGiaTri.ToString("C", CultureInfo.GetCultureInfo("vi-VN")));
            }   
        }
        private void ExportToExcel(DataGridView dataGridViewm , string filePath)
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
                        if(dataGridViewm.Rows[i].Cells[j].Value != null)
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
        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PhieuNhap pn = PhieuNhapDAO.Instance.GetPhieuNhapByID((int)dgvPhieuNhap.CurrentRow.Cells[0].Value);
            DialogChiTietPhieuNhap dialogChiTietPhieuNhap = new DialogChiTietPhieuNhap(pn);
            dialogChiTietPhieuNhap.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Xuất danh sách phiếu nhập hàng";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgvPhieuNhap, saveFileDialog.FileName);
            }
        }

        private void F_QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
