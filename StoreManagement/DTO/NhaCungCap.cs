using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class NhaCungCap
    {
        private int iD;
        private string tenNCC;
        private string soDienThoai;
        private string diaChi;

        public NhaCungCap(int iD, string tenNCC, string soDienThoai, string diaChi)
        {
            this.ID = iD;
            this.TenNCC = tenNCC;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
        }
        public NhaCungCap(DataRow row)
        {
            this.iD = Convert.ToInt32(row["id"]);
            this.tenNCC = row["TenNCC"].ToString();
            this.soDienThoai = row["SoDienThoai"].ToString();
            this.diaChi = row["DiaChi"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
