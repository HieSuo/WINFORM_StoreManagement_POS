using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.source
{
    public class CustomEventArgs
    {
    }
    public class SendAccount : EventArgs 
    {
        private Account account;

        public Account Account 
        { get => account; set => account = value; }
        public SendAccount(Account account)
        {
            this.account = account;
        }
    }
    public class SendSanPham : EventArgs {
        private SanPham sanPham;

        public SanPham SanPham { get => sanPham; set => sanPham = value; }
        public SendSanPham(SanPham sanPham)
        {
            this.sanPham = sanPham;
        }
    }
    public class SendKhachHang : EventArgs
    {
        private KhachHang khachHang;

        public KhachHang KhachHang { get => khachHang; set => khachHang = value; }
        public SendKhachHang(KhachHang khachHang)
        {
            KhachHang = khachHang;
        }
    }
    
}
