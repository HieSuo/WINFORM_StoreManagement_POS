using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    public class ThongTinCuaHangDAO
    {
        private static ThongTinCuaHangDAO instance;

        public static ThongTinCuaHangDAO Instance 
        {
            get { if(instance==null) instance= new ThongTinCuaHangDAO(); return instance; } 
            private set => instance = value; 
        }
        public ThongTinCuaHangDAO() { }
        public ThongTinCuaHang GetThongTinCuaHang()
        {
            ThongTinCuaHang thongTin = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("SELECT * FROM ThongTinCuaHang");
            foreach(DataRow dr in dt.Rows )
            {
                thongTin = new ThongTinCuaHang(dr);
                return thongTin;
            }
            return thongTin;
        }
        public bool UpdateThongTInCuaHang(string tenCuaHang, string soDienThoai, string diaChi)
        {
            int res = DataProvider.Instance.ExecuteNonQuerry(string.Format("UPDATE ThongTinCuaHang SET tenCuaHang = N'{0}', soDienThoai = N'{1}', diaChi=N'{2}' WHERE id =1", tenCuaHang, soDienThoai, diaChi));
            return res > 0; ;
        }

        
    }
}
