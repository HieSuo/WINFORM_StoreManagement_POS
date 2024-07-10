using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class PhieuNhap
    {
        private int id;
        private DateTime ngayTao;
        private int idNCC;
        private int tongGiaTri;
        private string idNguoiTao;

        public int Id { get => id; set => id = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int IdNCC { get => idNCC; set => idNCC = value; }
        public int TongGiaTri { get => tongGiaTri; set => tongGiaTri = value; }
        public string IdNguoiTao { get => idNguoiTao; set => idNguoiTao = value; }

        public PhieuNhap(int id, DateTime ngayTao, int idNCC, int tongGiaTri, string idNguoiTao)
        {
            Id = id;
            NgayTao = ngayTao;
            IdNCC = idNCC;
            TongGiaTri = tongGiaTri;
            IdNguoiTao = idNguoiTao;
        }
        public PhieuNhap(DataRow row)
        {
            Id = Convert.ToInt32(row["id"]);
            NgayTao = (DateTime)row["NgayTao"];
            IdNCC = Convert.ToInt32(row["idNhaCungCap"]);
            TongGiaTri = Convert.ToInt32(row["TongGiaTri"]);
            IdNguoiTao = row["idNguoiTao"].ToString();
        }
    }
}
