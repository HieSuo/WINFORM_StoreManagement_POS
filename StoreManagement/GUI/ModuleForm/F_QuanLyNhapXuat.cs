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
    public partial class F_QuanLyNhapXuat : Form
    {
        private Form activeForm;
        public F_QuanLyNhapXuat()
        {
            InitializeComponent();
            btnDSHoaDon_Click(this, EventArgs.Empty);
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
            panelChildContent.Controls.Add(childForm);
            panelChildContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            btnDSHoaDon.Font = new Font(btnDSHoaDon.Font, FontStyle.Bold);
            btnNhapHang.Font = new Font(btnNhapHang.Font, FontStyle.Regular);
            F_QuanLyHoaDon f_QuanLyHoaDon = new F_QuanLyHoaDon();
            openChildForm(f_QuanLyHoaDon);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            btnNhapHang.Font = new Font(btnNhapHang.Font, FontStyle.Bold);
            btnDSHoaDon.Font = new Font(btnDSHoaDon.Font, FontStyle.Regular);
            F_QuanLyPhieuNhap f_QuanLyPhieuNhap = new F_QuanLyPhieuNhap();
            openChildForm(f_QuanLyPhieuNhap);
        }
    }
}
