using FontAwesome.Sharp;
using StoreManagement.GUI;
using StoreManagement.GUI.CustomDialog;
using StoreManagement.GUI.ModuleForm;
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

namespace StoreManagement
{
    public partial class MainForm : Form
    {
        private IconButton currentButton;
        private Form activeForm;

        private bool isLogin = false;
        public MainForm()
        {
            InitializeComponent();
            //setup for fullscreen contain taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Set login form open

            SetUpLoginForm();
        }
        #region method
        // Add form to MainContent
        private void openChildForm(Form childForm)
        {
            if(activeForm!= null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void SetUpLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.LoginSuccessEvent += LoginForm_LoginSuccessEvent;
            openChildForm(loginForm);

        }
        //event login sucess
        private void LoginForm_LoginSuccessEvent(object sender, SendAccount e)
        {
            HomePage homePage = new HomePage(e.Account);
            homePage.LogOutEvent += HomePage_LogOutEvent;
            isLogin = true;
            openChildForm(homePage);
        }

        private void HomePage_LogOutEvent(object sender, EventArgs e)
        {
            isLogin = false;
            SetUpLoginForm();
        }
        
        #endregion
        //Custom header bar -Drag form, close button
        #region Custom header bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            WindowState = FormWindowState.Normal;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
            
        }
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


		#endregion

		private void iconHomeButton_Click(object sender, EventArgs e)
		{
            if (!isLogin)
            {
                return;
            }
            DialogThongTinCuaHang dialogThongTinCuaHang = new DialogThongTinCuaHang();
            dialogThongTinCuaHang.ShowDialog();
		}
	}
}
