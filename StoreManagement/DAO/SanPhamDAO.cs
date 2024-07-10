using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }

            private set => instance = value;
        }
        public SanPhamDAO() { }
        public List<SanPham> GetAllSanPham()
        {
            List<SanPham> list = new List<SanPham>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham");

            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham(dr);
                list.Add(sp);
            }

            return list;
        }
        public List<SanPham> GetSanPhamConHang()
        {
            List<SanPham> list = new List<SanPham>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE SoLuongTonKho > 0 AND trangthai = N'Đang bán' ");

            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham(dr);
                list.Add(sp);
            }

            return list;
        }
        public List<SanPham> GetSanPhamByLoaiHang(string idLoaiHang)
        {
            List<SanPham> list = new List<SanPham>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE idLoaiSanPham='" + idLoaiHang + "'");

            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham(dr);
                list.Add(sp);
            }

            return list;
        }
        public List<SanPham> GetSanPhamConHangByLoaiHang(string idLoaiHang)
        {
            List<SanPham> list = new List<SanPham>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE idLoaiSanPham='" + idLoaiHang + "' AND SoLuongTonKho > 0 AND trangthai = N'Đang bán'");

            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham(dr);
                list.Add(sp);
            }

            return list;
        }
		public List<SanPham> GetSanPhamByTrangThai(string trangthai)
		{
			List<SanPham> list = new List<SanPham>();

			DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE trangthai = N'"+trangthai+"'");

			foreach (DataRow dr in dt.Rows)
			{
				SanPham sp = new SanPham(dr);
				list.Add(sp);
			}

			return list;
		}
		public List<SanPham> GetSanPhamByKeyWord(string keyword)
        {
            List<SanPham> list = new List<SanPham>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE TenSanPham LIKE '%" + keyword + "%' OR MaSanPham LIKE '%"+keyword+"%'");

            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham(dr);
                list.Add(sp);
            }

            return list;
        }
        public List<SanPham> GetSanPhamConHangByKeyWord(string keyword)
        {
            List<SanPham> list = new List<SanPham>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE (TenSanPham LIKE '%" + keyword + "%' OR MaSanPham LIKE '%"+keyword+"%') AND SoLuongTonKho > 0 AND trangthai = N'Đang bán'");

            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham(dr);
                list.Add(sp);
            }

            return list;
        }
        public ThongSoSanPhamDTO GetThongSoSanPhamByIDSanPham(int id)
        {
            ThongSoSanPhamDTO ts = null;
            string querry = "USP_GetThongSoSanPhamByIDSanPham @idSanPham";
            DataTable dt = DataProvider.Instance.ExecuteQuerry("USP_GetThongSoSanPhamByIDSanPham @idSanPham", new object[] {id });
            foreach(DataRow dr in dt.Rows)
            {
                ts = new ThongSoSanPhamDTO(dr);
                return ts;
            }
            return ts;
        }
        public List<ThongSoSanPhamDTO> GetListThongSoSanPham()
        {
            List<ThongSoSanPhamDTO> list = new List<ThongSoSanPhamDTO>();
            List<SanPham> listSP = GetAllSanPham();
            foreach(SanPham sp in listSP)
            {
                ThongSoSanPhamDTO ts = GetThongSoSanPhamByIDSanPham(sp.Id);
                list.Add(ts);
            }

            return list;
        }

        public bool InsertSanPham(string idLoaiSanPham, string tenSanPham, string maSanPham, int giaban, int soLuong, byte[] anhSanPham)
        {
            string querry = string.Format("INSERT INTO SanPham (idLoaiSanPham,TenSanPham,MaSanPham,GiaBan,SoLuongTonKho, anhSanPham, trangthai) VALUES ('{0}', N'{1}', '{2}', {3}, {4},{5}, N'Đang bán')", idLoaiSanPham, tenSanPham, maSanPham, giaban, soLuong, anhSanPham);
            return DataProvider.Instance.ExecuteNonQuerry(querry) > 0;

        }
        public SanPham GetSanPhamByBarcode(string barcode)
        {
            SanPham sp = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE maSanPham = '" + barcode + "'");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    return new SanPham(dr);

                }
            }
            return sp;

        }
        public SanPham GetSanPhamByID(int id)
        {
            SanPham sp = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * From SanPham WHERE id = " + id);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    return new SanPham(dr);

                }
            }
            return sp;
        }
        public bool UpdateSanPham(int id, string idLoaiSanPham, string tenSanPham, string maSanPham, int giaban, int soLuong, byte[] anhSanPham, string trangThai)
        {
            int res = 0;
            //string querry = string.Format("UPDATE SanPham SET idLoaiSanPham = N'{1}', TenSanPham =N'{2}', MaSanPham=N'{3}', SoLuongTonKho = {4}, GiaBan = {5} , anhSanPham = {6} , trangthai = N'{7}' WHERE id ={0}",
            //                              id, idLoaiSanPham, tenSanPham, maSanPham, soLuong, giaban, anhSanPham, trangThai);
            string querry = "USP_UpdateSanPham @id , @idLoaiSanPham , @tenSanPham , @maSanPham , @giaBan , @soLuongTonKho , @anhSanPham , @trangThai ";
            res = DataProvider.Instance.ExecuteNonQuerry(querry, new object[] {id,idLoaiSanPham,tenSanPham,maSanPham,giaban,soLuong,anhSanPham,trangThai});
            return res > 0;
        }
        public bool UpdateLSPNUll(int id)
        {
            int res = 0;
            string querry = "UPDATE SanPham Set idLoaiSanPham = 'NULL' WHERE id =" + id;
            res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res > 0;
        }
        public int GetSoLuongSanPham()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Count(*) From SanPham");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int GetSoLuongSanPhamByLoaiSanPham(string idLoai)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Count(*) From SanPham WHERE idLoaiSanPham ='"+idLoai+"'");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
