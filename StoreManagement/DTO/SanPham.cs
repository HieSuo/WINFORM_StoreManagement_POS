using StoreManagement.source;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DTO
{
    public class SanPham
    {
        private int id;
        private string idLoaiSanPham;
        private string tenSanPham;
        private string maSanPham;
        private int giaBan;
        private int soLuongTonKho;
        private Image anhSanPham;
        private string trangThai;
        public int Id { get => id; set => id = value; }
        public string IdLoaiSanPham { get => idLoaiSanPham; set => idLoaiSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuongTonKho { get => soLuongTonKho; set => soLuongTonKho = value; }
        public Image AnhSanPham { get => anhSanPham; set => anhSanPham = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public SanPham(int id, string idLoaiSanPham, string tenSanPham,string maSanPham, int giaBan, int soLuongTonKho, Image anhSanPham, string trangThai)
        {
            Id = id;
            IdLoaiSanPham = idLoaiSanPham;
            TenSanPham = tenSanPham;
            MaSanPham = maSanPham;
            GiaBan = giaBan;
            SoLuongTonKho = soLuongTonKho;
            AnhSanPham = anhSanPham;
            TrangThai = trangThai;  
        }
        public SanPham(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"].ToString());
            this.IdLoaiSanPham = row["idLoaiSanPham"].ToString();
            this.TenSanPham = row["TenSanPham"].ToString();
            this.maSanPham = row["MaSanPham"].ToString();
            this.giaBan = Convert.ToInt32(row["GiaBan"].ToString());
            this.SoLuongTonKho = Convert.ToInt32(row["SoLuongTonKho"].ToString());
            this.anhSanPham = CustomImageConverter.Instance.ConvertByteArrayToImage( (byte[]) row["anhSanPham"]);
            this.trangThai = row["trangthai"].ToString();
        } 
        
        public byte[] getByteArray()
        {
            byte[] imgArray = CustomImageConverter.Instance.ConvertImageToByteArray(this.anhSanPham);
            return imgArray;
        }
        

    }
}
