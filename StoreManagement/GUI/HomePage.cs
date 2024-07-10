using FontAwesome.Sharp;
using StoreManagement.DTO;
using StoreManagement.GUI.CustomDialog;
using StoreManagement.GUI.ModuleForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI
{
    public partial class HomePage : Form
    {
        private Form activeForm;
        private Account accountLogin;
        private IconButton currentButton;
        public Account AccountLogin { 
            get => accountLogin;
            set { accountLogin = value; ChangeAccount(accountLogin); } 
        }
        public void ChangeAccount(Account account)
        {
            lbDisplayName.Text = accountLogin.DisplayName;
        }
        public HomePage(Account accountLogin)
        {

            InitializeComponent();
            this.AccountLogin = accountLogin;
            
            F_TrangChu f_TrangChu = new F_TrangChu();
            openChildForm(f_TrangChu);

        }
        #region Method
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = sender as IconButton;
                currentButton.BackColor = Color.FromArgb(215, 220, 234);
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(232, 232, 232);
            }
        }

        #endregion


        //Element Evet ex: onclick,...
        #region Event
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_TrangChu f_TrangChu = new F_TrangChu();
            openChildForm(f_TrangChu);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_BanHang f_BanHang = new F_BanHang(accountLogin);
            openChildForm(f_BanHang);
        }

        private void btnQuanLyHangHoa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_QuanLyHangHoa f_QuanLyHangHoa = new F_QuanLyHangHoa();
            openChildForm(f_QuanLyHangHoa);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_KhachHang f_KhachHang = new F_KhachHang();
            openChildForm(f_KhachHang);
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if(AccountLogin.Type == 1)
            {
                ActivateButton(sender);
                F_QuanLyTaiKhoan f_QuanLyTaiKhoan = new F_QuanLyTaiKhoan();
                openChildForm(f_QuanLyTaiKhoan);
            }
            else
            {
                NoticeDialog.Show(new NoticeDialog("Không thể truy cập chức năng", "Tài khoản của bạn không có quyền sử dụng chức năng này!"));
            }
        }

        // Logout

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (logOutEvent != null)
            {
                logOutEvent(this, new EventArgs());
            }
        }
        private event EventHandler logOutEvent;
        public event EventHandler LogOutEvent
        {
            add { logOutEvent += value; }
            remove { logOutEvent -= value; }
        }


        // edit accoount

        private void btniconPerson_Click(object sender, EventArgs e)
        {
            AccountInfomationForm f_Information = new AccountInfomationForm(AccountLogin);
            f_Information.UpdateAccountInforEV += F_Information_UpdateAccountInforEV;
            f_Information.ShowDialog();
        }

        private void F_Information_UpdateAccountInforEV(object sender, source.SendAccount e)
        {
           accountLogin = e.Account;
           lbDisplayName.Text = accountLogin.DisplayName;
        }


        private void btnQLLoaiHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_LoaiHang f_LoaiHang = new F_LoaiHang();
            openChildForm(f_LoaiHang);
        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_NhaCungCap f_NhaCungCap = new F_NhaCungCap();
            openChildForm(f_NhaCungCap);
        }
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_NhapHang f_NhapHang = new F_NhapHang(accountLogin);
            openChildForm(f_NhapHang);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            F_QuanLyNhapXuat f_QuanLyNhapXuat = new F_QuanLyNhapXuat();
            openChildForm(f_QuanLyNhapXuat);
        }

        #endregion

    }
}
