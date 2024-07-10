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

namespace StoreManagement.GUI.ModuleForm.ModuleKhachHang
{
    public partial class F_DanhSachKhachHang : Form
    {
        public F_DanhSachKhachHang()
        {
            InitializeComponent();
            LoadDSKH();
        }

        public void LoadDSKH()
        {
            dgvKhachHang.DataSource = KhachHangDAO.Instance.GetAllKhachHang();
        }
        public void LoadTimKiemKH(string keyword)
        {
			dgvKhachHang.DataSource = KhachHangDAO.Instance.GetKhachHangByKeyWord(keyword);
		}
		public void ClearForm()
        {
            txbMaKH.Clear();
            txbHoTen.Clear();
            txbDiaChi.Clear();
            txbSoDienThoai.Clear();
        }
        public string CheckEmptyForm()
        {
            string msg = "";

            if (txbHoTen.Text.Trim() == "")
                msg += "Tên khách hàng không được trống \n";
            if (txbSoDienThoai.Text.Trim() == "")
                msg += "Số điện thoại không được trống \n";
            if (txbDiaChi.Text.Trim() == "")
                msg += "Địa chỉ không được trống \n";

            return msg;
        }
        public void ThemMoiKhachHang()
        {
            string tenKH = txbHoTen.Text.Trim();
            string soDienThoai = txbSoDienThoai.Text.Trim();
            string diaChi = txbDiaChi.Text.Trim();
            if (CheckEmptyForm() == "")
            {
                KhachHangDAO.Instance.InsertKhachHang(tenKH, soDienThoai, diaChi);
            }
            else
            {
                MessageBox.Show(CheckEmptyForm(),"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void UpdateKhachHang()
        {
            if (txbMaKH.Text == null)
            {
                MessageBox.Show("Hãy chọn khách hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maKH = Convert.ToInt32(txbMaKH.Text);
            string tenKH = txbHoTen.Text.Trim();
            string soDienThoai = txbSoDienThoai.Text.Trim();
            string diaChi = txbDiaChi.Text.Trim();
            if (CheckEmptyForm() == "")
            {
                KhachHangDAO.Instance.UpdateThongTinKhachHang(maKH, tenKH, soDienThoai, diaChi);
            }
            else
            {
                MessageBox.Show(CheckEmptyForm(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemMoiKhachHang();
            LoadDSKH();
            ClearForm();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if((int)dgvKhachHang.CurrentRow.Cells[2].Value == 3)
            {
                MessageBox.Show("Không được sửa khách hàng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
			if (dgvKhachHang.Columns[e.ColumnIndex].Name == "delete")
			{
				int id = (int)dgvKhachHang.CurrentRow.Cells[2].Value;
				if (MessageBox.Show("Xoá khách hàng này? idkh="+id, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
                    if (KhachHangDAO.Instance.DeleteKhachHang(id))
                    {
                        LoadDSKH();
                    }
                    else
                    {
                        MessageBox.Show("Khong the xoa khach hang!");
                    }
				}
            }
            else
            {
			    txbMaKH.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                txbHoTen.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                txbSoDienThoai.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                txbDiaChi.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            UpdateKhachHang();
            LoadDSKH();
            ClearForm();
        }

		private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
		{
            string keyWord = txbTimKiem.Text;
            LoadTimKiemKH(keyWord);
		}

		private void txbTimKiem_TextChanged(object sender, EventArgs e)
		{
			string keyWord = txbTimKiem.Text;
			LoadTimKiemKH(keyWord);
		}
	}
}
