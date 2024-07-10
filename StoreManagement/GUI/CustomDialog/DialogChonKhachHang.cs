using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.CustomDialog
{
    public partial class DialogChonKhachHang : Form
    {
        private List<KhachHang> listKhachHang;
        public DialogChonKhachHang()
        {
            InitializeComponent();
            LoadKhachHangToDGV();
        }
        public void LoadListKhachHang()
        {
            listKhachHang = new List<KhachHang>();
            listKhachHang = KhachHangDAO.Instance.GetAllKhachHang();
        }

        public void LoadKhachHangToDGV()
        {
            dgvKhachHang.Rows.Clear();
            LoadListKhachHang();

            if (listKhachHang.Count == 0)
            {
                return;
            }

            foreach (KhachHang kh in listKhachHang)
            {
                int idKH = kh.Id;
                string tenKH = kh.TenKhachHang;
                string sdt = kh.SoDienThoai;
                int diemTL = kh.DiemTichLuy;
                string tenHTV = HangThanhVienDAO.Instance.GetHangThanhVienByID(kh.IdHangThanhVien).TenHangThanhVien;
                double phanTramGiam = HangThanhVienDAO.Instance.GetHangThanhVienByID(kh.IdHangThanhVien).PhanTramGiam;
                dgvKhachHang.Rows.Add(idKH, tenKH, sdt, diemTL, tenHTV, phanTramGiam);
            }

        }


        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void noticeHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Chọn khách hàng " + listKhachHang[e.RowIndex].TenKhachHang, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (chooseKhachHangEV != null)
                {
                    chooseKhachHangEV(this, new SendKhachHang(listKhachHang[e.RowIndex]));
                }
            }
        }
        private event EventHandler<SendKhachHang> chooseKhachHangEV;
        public event EventHandler<SendKhachHang> ChooseKhachHangEV
        {
            add { chooseKhachHangEV += value; }
            remove { chooseKhachHangEV -= value; }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            Dialog_ThemKhachHang dialog_ThemKhachHang = new Dialog_ThemKhachHang();
            dialog_ThemKhachHang.InsertKhachHangEV += Dialog_ThemKhachHang_InsertKhachHangEV;
            dialog_ThemKhachHang.ShowDialog();

        }

        private void Dialog_ThemKhachHang_InsertKhachHangEV(object sender, EventArgs e)
        {
            LoadKhachHangToDGV();
        }

		private void btnSearch_Click(object sender, EventArgs e)
		{
            string keyword = txbTimKiemKh.Text;
            dgvKhachHang.DataSource = KhachHangDAO.Instance.GetKhachHangByKeyWord(keyword);
		}
	}
}
