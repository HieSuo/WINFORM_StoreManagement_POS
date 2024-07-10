using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class HangThanhVien
    {
        private int id;
        private string tenHangThanhVien;
        private int diemDieuKien;
        private double phanTramGiam;

        public int Id { get => id; set => id = value; }
        public string TenHangThanhVien { get => tenHangThanhVien; set => tenHangThanhVien = value; }
        public int DiemDieuKien { get => diemDieuKien; set => diemDieuKien = value; }
        public double PhanTramGiam { get => phanTramGiam; set => phanTramGiam = value; }

        public HangThanhVien(int id, string tenHangThanhVien, int diemDieuKien, double phanTramGiam)
        {
            Id = id;
            TenHangThanhVien = tenHangThanhVien;
            DiemDieuKien = diemDieuKien;
            PhanTramGiam = phanTramGiam;
        }
        public HangThanhVien(DataRow row)
        {
            Id = (int)row["id"];
            TenHangThanhVien = row["tenHangThanhVien"].ToString();
            DiemDieuKien = (int)row["diemDieuKien"];
            PhanTramGiam = (double)row["phamTramGiam"];
        }
    }
}
