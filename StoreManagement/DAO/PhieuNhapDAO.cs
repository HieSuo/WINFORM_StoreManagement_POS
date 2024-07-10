using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace StoreManagement.DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public static PhieuNhapDAO Instance 
        {
            get { if (instance == null) instance = new PhieuNhapDAO(); return instance; } 
            set => instance = value; 
        }
        public PhieuNhapDAO() { }
        public List<PhieuNhap> GetAllPhieuNhap()
        {
            List<PhieuNhap> list = new List<PhieuNhap>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from PhieuNhap");
            foreach (DataRow dr in dt.Rows)
            {
                PhieuNhap pn = new PhieuNhap(dr);
                list.Add(pn);
            }

            return list;
        }
		public List<PhieuNhap> GetAllPhieuNhapByIDNCC(int idNCC)
		{
			List<PhieuNhap> list = new List<PhieuNhap>();

			DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from PhieuNhap WHERE idNhaCungCap = "+ idNCC);
			foreach (DataRow dr in dt.Rows)
			{
				PhieuNhap pn = new PhieuNhap(dr);
				list.Add(pn);
			}

			return list;
		}
        public List<PhieuNhap> GetPhieuNhapByIDNguoiTao(string username)
        {
			List<PhieuNhap> list = new List<PhieuNhap>();

			DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from PhieuNhap WHERE idNguoiTao = N'"+username+"'");
			foreach (DataRow dr in dt.Rows)
			{
				PhieuNhap pn = new PhieuNhap(dr);
				list.Add(pn);
			}

			return list;
		}
		public PhieuNhap GetPhieuNhapByID(int id)
        {
            PhieuNhap pn = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from PhieuNhap Where id = " + id);
            foreach (DataRow dr in dt.Rows)
            {
                pn = new PhieuNhap(dr);
                return pn;
            }

            return pn;
        }

        public int MaxIdPhieuNhap()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(id) From PhieuNhap");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public bool InsertPhieuNhap(int idNCC, string username, int tongGiaTri)
        {
            string querry = "USP_InsertPhieuNhap @idNhaCungCap , @idNguoiTao , @tongGiaTri";
            return DataProvider.Instance.ExecuteNonQuerry(querry, new object[] { idNCC, username, tongGiaTri })>0;
        }
        public int GetTongChi()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Sum(TongGiaTri) From PhieuNhap");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int GetTongChiByDate(DateTime dayFrom, DateTime dayTo)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("USP_TongChiTieuByDate @dayFrom , @dayTo", new object[] { dayFrom, dayTo });
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public Dictionary<DateTime, int> GetChiTieuPerDay()
        {
            Dictionary<DateTime, int> incomePerDayPairs = new Dictionary<DateTime, int>();
            string querry = "SELECT CONVERT(date, NgayTao) AS NgayTao, SUM(TongGiaTri) AS TongChiTieu FROM PhieuNhap GROUP BY CONVERT(date, ngayTao)";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(querry);
            foreach (DataRow dr in dt.Rows)
            {
                incomePerDayPairs[(DateTime)dr["NgayTao"]] = (int)dr["TongChiTieu"];
            }
            return incomePerDayPairs;
        }
        public Dictionary<DateTime, int> GetChiTieuPerDayByDate(DateTime dayFrom, DateTime dayTo)
        {
            Dictionary<DateTime, int> incomePerDayPairs = new Dictionary<DateTime, int>();
            string querry = "USP_GetChiTieuPerDayByDate @dayFrom , @dayTo";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(querry, new object[] {dayFrom, dayTo});
            foreach (DataRow dr in dt.Rows)
            {
                incomePerDayPairs[(DateTime)dr["NgayTao"]] = (int)dr["TongChiTieu"];
            }
            return incomePerDayPairs;
        }
		public bool UpdateNCCNullByIDPhieuNhap(int idPN)
		{
			int res = 0;
			res = DataProvider.Instance.ExecuteNonQuerry("Update PhieuNhap Set idNhaCungCap = 5 WHERE id = " + idPN);
			return res > 0;
		}
		public bool UpdateNguoiTaoNullByIDPhieuNhap(int idPN)
		{
			int res = 0;
			res = DataProvider.Instance.ExecuteNonQuerry("Update PhieuNhap Set idNguoiTao = 'null' WHERE id = " + idPN);
			return res > 0;
		}
	}
}

