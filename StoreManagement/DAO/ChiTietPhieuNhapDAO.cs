using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.DAO
{
    public class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;

        public static ChiTietPhieuNhapDAO Instance {
            get { if (instance == null) instance = new ChiTietPhieuNhapDAO(); return instance; }
            private set => instance = value; 
        }
        public ChiTietPhieuNhapDAO() { }
        public List<ChiTietPhieuNhap> GetChiTietPhieuByIDPhieu(int idPhieu) 
        {
            List<ChiTietPhieuNhap> list = new List<ChiTietPhieuNhap> ();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from ChiTietPhieuNhap WHERE idPhieuNhap = " + idPhieu);
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap(dr);

                list.Add(chiTietPhieuNhap);
            }

            return list;
        }
        public List<ChiTietPhieuNhap> GetChiTietPhieuNhapByIDSanPham(int idSanPham)
        {
            List<ChiTietPhieuNhap> list = new List<ChiTietPhieuNhap>();

            DataTable dt = DataProvider.Instance.ExecuteQuerry("Select * from ChiTietPhieuNhap WHERE idSanPham = " + idSanPham);
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap(dr);

                list.Add(chiTietPhieuNhap);
            }

            return list;
        }
        public bool InsertChiTietPhieuNhapByIDPhieu(int idPhieuNhap, string maLoaiSanPham, string tenSanPham, string maSanPham, int giaBan, int giaNhap, int soLuong, byte[] anhSanPham)
        {
            int res = 0;

            string querry = "USP_InsertChiTietPhieuNhap @idBill , @idMaLoaiSanPham , @tenSanPham , @maSanPham , @giaBan , @giaNhap , @soLuong , @anhSanPham";
            res = DataProvider.Instance.ExecuteNonQuerry(querry, new object[] {idPhieuNhap, maLoaiSanPham, tenSanPham, maSanPham, giaBan, giaNhap, soLuong, anhSanPham });

            return res > 0;
        }
        public int GetCountChiTietPhieuNhap()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Count(*) From ChiTietPhieuNhap");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
