using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI
{
    public partial class FormHoaDon : Form
    {
        private Account loginAccount;
        private List<DanhSachHoaDon> listDSHoaDon;
        private KhachHang khachHang;
        private ThongTinCuaHang thongTinCuaHang;
        private double giamGia = 0;
        private double thanhTien=0;

        public FormHoaDon(Account loginAccount, List<DanhSachHoaDon> list, KhachHang khachHang)
        {
            InitializeComponent();
            this.thongTinCuaHang = ThongTinCuaHangDAO.Instance.GetThongTinCuaHang();
            lbTenCuaHang.Text = thongTinCuaHang.TenCuaHang;
            lbTTCuaHang.Text = thongTinCuaHang.SoDienThoai + "-" + thongTinCuaHang.DiaChi;

            this.loginAccount = loginAccount;
            this.listDSHoaDon = list;
            this.khachHang = khachHang;
            if (this.khachHang == null)
            {
                this.khachHang = KhachHangDAO.Instance.GetKhachHangByID(3);
            }
            LoadData();


        }
        public int TongGiaTriDonHang()
        {
            int tong = 0;
            foreach (DanhSachHoaDon ds in listDSHoaDon)
            {
                tong += ds.ThanhTien;
            }
            return tong;
        }
        public void LoadData()
        {
            DateTime ngayHienTai = DateTime.Now;
            lbNgayTao.Text = "Ngày tạo: " + ngayHienTai.ToString();

            lbNguoiTao.Text = "Người tạo: " + loginAccount.DisplayName;


            foreach (DanhSachHoaDon ds in listDSHoaDon)
            {
                dgvDSSP.Rows.Add(ds.TenSanPham, ds.SoLuong, ds.GiaBan);
            }

            if (khachHang != null)
            {
                lbKhachHang.Text = "Khách hàng: " + khachHang.Id + "-" + khachHang.TenKhachHang;
                lbGiamGia.Text = "Giảm giá: " + HangThanhVienDAO.Instance.GetHangThanhVienByID(khachHang.IdHangThanhVien).PhanTramGiam + "%";

                giamGia = (double)HangThanhVienDAO.Instance.GetHangThanhVienByID(khachHang.IdHangThanhVien).PhanTramGiam;
            }
            else
            {
                lbKhachHang.Text = "Khách hàng: Không";
                lbGiamGia.Text = "Giảm giá: 0%";

            }
            int tongTien = TongGiaTriDonHang();
            lbTongTien.Text = "Tổng tiền:" + tongTien.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));

            thanhTien = tongTien - (tongTien * (giamGia / 100));
            lbThanhTien.Text ="Thành tiền: "+ Math.Truncate(Math.Round(thanhTien, 2)).ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
        }
        public void InsertHoaDon()
        {
            bool insertSuccess = true;
            if (HoaDonDAO.Instance.InsertHoaDon(khachHang.Id, TongGiaTriDonHang(), giamGia, loginAccount.UserName))
            {
                int maxIDHoaDon = HoaDonDAO.Instance.MaxIdHoaDon();
                foreach (DanhSachHoaDon ds in listDSHoaDon)
                {
                    if (!ChiTietHoaDonDAO.Instance.InsertChiTietHoaDon(maxIDHoaDon, ds.Id, ds.SoLuong, ds.GiaBan))
                    {
                        insertSuccess = false;

                    }
                }
            }

            if (!insertSuccess)
            {
                MessageBox.Show("Lỗi thanh toán!");
                return;
            }
            if (khachHang.Id != 3)
            {
                KhachHangDAO.Instance.UpdateHangThanhVienByIDKhachHang(khachHang.Id);   
            }
            MessageBox.Show("Thanh toán thành công!");
            if (insertSuccessEV != null)
            {
                insertSuccessEV(this, new EventArgs());
            }
        }
        private void PrintHoaDon()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // khởi tạo các thuộc tính cho trang in
            Graphics graphics = e.Graphics;
            Font font_18_Bold = new Font("Arial", 18, FontStyle.Bold);
            Font font_18_Regular = new Font("Arial", 18, FontStyle.Regular);
            Font font_16_Regular = new Font("Arial", 16, FontStyle.Regular);
            Font font_16_Bold = new Font("Arial", 16, FontStyle.Bold);

            SolidBrush textColor_Black = new SolidBrush(Color.Black);
            int startX = 10;
            int startY = 10;
            int offset = 20;

            string tenCuaHang = thongTinCuaHang.TenCuaHang;
            SizeF sizeTenCuaHang = graphics.MeasureString(tenCuaHang, font_18_Bold);
            float startTenCuaHangX = (e.MarginBounds.Width / 2);
            graphics.DrawString(tenCuaHang, font_18_Bold, textColor_Black, startTenCuaHangX, startY);
            offset += 20;

            string diaChiCuaHang = thongTinCuaHang.SoDienThoai+"-"+thongTinCuaHang.SoDienThoai;
            SizeF sizeDiaChiCuaHang = graphics.MeasureString(diaChiCuaHang, font_18_Regular);
            float startDiaChiCuaHangX = (e.MarginBounds.Width-sizeDiaChiCuaHang.Width);
            graphics.DrawString(diaChiCuaHang, font_18_Regular, textColor_Black, startDiaChiCuaHangX, startY+offset);
            offset += 40;

            //Thông tin hóa đơn
            graphics.DrawString($"Ngày tạo: {DateTime.Now}", font_16_Regular, textColor_Black, startY, startY + offset);
            offset += 20;
            graphics.DrawString($"Người tạo: {loginAccount.DisplayName}", font_16_Regular, textColor_Black, startY, startY + offset);
            offset += 20;
            graphics.DrawString($"Khách hàng: {khachHang.TenKhachHang}", font_16_Regular, textColor_Black, startY, startY + offset);
            offset += 40;
            //Danh sách sản phẩm
            int rowHeight = dgvDSSP.RowTemplate.Height;
            //Tiêu đề cột bảng
            graphics.DrawString(dgvDSSP.Columns[0].HeaderText, font_16_Bold, textColor_Black, startX, startY + offset);
            graphics.DrawString(dgvDSSP.Columns[1].HeaderText, font_16_Bold, textColor_Black, startX+450, startY + offset);
            graphics.DrawString(dgvDSSP.Columns[2].HeaderText, font_16_Bold, textColor_Black, startX+650, startY + offset);
            offset += rowHeight;
            //In danh sách sản phẩm
            foreach(DanhSachHoaDon ds in listDSHoaDon)
            {
                if (ds != null)
                {
                    graphics.DrawString(ds.TenSanPham, font_16_Regular, textColor_Black, startX, startY + offset);
                    graphics.DrawString(ds.SoLuong+"", font_16_Regular, textColor_Black, startX+450, startY+offset);
                    graphics.DrawString(ds.GiaBan.ToString("C", CultureInfo.GetCultureInfo("vi-VN")), font_16_Regular, textColor_Black, startX+650, startY+offset);
                }
                offset += rowHeight;
            }
            //Tổng tiền
            graphics.DrawString("Tổng tiền: ", font_16_Bold, textColor_Black, startX + 450, startY + offset);
            int tongTien = TongGiaTriDonHang();
            graphics.DrawString(tongTien.ToString("C", CultureInfo.GetCultureInfo("vi-VN")), font_16_Bold, textColor_Black, startX + 650, startY + offset);
            offset += 20;
            //Giảm giá
            graphics.DrawString("Giảm giá: ", font_16_Bold, textColor_Black, startX + 450, startY + offset);
            graphics.DrawString(giamGia+"%", font_16_Bold, textColor_Black, startX + 650, startY + offset);
            offset += 20;
            //Thành tiền
            graphics.DrawString("Thành tiền: ", font_16_Bold, textColor_Black, startX + 450, startY + offset);
            graphics.DrawString(Math.Truncate(Math.Round(thanhTien, 2)).ToString("C", CultureInfo.GetCultureInfo("vi-VN")), font_16_Bold, textColor_Black, startX + 650, startY + offset);
            offset += 60;
            //Cảm ơn
            graphics.DrawString("Cảm ơn quý khách đã sử dụng dịch vụ!", font_16_Bold, textColor_Black,startX+100, startY + offset);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            PrintHoaDon();
            InsertHoaDon();
            this.Close();
        }
        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private event EventHandler insertSuccessEV;
        public  event EventHandler InsertSuccessEV
        {
            add { insertSuccessEV += value; } remove { insertSuccessEV -= value; }
        }
    }
}
