using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set => instance = value;
        }
        public HoaDonDAO() { }
        public List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from HoaDon");
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hd = new HoaDon(dr);
                list.Add(hd);
            }

            return list;
        }
        public HoaDon GetHoaDonByID(int id)
        {
            HoaDon hoaDon = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from HoaDon WHERE id ="+id);
            foreach (DataRow dr in dt.Rows)
            {
                hoaDon = new HoaDon(dr);
                return hoaDon;
            }

            return hoaDon;
        }
		public List<HoaDon> GetHoaDonByIDKhachHang(int idKH)
		{
			List<HoaDon> listHD = new List<HoaDon>();
			DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from HoaDon WHERE idKhacHang =" + idKH);
			foreach (DataRow dr in dt.Rows)
			{
				HoaDon hoaDon = new HoaDon(dr);
				listHD.Add(hoaDon);
			}

            return listHD;
		}
        public bool UpdateKHNullByIDHoaDon(int idHD)
        {
            int res = 0;
            res = DataProvider.Instance.ExecuteNonQuerry("Update HoaDon Set idKhacHang = 3 WHERE id = " + idHD);

            return res > 0;
        }
		public List<HoaDon> GetHoaDonByIDNguoiTao(string username)
		{
			List<HoaDon> listHD = new List<HoaDon>();
			DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from HoaDon WHERE idNguoiTao = '" +username+"'");
			foreach (DataRow dr in dt.Rows)
			{
				HoaDon hoaDon = new HoaDon(dr);
				listHD.Add(hoaDon);
			}

			return listHD;
		}
		public bool UpdateNguoiTaoNullByIDHoaDon(int idHD)
		{
			int res = 0;
			res = DataProvider.Instance.ExecuteNonQuerry("Update HoaDon Set idNguoiTao = 'null' WHERE id = "+idHD);

			return res > 0;
		}

		public Dictionary<DateTime, int> GetIncomePerDay()
        {
            Dictionary<DateTime, int> incomePerDayPairs = new Dictionary<DateTime, int>();
            string querry = "SELECT CONVERT(date, NgayTao) AS NgayTao, SUM(TongGiaTri) AS TongThuNhap FROM HoaDon GROUP BY CONVERT(date, ngayTao)";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(querry);
            foreach (DataRow dr in dt.Rows)
            {
                incomePerDayPairs[(DateTime)dr["NgayTao"]] = (int) dr["TongThuNhap"];
            }
            return incomePerDayPairs;
        }
        public Dictionary<DateTime, int> GetIncomePerDayByDate(DateTime dayFrom, DateTime dayTo)
        {
            Dictionary<DateTime, int> incomePerDayPairs = new Dictionary<DateTime, int>();

            string querry = "USP_GetIncomePerDayByDate  @dayFrom , @dayTo";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(querry, new object[] {dayFrom, dayTo});
            foreach (DataRow dr in dt.Rows)
            {
                incomePerDayPairs[(DateTime)dr["NgayTao"]] = (int)dr["TongThuNhap"];
            }
            return incomePerDayPairs;
        }
        public int MaxIdHoaDon()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(id) From HoaDon");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int GetTongThu()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Sum(TongGiaTri) From HoaDon");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int GetTongThuByDay(DateTime dayFrom, DateTime dayTo)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("USP_TongDoanhThuByDate @dayFrom , @dayTo", new object[] { dayFrom, dayTo });
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public List<HoaDon> GetListHoaDonByDate(DateTime dayFrom, DateTime dayTo)
        {
            List<HoaDon> list = new List<HoaDon>();
            DataTable dt = DataProvider.Instance.ExecuteQuerry("USP_GetHoaDonByDate @dayFrom , @dayTo", new object[] { dayFrom, dayTo });
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hd = new HoaDon(dr);
                list.Add(hd);
            }

            return list;
        }
        public bool InsertHoaDon(int idKhachHang, int tongGiaTri, double giamGia, string idNguoiTao)
        {
            string querry = "USP_ThemMoiHoaDon @idKhachHang , @tongGiaTri , @giamGia , @idNguoiTao";
            return DataProvider.Instance.ExecuteNonQuerry(querry, new object[] { idKhachHang, tongGiaTri, giamGia, idNguoiTao}) > 0;
        }
    }
}
