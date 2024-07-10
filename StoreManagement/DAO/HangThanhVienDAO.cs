using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    public class HangThanhVienDAO
    {
        private static HangThanhVienDAO instance;

        public static HangThanhVienDAO Instance {
            get { if (instance == null) instance = new HangThanhVienDAO(); return instance; }
            set => instance = value; 
        }
        public HangThanhVienDAO() { }
        public List<HangThanhVien> GetAllHangThanhVien()
        {
            List<HangThanhVien> list = new List<HangThanhVien>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from HangThanhVien");
            foreach (DataRow dr in dt.Rows)
            {
                HangThanhVien hangThanhVien = new HangThanhVien(dr);
                list.Add(hangThanhVien);
            }
            return list; 
        }
        public HangThanhVien GetHangThanhVienByID(int id)
        {
            HangThanhVien htv = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from HangThanhVien WHERE id = "+id);
            foreach(DataRow dr in dt.Rows)
            {
                htv = new HangThanhVien(dr);
            }
            return htv;

        }
        public bool InsertHangThanhVien(string tenHang, int diemDieuKien, double giamGia)
        {
            int res = 0;
            res = DataProvider.Instance.ExecuteNonQuerry(string.Format("INSERT INTO HangThanhVien (tenHangThanhVien, diemDieuKien, phamTramGiam) VALUES (N'{0}', {1},{2})", tenHang, diemDieuKien, giamGia));
            return res > 0;
        }
        public bool UpdateHangThanhVien(int id, string tenHang, int diemDieuKien, double giamGia)
        {
            int res = 0;
            res = DataProvider.Instance.ExecuteNonQuerry(string.Format("UPDATE HangThanhVien SET tenHangThanhVien=N'{1}', diemDieuKien ={2}, phamTramGiam = {3} WHERE id ={0}", id, tenHang, diemDieuKien, giamGia));
            return res > 0;
        }
    }
}
