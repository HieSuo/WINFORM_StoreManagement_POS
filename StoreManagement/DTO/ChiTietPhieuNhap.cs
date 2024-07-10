using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class ChiTietPhieuNhap
    {
        private int id;
        private int idPhieuNhap;
        private int giaKhiNhap;
        private int idSanPham;
        private int soLuongNhap;

        public ChiTietPhieuNhap(int id, int idPhieuNhap, int giaKhiNhap, int idSanPham, int soLuongNhap)
        {
            this.Id = id;
            this.IdPhieuNhap = idPhieuNhap;
            this.GiaKhiNhap = giaKhiNhap;
            this.IdSanPham = idSanPham;
            this.SoLuongNhap = soLuongNhap;
        }
        public ChiTietPhieuNhap(DataRow row)
        {
            Id = (int) row["id"];
            IdPhieuNhap = (int)row["idPhieuNhap"];
            IdSanPham = (int)row["idSanPham"];
            GiaKhiNhap = (int)row["GiaKhiNhap"];
            SoLuongNhap = (int)row["SoLuong"];
        }
        public int Id { get => id; set => id = value; }
        public int IdPhieuNhap { get => idPhieuNhap; set => idPhieuNhap = value; }
        public int GiaKhiNhap { get => giaKhiNhap; set => giaKhiNhap = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
    }
}
