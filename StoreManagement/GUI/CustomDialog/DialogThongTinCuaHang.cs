using StoreManagement.DAO;
using StoreManagement.DTO;
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
	public partial class DialogThongTinCuaHang : Form
	{
		private ThongTinCuaHang ttCuaHang;
		public DialogThongTinCuaHang()
		{
			InitializeComponent();
			ttCuaHang = ThongTinCuaHangDAO.Instance.GetThongTinCuaHang();
			txbTenCH.Text = ttCuaHang.TenCuaHang;
			txbSoDienThoai.Text = ttCuaHang.SoDienThoai;
			txbDiaChi.Text = ttCuaHang.DiaChi;

		}

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

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string tenCuaHang = txbTenCH.Text;
			string sdt = txbSoDienThoai.Text;
			string diaChi = txbDiaChi.Text;
			if(tenCuaHang.Length == 0 || sdt.Length==0 || diaChi.Length==0) 
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if(ThongTinCuaHangDAO.Instance.UpdateThongTInCuaHang(tenCuaHang, sdt, diaChi))
			{
				MessageBox.Show("Thông tin đã được cập nhật!", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
