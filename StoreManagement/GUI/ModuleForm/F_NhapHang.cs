using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.GUI.CustomDialog;
using StoreManagement.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_NhapHang : Form
    {
        private Account loginAccount;
        private List<DanhSachNhapHang> listNhapHang;
        public F_NhapHang(Account loginAccount)
        {
            InitializeComponent();
            // chỉnh kích thước form
            this.panelSanPham.Width = (panel1.Width - 20) / 2;
            this.panelHoaDon.Width = (panel1.Width - 20) / 2;

            LoadLoaiSanPhamIntoComboBox();
            LoadNhaCungCapIntoComboBox();
            this.loginAccount = loginAccount;
            txbNguoiTao.Text = loginAccount.DisplayName;

            listNhapHang = new List<DanhSachNhapHang>();
        }


        #region method

        public void LoadLoaiSanPhamIntoComboBox()
        {
            cbLoaiSanPham.DataSource = LoaiSanPhamDAO.Instance.GetAllLoaiSanPham();
            cbLoaiSanPham.DisplayMember = "tenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "id";
        }
        public void LoadNhaCungCapIntoComboBox()
        {
            cbNhaCungCap.DataSource = NhaCungCapDAO.Instance.GetAllNhaCungCap();
            cbNhaCungCap.DisplayMember = "tenNCC";
            cbNhaCungCap.ValueMember = "iD";
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
        public void ClearForm()
        {
            txbMaSanPham.Clear();
            txbDonGia.Clear();
            txbTenSanPham.Clear();
            txbSoLuong.Clear();
            txbDonGia.Clear();
            txbGiaBan.Clear();
        }
        public void InsertToList()
        {

            DanhSachNhapHang dsNhapHang = new DanhSachNhapHang(cbLoaiSanPham.SelectedValue.ToString(), txbTenSanPham.Text, txbMaSanPham.Text, Convert.ToInt32(txbGiaBan.Text), Convert.ToInt32(txbDonGia.Text), Convert.ToInt32(txbSoLuong.Text), picAnhSanPham.Image);
            if (CheckExistDS(txbMaSanPham.Text) == null)
            {
                if (MessageBox.Show("Nhap hang:", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    listNhapHang.Add(dsNhapHang);
                    ReLoadList();
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại, hãy chọn sản phẩm để sửa \n hoặc thêm sản phẩm khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        public void ReLoadList()
        {
            dgvNhapHang.Rows.Clear();

            foreach (DanhSachNhapHang ds in listNhapHang)
            {
                dgvNhapHang.Rows.Add(ds.MaSanPham, ds.TenSanPham, ds.IdLoaiSanPham, ds.GiaNhap, ds.GiaBan, ds.SoLuong, ds.AnhSP);
            }
        }
        public DanhSachNhapHang CheckExistDS(string maSP)
        {
            foreach (DanhSachNhapHang ds in listNhapHang)
            {
                if (ds.MaSanPham == maSP)
                {
                    return ds;
                }
            }
            return null;
        }
        public string CheckEmptyForm()
        {
            string msg = "";

            if (txbMaSanPham.Text.Trim() == "")
                msg += "Mã Sản phẩm không được trống \n";
            if (txbTenSanPham.Text.Trim() == "")
                msg += "Tên Sản phẩm không được trống \n";
            if (txbDonGia.Text.Trim() == "" || txbGiaBan.Text.Trim() == "")
                msg += "Giá phẩm không được trống \n";
            if (txbSoLuong.Text.Trim() == "")
                msg += "Số lượng không được trống \n";

            return msg;
        }
        public int TongGiaTriPhieuNhap()
        {
            int tongGiaTri = 0;
            if (listNhapHang.Count > 0)
            {
                foreach (DanhSachNhapHang ds in listNhapHang)
                {
                    tongGiaTri += (ds.GiaNhap * ds.SoLuong);
                }
            }
            else
            {
                tongGiaTri = 0;
            }


            return tongGiaTri;
        }
        public void ReloadTongGiaTri()
        {

            lbTongGiaTri.Text = "Tổng giá trị phiếu nhập : " + TongGiaTriPhieuNhap() + " VND";
        }
        public void InsertPhieuNhap()
        {
            string nguoiTao = loginAccount.UserName;
            int idNCC = (int)cbNhaCungCap.SelectedValue;
            int tongGiaTri = TongGiaTriPhieuNhap();
            bool insertSuccess = true;
            if (PhieuNhapDAO.Instance.InsertPhieuNhap(idNCC, nguoiTao, tongGiaTri))
            {
                int idPhieuNhap = PhieuNhapDAO.Instance.MaxIdPhieuNhap();

                foreach (DanhSachNhapHang ds in listNhapHang)
                {
                    string maLoaiSanPham = ds.IdLoaiSanPham;
                    string tenSanPham = ds.TenSanPham;
                    string maSanPham = ds.MaSanPham;
                    int giaBan = ds.GiaBan;
                    int giaNhap = ds.GiaNhap;
                    int soLuong = ds.SoLuong;
                    Image anhSanPham = ds.AnhSP;

                    if (!ChiTietPhieuNhapDAO.Instance.InsertChiTietPhieuNhapByIDPhieu(idPhieuNhap, maLoaiSanPham, tenSanPham, maSanPham, giaBan, giaNhap, soLuong, CustomImageConverter.Instance.ConvertImageToByteArray(anhSanPham)))
                    {
                        insertSuccess = false;
                    }

                }

            }
            if (insertSuccess)
            {
                MessageBox.Show("Tạo phiếu nhập thành công!");
                listNhapHang.Clear();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm phiếu nhập");
            }
        }
        #endregion


        #region event
        //resizing
        private void F_NhapHang_SizeChanged(object sender, EventArgs e)
        {
            this.panelSanPham.Width = (panel1.Width - 20) / 2;

            this.panelHoaDon.Width = (panel1.Width - 20) / 2;
        }
        //Import image
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            UpLoadImage();
        }


        private void btnChonSanPham_Click(object sender, EventArgs e)
        {
            DialogChonSanPham dialogChonSanPham = new DialogChonSanPham();
            dialogChonSanPham.ChooseSanPhamEV += DialogChonSanPham_ChooseSanPhamEV;
            dialogChonSanPham.ShowDialog();

        }

        private void DialogChonSanPham_ChooseSanPhamEV(object sender, source.SendSanPham e)
        {
            SanPham sp = e.SanPham;
            txbMaSanPham.Text = sp.MaSanPham;
            txbTenSanPham.Text = sp.TenSanPham;
            picAnhSanPham.Image = sp.AnhSanPham;
            string maLoai = sp.IdLoaiSanPham;
            cbLoaiSanPham.SelectedValue = maLoai;
            txbGiaBan.Text = sp.GiaBan + "";

        }

        private void txbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (CheckEmptyForm() != "")
            {
                MessageBox.Show(CheckEmptyForm(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InsertToList();
                ReloadTongGiaTri();
                ClearForm();
            }
        }

        private void dgvNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhapHang.Columns[e.ColumnIndex].Name == "delete")
            {

                if (MessageBox.Show("Xóa sản phẩm " + listNhapHang[e.RowIndex].TenSanPham + "-" + listNhapHang[e.RowIndex].MaSanPham + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    listNhapHang.Remove(listNhapHang[e.RowIndex]);
                    ReloadTongGiaTri();
                    ReLoadList();
                }
            }
            else
            {
                txbMaSanPham.Text = dgvNhapHang.CurrentRow.Cells[0].Value.ToString();
                txbTenSanPham.Text = dgvNhapHang.CurrentRow.Cells[1].Value.ToString();
                cbLoaiSanPham.SelectedValue = dgvNhapHang.CurrentRow.Cells[2].Value.ToString();
                txbDonGia.Text = dgvNhapHang.CurrentRow.Cells[3].Value.ToString();
                txbGiaBan.Text = dgvNhapHang.CurrentRow.Cells[4].Value.ToString();
                txbSoLuong.Text = dgvNhapHang.CurrentRow.Cells[5].Value.ToString();
                picAnhSanPham.Image = (Image)dgvNhapHang.CurrentRow.Cells[6].Value;

                lbMaVach.Tag = e.RowIndex;
            }
        }

        private void F_NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSLoaiSanPham.LoaiSanPham' table. You can move, or remove it, as needed.


        }

        private void btnSuaDanhSach_Click(object sender, EventArgs e)
        {
            if (lbMaVach.Tag != null)
            {
                if (CheckEmptyForm() != "")
                {
                    MessageBox.Show(CheckEmptyForm(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int index = (int)lbMaVach.Tag;
                    if (MessageBox.Show("Sửa thông tin sản phẩm " + listNhapHang[index].TenSanPham + "-" + listNhapHang[index].MaSanPham, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        listNhapHang[index].MaSanPham = txbMaSanPham.Text;
                        listNhapHang[index].TenSanPham = txbTenSanPham.Text;
                        listNhapHang[index].SoLuong = Convert.ToInt32(txbSoLuong.Text);
                        listNhapHang[index].IdLoaiSanPham = cbLoaiSanPham.SelectedValue.ToString();
                        listNhapHang[index].GiaNhap = Convert.ToInt32(txbDonGia.Text);
                        listNhapHang[index].GiaBan = Convert.ToInt32(txbGiaBan.Text);
                        listNhapHang[index].AnhSP = picAnhSanPham.Image;
                        ClearForm();
                        ReLoadList();
                        ReloadTongGiaTri();
                        lbMaVach.Tag = null;

                    }

                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResetSP_Click(object sender, EventArgs e)
        {
            ClearForm();
            lbMaVach.Tag = null;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (listNhapHang.Count == 0)
            {
                MessageBox.Show("Danh sách nhập hàng trống", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string msg = "iD nhà cung cấp: " + cbNhaCungCap.SelectedValue + "\nSố lượng sản phẩm: " + listNhapHang.Count + "\nNgười tạo: " + this.loginAccount.UserName + "\nTổn giá trị phiếu nhập: " + TongGiaTriPhieuNhap();
                if (MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    InsertPhieuNhap();
                    ReLoadList();
                }

            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listNhapHang.Clear();
            ReLoadList();
            ReloadTongGiaTri();
        }




        #endregion

        /// end region event
    }
}
