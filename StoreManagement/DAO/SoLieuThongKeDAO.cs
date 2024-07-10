using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    public class SoLieuThongKeDAO
    {
        private static SoLieuThongKeDAO instance;

        public static SoLieuThongKeDAO Instance {
            get { if (instance == null) instance = new SoLieuThongKeDAO(); return instance; } private set => instance = value; }
        public SoLieuThongKeDAO() { }

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
                return (int)DataProvider.Instance.ExecuteScalar("USP_TongDoanhThuByDate @dayFrom , @dayTo", new object[] {dayFrom, dayTo});
            }
            catch (Exception ex)
            {
                return -1;
            }
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

    }

}
