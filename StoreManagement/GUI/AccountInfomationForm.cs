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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI
{
    public partial class AccountInfomationForm : Form
    {
        private Account accountLogin;

        public Account AccountLogin { get => accountLogin; 
            set { accountLogin = value; ChangeAccount(accountLogin); }
        }
        void ChangeAccount(Account account)
        {
            txbUserName.Text = account.UserName;
            txbDisplayName.Text = account.DisplayName;
        }

        public AccountInfomationForm(Account account)
        {
            InitializeComponent();
            this.AccountLogin = account;
           
        }

        #region Method Update

        private void UpdateAccountInfor()
        {
            string username = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            string password = txbPassword.Text;
            string newPassword = txbNewPassword.Text;
            string confirmPassord = txbConfirmPassword.Text;
            if(username.Length==0 ||displayName.Length==0 || password.Length==0 || newPassword.Length==0||confirmPassord.Length==0)
            {
                NoticeDialog.Show(new NoticeDialog("Lỗi", "Không được để trống thông tin!"));
                return;
            }
            if(confirmPassord == newPassword )
            {
                if(AccountDAO.Instance.UpdateAccountInfor(username, displayName, password,newPassword)) 
                {
                    NoticeDialog.Show(new NoticeDialog("Cập nhật thành công", "Tài khoản của bạn đã được cập nhật thông tin!"));
                    if (updateAccountInforEV != null)
                    {
                        updateAccountInforEV(this, new SendAccount(AccountDAO.Instance.GetAccountByUserName(username)));
                    }
                }
                else
                {
					NoticeDialog.Show(new NoticeDialog("Lỗi", "Cập nhật lỗi, vui lòng kiểm tra lại mật khẩu!"));
					return;
				}
            }
            else
            {
                NoticeDialog.Show(new NoticeDialog("Sai mật khẩu", "Hãy kiểm tra lại mật khẩu vừa nhập!"));
            }
        }

        #endregion


        #region lib drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void noticeHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            UpdateAccountInfor();
        }

        private event EventHandler<SendAccount> updateAccountInforEV;
        public event EventHandler<SendAccount> UpdateAccountInforEV
        {
            add { updateAccountInforEV += value; }
            remove { updateAccountInforEV -= value;}
        }
    }
}
