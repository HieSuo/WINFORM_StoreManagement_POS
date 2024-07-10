using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class ThongSoSanPhamDTO
    {
        private int id;
        private string maSanPham;
        private string tenSanPham;
        private int soLuongTonKho;
        private int giaBan;
        private int giaNhapGanNhat;
        private int daBan;
        private int daNhap;
        public ThongSoSanPhamDTO(int id,string maSanPham, string tenSanPham, int soLuongTonKho, int giaBan, int giaNhapGanNhat, int daBan, int daNhap)
        {
            this.Id = id;
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.SoLuongTonKho = soLuongTonKho;
            this.GiaBan = giaBan;
            this.GiaNhapGanNhat = giaNhapGanNhat;
            this.DaBan = daBan;
            this.DaNhap = daNhap;
        }
        public ThongSoSanPhamDTO(DataRow row)
        {
            Id = Convert.ToInt32(row["id"]);
            MaSanPham = row["MaSanPham"].ToString();
            TenSanPham = row["TenSanPham"].ToString();
            SoLuongTonKho = Convert.ToInt32(row["SoLuongTonKho"]);
            GiaBan = Convert.ToInt32(row["GiaBan"]);
            GiaNhapGanNhat = Convert.ToInt32(row["GiaNhapGanNhat"]);
            if (row["DaBan"].ToString() == "")
            {
                DaBan = 0;
            }
            else
            {
                DaBan = Convert.ToInt32(row["DaBan"]);
            }
            if (row["DaNhap"].ToString() == "")
            {
                daNhap = 0;
            }
            else
            {
                DaNhap = Convert.ToInt32(row["DaNhap"]);
            }
        }

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuongTonKho { get => soLuongTonKho; set => soLuongTonKho = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int GiaNhapGanNhat { get => giaNhapGanNhat; set => giaNhapGanNhat = value; }
        public int DaBan { get => daBan; set => daBan = value; }
        public int DaNhap { get => daNhap; set => daNhap = value; }
        public int Id { get => id; set => id = value; }

    }
}
