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
    public partial class DialogChiTietHoaDon : Form
    {
        private List<ChiTietHoaDon> listChiTietHoaDon;
        private HoaDon hoaDon;
        public DialogChiTietHoaDon(HoaDon hoaDon)
        {
            InitializeComponent();
            this.hoaDon = hoaDon;

            lbMaHoaDon.Text = "Mã hóa đơn: " + hoaDon.Id;
            lbNguoiTao.Text = "Người tạo: " + AccountDAO.Instance.GetAccountByUserName(hoaDon.IdNguoiTao).DisplayName;
            lbNgayTao.Text = "Ngày tạo: " + hoaDon.NgayTao;
            lbKhachHang.Text = "Khách hàng: "+KhachHangDAO.Instance.GetKhachHangByID(hoaDon.IdKhachHang).TenKhachHang;
            lbTongTien.Text ="Tổng tiền: "+hoaDon.TongGiaTri.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbGiamGia.Text = "Giảm giá: " + hoaDon.GiamGia + "%";
            double thanhTien = (hoaDon.TongGiaTri - (hoaDon.TongGiaTri * hoaDon.GiamGia / 100));
            lbThanhTien.Text = "Thành tiền: " + Math.Truncate(Math.Round(thanhTien, 2)).ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            
            LoadChiTietHoaDon();
        }
        public void LoadChiTietHoaDon()
        {
            listChiTietHoaDon = ChiTietHoaDonDAO.Instance.GetChiTietHoaDonByIDHoaDon(hoaDon.Id);
            foreach(ChiTietHoaDon ct in listChiTietHoaDon)
            {
                dgvHoaDon.Rows.Add(ct.Id, SanPhamDAO.Instance.GetSanPhamByID(ct.IdSanPham).TenSanPham, ct.SoLuong, ct.GiaKhiBan);
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
    }
}
