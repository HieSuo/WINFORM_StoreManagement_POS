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
    public partial class F_QuanLyHoaDon : Form
    {
        public F_QuanLyHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
        }
        public void LoadHoaDon()
        {
            dgvHoaDon.DataSource = HoaDonDAO.Instance.GetAllHoaDon();
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
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Xuất danh sách phiếu nhập hàng";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgvHoaDon, saveFileDialog.FileName);
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDon hoaDon = HoaDonDAO.Instance.GetHoaDonByID( (int) dgvHoaDon.CurrentRow.Cells[0].Value);
            //MessageBox.Show(hoaDon.Id.ToString());
            if (hoaDon != null)
            {
                DialogChiTietHoaDon dialog = new DialogChiTietHoaDon(hoaDon);
                dialog.ShowDialog();
            }

        }
    }
}
