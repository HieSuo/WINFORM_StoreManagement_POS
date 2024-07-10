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
    public partial class NoticeDialog : Form
    {
       
        public NoticeDialog(string noticeHeader, string noticeText)
        {
            InitializeComponent();
            lbNoticeHeader.Text = noticeHeader;
            lbNoticeText.Text = noticeText;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void Show(NoticeDialog dialog)
        {
            dialog.ShowDialog();
        }
#region lib drag header
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
    }
}
