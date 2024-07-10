using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class LoaiSanPham
    {
        private string id;
        private string tenLoaiSanPham;
        public LoaiSanPham(string id, string tenLoaiSanPham)
        {
            this.Id = id;
            this.TenLoaiSanPham = tenLoaiSanPham;
        }
        public LoaiSanPham(DataRow row)
        {
            this.id = row["id"].ToString();
            this.tenLoaiSanPham = row["TenLoaiSanPham"].ToString();
        }
            
        public string Id { get => id; set => id = value; }
        public string TenLoaiSanPham { get => tenLoaiSanPham; set => tenLoaiSanPham = value; }
    }
}
