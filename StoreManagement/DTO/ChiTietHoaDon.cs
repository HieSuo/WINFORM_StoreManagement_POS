using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class ChiTietHoaDon
    {
        private int id;
        private int idHoaDon;
        private int idSanPham;
        private int soLuong;
        private int giaKhiBan;
        public ChiTietHoaDon(int id, int idHoaDon, int idSanPham, int soLuong, int giaKhiBan)
        {
            this.Id = id;
            this.IdHoaDon = idHoaDon;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
            this.GiaKhiBan = giaKhiBan;
        }
        public ChiTietHoaDon(DataRow row)
        {
            this.Id = (int) row["id"];
            this.IdHoaDon = (int)row["idHoaDon"];
            this.IdSanPham = (int)row["idSanPham"];
            this.SoLuong = (int)row["soLuong"];
            this.GiaKhiBan = (int)row["giaKhiBan"];
        }

        public int Id { get => id; set => id = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaKhiBan { get => giaKhiBan; set => giaKhiBan = value; }
    }
}
