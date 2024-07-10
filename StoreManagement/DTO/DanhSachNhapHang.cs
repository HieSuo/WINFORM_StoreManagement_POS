using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{

    //@idBill INT, @idMaLoaiSanPham NVARCHAR(20),@tenSanPham NVARCHAR(30),
    //@maSanPham NVARCHAR(20), @giaBan INT, @giaNhap INT, @soLuong INT, @anhSP Image
    public class DanhSachNhapHang
    {
        private string idLoaiSanPham;
        private string tenSanPham;
        private string maSanPham;
        private int giaBan;
        private int giaNhap;
        private int soLuong;
        private Image anhSP;

        public string IdLoaiSanPham { get => idLoaiSanPham; set => idLoaiSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public Image AnhSP { get => anhSP; set => anhSP = value; }
    
        public DanhSachNhapHang(string idLoaiSanPham, string tenSanPham, string maSanPham, int giaBan, int giaNhap, int soLuong, Image anhSP)
        {
            IdLoaiSanPham = idLoaiSanPham;
            TenSanPham = tenSanPham;
            MaSanPham = maSanPham;
            GiaBan = giaBan;
            GiaNhap = giaNhap;
            SoLuong = soLuong;
            AnhSP = anhSP;
           
        }
        public string ToString()
        {
            return idLoaiSanPham+tenSanPham+maSanPham+giaBan+giaNhap+soLuong;
        }
    }
}
