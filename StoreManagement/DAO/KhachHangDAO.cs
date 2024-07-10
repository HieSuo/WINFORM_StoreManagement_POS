using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StoreManagement.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set => instance = value; 
        }
        public KhachHangDAO() { }
        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> list = new List<KhachHang> ();
            DataTable dt = DataProvider.Instance.ExecuteQuerry("select * from KhachHang");
            foreach (DataRow dr in dt.Rows)
            {
                KhachHang kh = new KhachHang(dr);
                list.Add(kh);
            }

            return list;
        }
        public KhachHang GetKhachHangByID(int id)
        {
            KhachHang kh = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from KhachHang WHERE id =" + id);
            foreach (DataRow dr in dt.Rows)
            {
                kh = new KhachHang(dr);
                return kh;
            }
            return kh;
        }
		public List<KhachHang> GetKhachHangByKeyWord(string keyword)
		{
			List<KhachHang> list = new List<KhachHang>();
			DataTable dt = DataProvider.Instance.ExecuteQuerry("select * from KhachHang WHERE TenKhachHang Like '%"+ keyword + "%' OR SoDienThoai Like '%"+ keyword + "%'");
			foreach (DataRow dr in dt.Rows)
			{
				KhachHang kh = new KhachHang(dr);
				list.Add(kh);
			}

			return list;
		}
		public bool InsertKhachHang(string tenKhachHang, string soDienThoai, string diaChi)
        {
            string querry = string.Format("INSERT INTO KhachHang (TenKhachHang, SoDienThoai, DiaChi, DiemTichLuy, idHangThanhVien) VALUES (N'{0}', '{1}', N'{2}', 0, 1)", tenKhachHang, soDienThoai, diaChi);
            int res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res > 0;
        }
        public bool UpdateHangThanhVienByIDKhachHang(int idKhachHang)
        {
            string querry = "EXEC USP_UpdateHangThanhVienByIDKhachHang @idKhachHang";
            int res = DataProvider.Instance.ExecuteNonQuerry(querry,new object[]{ idKhachHang});
            return res > 0;
        }
        
        public bool UpdateThongTinKhachHang(int idKH, string tenKH, string soDienThoai, string diaChi)
        {
            int res = 0;
            string querry = string.Format("UPDATE KhachHang SET TenKhachHang = N'{0}', SoDienThoai = N'{1}', DiaChi = N'{2}' WHERE id = {3}", tenKH, soDienThoai, diaChi, idKH);
            res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res > 0;
        }
        public bool DeleteKhachHang(int idKH)
        {
            int res = 0;
            List<HoaDon> listHoaDon = HoaDonDAO.Instance.GetHoaDonByIDKhachHang(idKH);
           
            foreach(HoaDon hd in listHoaDon)
            {
                if (!HoaDonDAO.Instance.UpdateKHNullByIDHoaDon(hd.Id))
                {
                    MessageBox.Show("Lỗi khi update khách hàng trên hóa đơn");
                    return false;
                }
            }
            string querry = "DELETE KhachHang WHERE id =" + idKH;
            res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res > 0;
        }
    }
}
