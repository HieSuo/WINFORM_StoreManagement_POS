using StoreManagement.GUI.ModuleForm.ModuleKhachHang;
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
    public partial class F_KhachHang : Form
    {
        private Form activeForm;
        public F_KhachHang()
        {
            InitializeComponent();
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
            F_DanhSachKhachHang f = new F_DanhSachKhachHang();
            openChildForm(f);
        }


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
            panelConTentCSKH.Controls.Add(childForm);
            panelConTentCSKH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            btnDSKH.Font = new Font(btnDSKH.Font, FontStyle.Bold);
            btnHangThanhVien.Font = new Font(btnHangThanhVien.Font, FontStyle.Regular);
            F_DanhSachKhachHang f = new F_DanhSachKhachHang();
            
            openChildForm(f);
        }

        private void btnHangThanhVien_Click(object sender, EventArgs e)
        {
            btnDSKH.Font = new Font(btnDSKH.Font, FontStyle.Regular);
            btnHangThanhVien.Font = new Font(btnHangThanhVien.Font, FontStyle.Bold);
            F_HangThanhVien f = new F_HangThanhVien();
            openChildForm(f);
        }
    }
}
