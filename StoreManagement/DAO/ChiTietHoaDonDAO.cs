using StoreManagement.DTO;
using StoreManagement.source;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance {
            get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; }
            set => instance = value; 
        }
        public ChiTietHoaDonDAO() { }
        public List<ChiTietHoaDon> GetAllChiTietHoaDons()
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon> ();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from ChiTietHoaDon");
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(dr);
                list.Add(chiTietHoaDon);
            }

            return list;
        }
        public List<ChiTietHoaDon> GetChiTietHoaDonByIDHoaDon(int idHoaDon)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from ChiTietHoaDon WHERE idHoaDon = "+ idHoaDon);
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(dr);
                list.Add(chiTietHoaDon);
            }

            return list;

        }
        public bool InsertChiTietHoaDon(int idHoaDon, int idSanPham, int soLuong, int giaKhiBan)
        {
            int res = 0;

            string querry = "USP_ThemChiTietHoaDon @idHoaDon , @idSanPham , @soLuong , @giaKhiBan";
            res = DataProvider.Instance.ExecuteNonQuerry(querry, new object[] { idHoaDon, idSanPham, soLuong, giaKhiBan });

            return res > 0;
        }
    }
}
