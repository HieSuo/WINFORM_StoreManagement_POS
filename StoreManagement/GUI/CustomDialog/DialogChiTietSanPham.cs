using Microsoft.Win32;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.CustomDialog
{
    public partial class DialogChiTietSanPham : Form
    {
        private SanPham sanPham;
        private List<ChiTietPhieuNhap> listLichSuNhap = new List<ChiTietPhieuNhap>();
        public DialogChiTietSanPham(SanPham sp)
        {
            InitializeComponent();
            this.sanPham = sp;
            txbMaSanPham.Text = sanPham.MaSanPham;
            txbTenSanPham.Text = sanPham.TenSanPham;
            txbGiaBan.Text = sanPham.GiaBan.ToString();
            txbSoLuong.Text = sanPham.SoLuongTonKho.ToString();
            cbTrangThai.SelectedItem = sanPham.TrangThai;
            picAnhSanPham.Image = sanPham.AnhSanPham;
            LoaiSanPhamDAO.Instance.LoadLoaiSanPhamToComboBox(cbLoaiSanPham);
            cbLoaiSanPham.SelectedValue = sanPham.IdLoaiSanPham;
            LoadData();
        }
        public void LoadData()
        {
            listLichSuNhap = ChiTietPhieuNhapDAO.Instance.GetChiTietPhieuNhapByIDSanPham(sanPham.Id);
            foreach(ChiTietPhieuNhap ct in  listLichSuNhap)
            {
                PhieuNhap pn = PhieuNhapDAO.Instance.GetPhieuNhapByID(ct.IdPhieuNhap);
                dgvLichSuNhap.Rows.Add(ct.IdPhieuNhap, pn.NgayTao, NhaCungCapDAO.Instance.GetNhaCungCapByID(pn.IdNCC).TenNCC, ct.SoLuongNhap, ct.GiaKhiNhap);
            }
        }
        public void UpLoadImage()
        {
            try
            {
                openFileDialog1.Filter = ("Ảnh sản phẩm (*.jpg, *.png, *.jpeg)|*.jpg; *.png; *.jpeg| PNG Files(*.png)|*.png");
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picAnhSanPham.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
        public void UpdateSanPham()
        {
            int id = sanPham.Id;
            string maSanPham = txbMaSanPham.Text;
            string tenSanPham = txbTenSanPham.Text;
            string idLoaiSanPham = (cbLoaiSanPham.SelectedItem as LoaiSanPham).Id;
            int soLuong = Convert.ToInt32(txbSoLuong.Text);
            int giaBan = Convert.ToInt32(txbGiaBan.Text);
            string trangThai = cbTrangThai.SelectedItem.ToString();
            Image anhSanPham = picAnhSanPham.Image;

            
            if(SanPhamDAO.Instance.UpdateSanPham(id,idLoaiSanPham,tenSanPham, maSanPham, giaBan, soLuong, CustomImageConverter.Instance.ConvertImageToByteArray(anhSanPham), trangThai))
            {
                if (updateSanPhamEV != null)
                {
                    updateSanPhamEV(this, new EventArgs());
                }

            }
        }
        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void noticeHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picSanPham_Click(object sender, EventArgs e)
        {
            UpLoadImage();
        }

        private void picAnhSanPham_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picAnhSanPham_MouseLeave(object sender, EventArgs e)
        {
           Cursor = Cursors.Default;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSanPham();
        }
        private event EventHandler updateSanPhamEV;
        public event EventHandler UpdateSanPhamEV
        {
            add { updateSanPhamEV += value;}
            remove { updateSanPhamEV -= value;}
        }

		private void DialogChiTietSanPham_Load(object sender, EventArgs e)
		{

		}
	}
}
