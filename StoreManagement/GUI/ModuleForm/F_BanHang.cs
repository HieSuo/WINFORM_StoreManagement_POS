using StoreManagement.DAO;
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

using AForge.Video;
using AForge.Video.DirectShow;
using StoreManagement.GUI.CustomDialog;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_BanHang : Form
    {
        private Account loginAccount;
        private List<SanPham> listSanPham = new List<SanPham>();
        private List<DanhSachHoaDon> listHoaDon;

        private FilterInfoCollection danhSachCamera;


        public F_BanHang(Account loginAccount)
        {
            InitializeComponent();
            this.loginAccount = loginAccount;

            LoadDanhSachCamera();
            LoadLoaiSanPhamIntoComboBox();

            LoadSanPham();

            listHoaDon = new List<DanhSachHoaDon>();
            this.loginAccount = loginAccount;
        }
        #region Method
        public void ReloadForm()
        {
            //LoadSanPham();
            listHoaDon.Clear();
            ReLoadList();
        }
        public void LoadSanPham()
        {
            listSanPham = SanPhamDAO.Instance.GetSanPhamConHang();
            HienThiDanhSachSanPham();
        }
        public void LoadDanhSachCamera()
        {
            danhSachCamera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in danhSachCamera)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            cbCamera.SelectedIndex = 0;
        }
        public void LoadLoaiSanPhamIntoComboBox()
        {
            LoaiSanPham lspAll = new LoaiSanPham("ALL", "Tất cả");
            cbLoaiSanPham.Items.Add(lspAll);
            List<LoaiSanPham> listSP = LoaiSanPhamDAO.Instance.GetAllLoaiSanPham();

            foreach (LoaiSanPham lsp in listSP)
            {
                cbLoaiSanPham.Items.Add(lsp);
            }
            cbLoaiSanPham.DisplayMember = "tenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "id";
            cbLoaiSanPham.SelectedIndex = 0;
        }
        void HienThiDanhSachSanPham()
        {
            flowDanhSachSP.Controls.Clear();
            foreach (SanPham sanPham in listSanPham)
            {
                ViewSanPham viewSanPham = new ViewSanPham(sanPham);
                viewSanPham.Click += ViewSanPham_Click;
                flowDanhSachSP.Controls.Add(viewSanPham);
            }
        }
        private void InsertDSSanPham(SanPham sp, int soLuong)
        {
            bool tonTai = false;
            DanhSachHoaDon ds = new DanhSachHoaDon(sp.Id, sp.MaSanPham, sp.TenSanPham, sp.GiaBan, soLuong);
            foreach (DanhSachHoaDon dsachCheck in listHoaDon)
            {
                if (ds.MaSanPham == dsachCheck.MaSanPham)
                {
                    tonTai = true;
                    dsachCheck.SoLuong += soLuong;
                }
            }
            if (!tonTai)
            {
                listHoaDon.Add(ds);
            }
        }
        public void ReLoadList()
        {
            dgvCurrentBill.Invoke((MethodInvoker)(() => dgvCurrentBill.Rows.Clear()));
            foreach (DanhSachHoaDon ds in listHoaDon)
            {
                dgvCurrentBill.Invoke((MethodInvoker)(() => dgvCurrentBill.Rows.Add(ds.MaSanPham, ds.TenSanPham,
                                                                                    ds.GiaBan.ToString("C", CultureInfo.GetCultureInfo("vi-VN")),
                                                                                    ds.SoLuong, ds.ThanhTien.ToString("C", CultureInfo.GetCultureInfo("vi-VN")))));
            }
            ReloadTotal();
        }
        public int TongGiaTriDonHang()
        {
            int tong = 0;
            foreach (DanhSachHoaDon ds in listHoaDon)
            {
                tong += ds.ThanhTien;
            }
            return tong;
        }
        public void ReloadTotal()
        {
            if (listHoaDon.Count > 0)
            {
                lbTongTien.Invoke((MethodInvoker)(() => lbTongTien.Text = "Thành tiền: " + TongGiaTriDonHang().ToString("C", CultureInfo.GetCultureInfo("vi-VN"))));
            }
            else
            {
                lbTongTien.Invoke((MethodInvoker)(() => lbTongTien.Text = "Thành tiền: " + 0.ToString("C", CultureInfo.GetCultureInfo("vi-VN"))));
            }
        }
        #endregion

        #region event click ...
        private void ViewSanPham_Click(object sender, EventArgs e)
        {
            SanPham sanPham = (sender as ViewSanPham).SanPham;
            if (txbThongTinSanPham.Tag != null && (txbThongTinSanPham.Tag as SanPham) == sanPham)
            {
                numbSoLuongSP.Value += 1;
            }
            else
            {
                numbSoLuongSP.Value = 1;
                txbThongTinSanPham.Text = sanPham.MaSanPham + "-" + sanPham.TenSanPham;
                txbThongTinSanPham.Tag = sanPham;
            }
        }

        private void btnThemSPVaoDS_Click(object sender, EventArgs e)
        {
            if (txbThongTinSanPham.Tag == null)
            {
                MessageBox.Show("Hãy chọn sản phẩm để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //if (MessageBox.Show("Them san pham: " + (txbThongTinSanPham.Tag as SanPham).TenSanPham, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                InsertDSSanPham((txbThongTinSanPham.Tag as SanPham), (int)numbSoLuongSP.Value);
                txbThongTinSanPham.Clear();
                txbThongTinSanPham.Tag = null;
                ReLoadList();
                //}
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            string keyWord = txbTimKiem.Text;
            listSanPham.Clear();
            listSanPham = SanPhamDAO.Instance.GetSanPhamConHangByKeyWord(keyWord);
            HienThiDanhSachSanPham();

        }

        //Camera scanner
        private void btnOnCamera_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice camera = new VideoCaptureDevice(danhSachCamera[cbCamera.SelectedIndex].MonikerString);
            CameraDialog dialogCam = new CameraDialog(camera);

            dialogCam.ScanBarcodeSuccess += DialogCam_ScanBarcodeSuccess;
            dialogCam.Show();
        }

        private void DialogCam_ScanBarcodeSuccess(object sender, source.SendSanPham e)
        {
            SanPham sp = e.SanPham;
            InsertDSSanPham(sp, 1);
            ReLoadList();
        }
        //Chọn khách hàng
        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            DialogChonKhachHang dialogChonKhachHang = new DialogChonKhachHang();
            dialogChonKhachHang.ChooseKhachHangEV += DialogChonKhachHang_ChooseKhachHangEV;
            dialogChonKhachHang.ShowDialog();
        }

        private void DialogChonKhachHang_ChooseKhachHangEV(object sender, source.SendKhachHang e)
        {
            KhachHang kh = e.KhachHang;
            txbKhachHangDuocChon.Text = kh.TenKhachHang;
            txbKhachHangDuocChon.Tag = kh;
        }
        //Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            KhachHang kh = txbKhachHangDuocChon.Tag as KhachHang;

            FormHoaDon formHoaDon = new FormHoaDon(loginAccount, listHoaDon, kh);
            formHoaDon.InsertSuccessEV += FormHoaDon_InsertSuccessEV;
            formHoaDon.ShowDialog();
        }

        private void FormHoaDon_InsertSuccessEV(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }
        #endregion

        private void cbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSanPham.Clear();
            if (cbLoaiSanPham.SelectedValue != null || (cbLoaiSanPham.SelectedItem as LoaiSanPham).Id != "ALL")
            {
                listSanPham = SanPhamDAO.Instance.GetSanPhamConHangByLoaiHang((cbLoaiSanPham.SelectedItem as LoaiSanPham).Id);
                HienThiDanhSachSanPham();
            }
            else
            {
                LoadSanPham();
            }
            
        }

        private void dgvCurrentBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurrentBill.Columns[e.ColumnIndex].Name == "delete")
            {
                if (MessageBox.Show("Xóa sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    listHoaDon.RemoveAt(e.RowIndex);
                    ReLoadList();
                }
            }
        }

        private void F_BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            flowDanhSachSP.Controls.Clear();
            listHoaDon.Clear();
            listSanPham.Clear();
            
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
