using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class ThongTinCuaHang
    {
        private int id;
        private string tenCuaHang;
        private string soDienThoai;
        private string diaChi;

        public ThongTinCuaHang(int id, string tenCuaHang, string soDienThoai, string diaChi)
        {
            this.Id = id;
            this.TenCuaHang = tenCuaHang;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
        }
        public ThongTinCuaHang(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TenCuaHang = row["tenCuaHang"].ToString();
            this.soDienThoai = row["soDienThoai"].ToString();
            this.diaChi = row["diaChi"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string TenCuaHang { get => tenCuaHang; set => tenCuaHang = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
