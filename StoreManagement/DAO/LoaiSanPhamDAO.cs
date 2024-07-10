using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace StoreManagement.DAO
{
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;

        public static LoaiSanPhamDAO Instance {
            get { if (instance == null) instance = new LoaiSanPhamDAO(); return instance; }
            private set => instance = value; }
        public LoaiSanPhamDAO() { }
        public List<LoaiSanPham> GetAllLoaiSanPham()
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from LoaiSanPham");
            foreach (DataRow dr in dt.Rows)
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham(dr);
                list.Add(loaiSanPham);
            }

            return list;
        }
		public List<LoaiSanPham> GetLoaiSanPhamByKeyword(string keyword)
		{
			List<LoaiSanPham> list = new List<LoaiSanPham>();

			DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from LoaiSanPham WHERE TenLoaiSanPham  Like '%"+ keyword + "%'");
			foreach (DataRow dr in dt.Rows)
			{
				LoaiSanPham loaiSanPham = new LoaiSanPham(dr);
				list.Add(loaiSanPham);
			}

			return list;
		}
		public int GetLoaiSanPhamDaBan(string idLoai)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT Count(*) FROM ChiTietHoaDon AS ct, SanPham AS sp WHERE ct.idSanPham = sp.id AND sp.idLoaiSanPham = '"+idLoai+"'");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        
        public Dictionary<String, double> GetRatioLoaiSanPhamBanRa()
        {
            Dictionary<String, double> keyValuePairs = new Dictionary<String, double>();
            int totalChiTiePhieu = ChiTietPhieuNhapDAO.Instance.GetCountChiTietPhieuNhap();
            List<LoaiSanPham> list = GetAllLoaiSanPham();
            //số lượng loại đã bán
            foreach(LoaiSanPham loaiSP in list)
            {
                double soLuongDaBan = (double) GetLoaiSanPhamDaBan(loaiSP.Id);
               // double tyle = soLuongDaBan / totalChiTiePhieu;
                keyValuePairs[loaiSP.TenLoaiSanPham] = soLuongDaBan;
            }
            return keyValuePairs;
        }
        public Dictionary<String, double> GetRatioLoaiSanPham()
        {
            Dictionary<String, double> keyValuePairs = new Dictionary<String, double>();
            int totalSanPham = SanPhamDAO.Instance.GetSoLuongSanPham();
            List<LoaiSanPham> list = GetAllLoaiSanPham();
            //số lượng loại đã bán
            foreach (LoaiSanPham loaiSP in list)
            {
                double soLuongSanPham = (double)SanPhamDAO.Instance.GetSoLuongSanPhamByLoaiSanPham(loaiSP.Id);
                // double tyle = soLuongDaBan / totalChiTiePhieu;
                keyValuePairs[loaiSP.TenLoaiSanPham] = soLuongSanPham;
            }
            return keyValuePairs;
        }
        public bool InsertLoaiSanPham(string id, string tenLoai)
        {
            string querry = "INSERT INTO LoaiSanPham (id, TenLoaiSanPham) VALUES ('"+id+"', N'"+tenLoai+"')";
            int res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res>0;
        }
        public bool UpdateLoaiSanPham(string id, string tenLoai)
        {
            string querry = string.Format("UPDATE LoaiSanPham SET TenLoaiSanPham = N'{0}' WHERE id = '{1}'", tenLoai, id);
            return DataProvider.Instance.ExecuteNonQuerry(querry) > 0;
        }
        public void LoadLoaiSanPhamToComboBox(System.Windows.Forms.ComboBox cbLoaiSanPham)
        {
            cbLoaiSanPham.DataSource = GetAllLoaiSanPham();
            cbLoaiSanPham.DisplayMember = "tenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "id";
        }
        public bool DeleteLoaiSanPham(string idLoaiSP)
        {
            int res = 0;
            List<SanPham> listSanPham= SanPhamDAO.Instance.GetSanPhamByLoaiHang(idLoaiSP);

            foreach (SanPham sp in listSanPham)
            {
                if (!SanPhamDAO.Instance.UpdateLSPNUll(sp.Id))
                {
                    MessageBox.Show("Lỗi khi update loại sản phẩm null trên các sản phẩm.");
                    return false;
                }
            }
            string querry = "DELETE LoaiSanPham WHERE id ='"+idLoaiSP+"'";
            res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res > 0;
        }
    }
}
