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

namespace StoreManagement.GUI
{
    public partial class LoginForm : Form
    {
        //

       // private Account acountLogin;

        //
        public LoginForm()
        {
            InitializeComponent();
        }

        //Mehthod login
        #region method
        public bool checkLogin(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
        #endregion
        //Elements event
        #region Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text.Trim() == "" || txbUserName.Text.Trim() == "")
            {
                NoticeDialog.Show(new NoticeDialog("Không được để trống thông tin", "Hãy nhập tài khoản và mật khẩu để đăng nhập!"));
            }
            else
            {
                if (checkLogin(txbUserName.Text, txbPassword.Text))
                {
                    Account accountLogin = AccountDAO.Instance.GetAccountByUserName(txbUserName.Text);
                    if(loginSuccessEvent!= null)
                    {
                        loginSuccessEvent(this, new SendAccount(accountLogin));
                    }
                }
                else
                {
                    NoticeDialog dialogCheckLogin = new NoticeDialog("Đăng nhập không thành công", "Tài khoản không tồn tại, vui lòng kiểm tra lại");
                    dialogCheckLogin.StartPosition = FormStartPosition.CenterParent;
                    dialogCheckLogin.ShowDialog();
                }
            }            
        }
        #endregion

        // Create event handler

        //event login
        private event EventHandler<SendAccount> loginSuccessEvent;
        public event EventHandler<SendAccount> LoginSuccessEvent
        {
            add { loginSuccessEvent += value; }
            remove { loginSuccessEvent -= value; }
        }
    } 
}
