using StoreManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_HangThanhVien : Form
    {
        public F_HangThanhVien()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvHangThanhVien.DataSource = HangThanhVienDAO.Instance.GetAllHangThanhVien();
        }
        public void InsertHangThanhVien()
        {
            string tenHang = txbTenHang.Text;
            int diemDieuKien = Convert.ToInt32(txbDiemDieuKien.Text);
            double giamGia = Convert.ToDouble(txbGiamGia.Text);

            HangThanhVienDAO.Instance.InsertHangThanhVien(tenHang, diemDieuKien, giamGia);
        }
        public void UpdateHangThanhVien()
        {
            int id = Convert.ToInt32(txbMaHang.Text);
            string tenHang = txbTenHang.Text;
            int diemDieuKien = Convert.ToInt32(txbDiemDieuKien.Text);
            double giamGia = Convert.ToDouble(txbGiamGia.Text);

            HangThanhVienDAO.Instance.UpdateHangThanhVien(id, tenHang, diemDieuKien, giamGia);
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            InsertHangThanhVien();
            LoadData();
        }

        private void dgvHangThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaHang.Text = dgvHangThanhVien.CurrentRow.Cells[2].Value.ToString();
            txbTenHang.Text = dgvHangThanhVien.CurrentRow.Cells[3].Value.ToString();
            txbDiemDieuKien.Text = dgvHangThanhVien.CurrentRow.Cells[4].Value.ToString() ;
            txbGiamGia.Text = dgvHangThanhVien.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            UpdateHangThanhVien();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
