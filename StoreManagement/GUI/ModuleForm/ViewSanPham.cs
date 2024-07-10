using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class ViewSanPham : UserControl
    {
        private SanPham sanPham;
        public ViewSanPham(SanPham sanPham)
        {
            InitializeComponent();
            this.SanPham = sanPham;
            picSanPham.Image = sanPham.AnhSanPham;
            lbMaSP.Text = sanPham.MaSanPham;
            txbTenSP.Text = sanPham.TenSanPham;
            lbGiaBan.Text = sanPham.GiaBan.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            lbSoLuong.Text = "SL: " + sanPham.SoLuongTonKho;

            picSanPham.Click += PicSanPham_Click;
            lbMaSP.Click += PicSanPham_Click;
            lbGiaBan.Click += PicSanPham_Click;
            txbTenSP.Click += PicSanPham_Click;
            lbSoLuong.Click+= PicSanPham_Click;

        }

        private void PicSanPham_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        public SanPham SanPham { get => sanPham; set => sanPham = value; }
    }
}
