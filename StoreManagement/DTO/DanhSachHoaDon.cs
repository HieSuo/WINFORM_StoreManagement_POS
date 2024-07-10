using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class DanhSachHoaDon
    {
        private int id;
        private string maSanPham;
        private string tenSanPham;
        private int giaBan;
        private int soLuong;
        private int thanhTien;

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong 
        { 
            get => soLuong; 
            set 
            { 
                soLuong = value; ThanhTien = soLuong * giaBan; 
            } 
        }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int Id { get => id; set => id = value; }

        public DanhSachHoaDon(int id,string maSanPham, string tenSanPham, int giaBan, int soLuong)
        {
            this.id = id;
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            GiaBan = giaBan;
            SoLuong = soLuong;
            ThanhTien = giaBan*soLuong;
        }
    }
}
