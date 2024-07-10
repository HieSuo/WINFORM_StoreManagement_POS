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
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance 
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; } 
            private set => instance = value; 
        }
        public NhaCungCapDAO() { }
        public List<NhaCungCap> GetAllNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap> ();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from NhaCungCap");

            foreach (DataRow dr in dt.Rows)
            {
                NhaCungCap ncc = new NhaCungCap(dr);
                list.Add(ncc);
            }

            return list;
        }
		public List<NhaCungCap> GetNhaCungCapByKeyword(string keyword)
		{
			List<NhaCungCap> list = new List<NhaCungCap>();

			DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from NhaCungCap WHERE TenNCC Like '%" + keyword + "%' OR SoDienThoai  Like '%"+ keyword + "%'");

			foreach (DataRow dr in dt.Rows)
			{
				NhaCungCap ncc = new NhaCungCap(dr);
				list.Add(ncc);
			}

			return list;
		}
		public NhaCungCap GetNhaCungCapByID(int id)
        {
            NhaCungCap ncc = null;
            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from NhaCungCap WHERE id ="+ id);

            foreach (DataRow dr in dt.Rows)
            {
                ncc = new NhaCungCap(dr);
                return ncc;
            }

            return ncc;
        }
        public bool InsertNhaCungCap(string tenNCC, string soDienThoai, string diaChi)
        {
            string querry = string.Format("INSERT INTO NhaCungCap (TenNCC, SoDienThoai, DiaChi) VALUES (N'{0}', N'{1}', N'{2}')", tenNCC, soDienThoai, diaChi);
            return DataProvider.Instance.ExecuteNonQuerry(querry) > 0;
        }
        public bool UpdateNhaCungCap(int id, string tenNCC, string soDienThoai,  string diaChi)
        {
            string querry = string.Format("UPDATE NhaCungCap SET TenNCC=N'{1}', SoDienThoai=N'{2}', DiaChi = N'{3}' WHERE id = {0}", id, tenNCC, soDienThoai, diaChi);
            return DataProvider.Instance.ExecuteNonQuerry(querry) > 0;
        }
        public bool DeleteNhaCungCapByID(int idNCC)
        {
            int res = 0;
			List<PhieuNhap> listPhieuNhap = new List<PhieuNhap> ();
			listPhieuNhap = PhieuNhapDAO.Instance.GetAllPhieuNhapByIDNCC(idNCC);
			foreach (PhieuNhap pn in listPhieuNhap)
			{
				if (!PhieuNhapDAO.Instance.UpdateNCCNullByIDPhieuNhap(pn.Id))
				{
					MessageBox.Show("Lỗi khi update nhà cung cấp trên phiếu nhập");
					return false;
				}
			}
			string querry = "DELETE NhaCungCap WHERE id = " + idNCC;
			res = DataProvider.Instance.ExecuteNonQuerry(querry);
			return res > 0;
        }
    }
}
