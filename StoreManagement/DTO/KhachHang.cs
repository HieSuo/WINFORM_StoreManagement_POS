using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class KhachHang
    {
        private int id;
        private string tenKhachHang;
        private string soDienThoai;
        private string diaChi;
        private int diemTichLuy;
        private int idHangThanhVien;

        public int Id { get => id; set => id = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
        public int IdHangThanhVien { get => idHangThanhVien; set => idHangThanhVien = value; }
        public KhachHang(int id, string tenKhachHang, string soDienThoai, string diaChi, int diemTichLuy, int idHangThanhVien)
        {
            Id = id;
            TenKhachHang = tenKhachHang;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            DiemTichLuy = diemTichLuy;
            IdHangThanhVien = idHangThanhVien;
        }
        public KhachHang(DataRow row)
        {
            Id = (int)row["id"];
            TenKhachHang = row["TenKhachHang"].ToString();
            DiaChi = row["DiaChi"].ToString();
            SoDienThoai = row["SoDienThoai"].ToString();
            DiemTichLuy = (int)row["DiemTichLuy"];
            IdHangThanhVien = (int)row["idHangThanhVien"];
        }
    }
}
