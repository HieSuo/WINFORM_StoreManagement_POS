using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class HoaDon
    {
        private int id;
        private DateTime ngayTao;
        private int idKhachHang;
        private int tongGiaTri;
        private double giamGia;
        private string idNguoiTao;

        public HoaDon(int id, DateTime ngayTao, int idKhachHang, int tongGiaTri, double giamGia, string idNguoiTao)
        {
            this.Id = id;
            this.NgayTao = ngayTao;
            this.IdKhachHang = idKhachHang;
            this.TongGiaTri = tongGiaTri;
            this.GiamGia = giamGia;
            this.IdNguoiTao = idNguoiTao;
        }
        public HoaDon(DataRow row)
        {
            Id = (int)row["id"];
            NgayTao = (DateTime)row["NgayTao"];
            IdKhachHang = (int)row["idKhacHang"];
            TongGiaTri = (int)row["TongGiaTri"];
            GiamGia = (Double)row["giamGia"];
            IdNguoiTao = row["idNguoiTao"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public int TongGiaTri { get => tongGiaTri; set => tongGiaTri = value; }
        public double GiamGia { get => giamGia; set => giamGia = value; }
        public string IdNguoiTao { get => idNguoiTao; set => idNguoiTao = value; }
    }
}
