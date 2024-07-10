using StoreManagement.DAO;
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
    public partial class Dialog_ThemKhachHang : Form
    {
        public Dialog_ThemKhachHang()
        {
            InitializeComponent();
        }
        public string CheckEmptyForm()
        {
            string msg = "";

            if (txbHoTen.Text.Trim() == "")
                msg += "Tên khách hàng không được trống \n";
            if (txbSoDienThoai.Text.Trim() == "")
                msg += "Số điện thoại không được trống \n";
            if (txbDiaChi.Text.Trim() == "")
                msg += "Địa chỉ không được trống \n";

            return msg;
        }
        public void ThemMoiKhachHang()
        {
            string tenKH = txbHoTen.Text.Trim();
            string soDienThoai = txbSoDienThoai.Text.Trim();
            string diaChi = txbDiaChi.Text.Trim();
            if (CheckEmptyForm() == "")
            {
                if(KhachHangDAO.Instance.InsertKhachHang(tenKH, soDienThoai, diaChi)) {
                    if(insertKhachHangEV!=null)
                    {
                        insertKhachHangEV(this, new EventArgs());
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi thêm khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(CheckEmptyForm(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemMoiKhachHang();
            
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

        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dialog_ThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private event EventHandler insertKhachHangEV;
        public event EventHandler InsertKhachHangEV
        {
            add { insertKhachHangEV += value; }
            remove { insertKhachHangEV -= value; }
        }
    }
}
