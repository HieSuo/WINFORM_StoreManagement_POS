using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.CustomDialog
{
    public partial class DialogChiTietPhieuNhap : Form
    {
        private PhieuNhap phieuNhap;
        private List<ChiTietPhieuNhap> listChiTietPhieuNhap;
        public DialogChiTietPhieuNhap(PhieuNhap phieuNhap)
        {
            InitializeComponent();
            this.phieuNhap = phieuNhap;
            lbMaPhieuNhap.Text = lbMaPhieuNhap.Text + phieuNhap.Id;
            lbNgayTao.Text = lbNgayTao.Text + phieuNhap.NgayTao;
            lbNhaCungCap.Text = lbNhaCungCap.Text+NhaCungCapDAO.Instance.GetNhaCungCapByID(phieuNhap.IdNCC).TenNCC;
            lbNguoiTao.Text = lbNguoiTao.Text + AccountDAO.Instance.GetAccountByUserName(phieuNhap.IdNguoiTao).DisplayName;
            lbTongTien.Text = lbTongTien.Text + phieuNhap.TongGiaTri.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            LoadChiTietPhieuNhap();
        }

        public void LoadChiTietPhieuNhap()
        {
            listChiTietPhieuNhap = ChiTietPhieuNhapDAO.Instance.GetChiTietPhieuByIDPhieu(phieuNhap.Id);
            foreach(ChiTietPhieuNhap chiTietPhieu in listChiTietPhieuNhap)
            {
                dgvPhieuNhap.Rows.Add(chiTietPhieu.Id,SanPhamDAO.Instance.GetSanPhamByID(chiTietPhieu.IdSanPham).TenSanPham, chiTietPhieu.SoLuongNhap, chiTietPhieu.GiaKhiNhap.ToString("C", CultureInfo.GetCultureInfo("vi-VN")));
            }
        }

        #region event
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
        #endregion
    }
}
