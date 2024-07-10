using StoreManagement.DAO;
using StoreManagement.DTO;
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

namespace StoreManagement.GUI.CustomDialog
{
    public partial class DialogChonSanPham : Form
    {
        public DialogChonSanPham()
        {
            InitializeComponent();
           
        }

        public void LoadData()
        {
            dgvSanPham.DataSource = SanPhamDAO.Instance.GetAllSanPham();
        }

        #region event
        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[0].Value);
            string idLoaiSanPham = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            string tenSP = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            int giaBan = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[3].Value);
            int soLuong = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[4].Value);
            Image anhSP = (Image) dgvSanPham.CurrentRow.Cells[5].Value;
            string maSanPham = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
            string trangthai = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
            SanPham sp = new SanPham(id, idLoaiSanPham, tenSP, maSanPham,giaBan, soLuong,anhSP, trangthai);
            //MessageBox.Show(string.Format("id{0} Loai{1} ten{2} gia{3} soluong{4} anh{5} ma{6} tt{7}", id, idLoaiSanPham, tenSP, giaBan, soLuong, anhSP, maSanPham, trangthai));
            if(MessageBox.Show("Chac chan them", "Thong bao", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (chooseSanPhamEV != null)
                {
                    chooseSanPhamEV(this, new SendSanPham(sp));
                }
            }
            
        }

        private event EventHandler<SendSanPham> chooseSanPhamEV;
        public event EventHandler<SendSanPham> ChooseSanPhamEV
        {
            add { chooseSanPhamEV += value; }
            remove { chooseSanPhamEV -= value; }
        }
    }
}
