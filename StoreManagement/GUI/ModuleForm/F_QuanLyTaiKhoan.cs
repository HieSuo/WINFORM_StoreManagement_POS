using StoreManagement.DAO;
using StoreManagement.DTO;
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
    public partial class F_QuanLyTaiKhoan : Form
    {
        List<Account> listAccount = new List<Account>();
   
        public F_QuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            listAccount.Clear();
            dgvAccount.Rows.Clear();
            listAccount = AccountDAO.Instance.GetAllAccount();
            foreach (Account account in listAccount) {
                string role="";
                switch (account.Type)
                {
                    case 1:
                        role = "admin";
                        break;
                    case 0:
                        role = "Nhân viên";
                        break;
                }
                dgvAccount.Rows.Add(account.UserName, account.DisplayName, role);
            }
        }
		public void LoadTimKiemTaiKhoan(string keyword)
		{
			listAccount.Clear();
			dgvAccount.Rows.Clear();
			listAccount = AccountDAO.Instance.GetAccountByKeyword(keyword);
			foreach (Account account in listAccount)
			{
				string role = "";
				switch (account.Type)
				{
					case 1:
						role = "admin";
						break;
					case 0:
						role = "Nhân viên";
						break;
				}
				dgvAccount.Rows.Add(account.UserName, account.DisplayName, role);
			}
		}
		public string CheckEmptyForm()
        {
            string msg = "";

            if (txbUsername.Text == "")
            {
                msg += "UserName không được để trống";
            }
            if (txbTenHienThi.Text == "")
            {
                msg += "Tên hiển thị không được để trống";
            }
            return msg;
        }
        public void InsertAccount()
        {
            string username = txbUsername.Text;
            string displayName = txbTenHienThi.Text;
            int type = (cbLoaiTaiKhoan.SelectedText == "admin") ? 1 : 0;

            if(!AccountDAO.Instance.InsertAccount(username, displayName, type))
            {
                MessageBox.Show("Lỗi thêm tài khoản!");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
        }
        public void UpdateAccount()
		{
			string username = txbUsername.Text;
			string displayName = txbTenHienThi.Text;
			int type = (cbLoaiTaiKhoan.SelectedText == "admin") ? 1 : 0;
			if (!AccountDAO.Instance.UpdateAccount(username, displayName, type))
			{
				MessageBox.Show("Lỗi thêm tài khoản!");
			}
			else
			{
				MessageBox.Show("Thêm tài khoản thành công!");
			}
		}

		public void ClearForm()
        {
            txbUsername.Clear();
            txbTenHienThi.Clear();
        }
        #region EVENTS
        
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (CheckEmptyForm() != "")
            {
                MessageBox.Show(CheckEmptyForm(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InsertAccount();
                LoadData();
                ClearForm();
            }
        }

        #endregion

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			string username = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            if (username == "null")
            {
                MessageBox.Show("Không được sửa đối tượng này!");
                return;
            }
			if (dgvAccount.Columns[e.ColumnIndex].Name == "delete")
            {
               if(MessageBox.Show("Chắc chắn muốn xóa "+username+" ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (AccountDAO.Instance.DeleteAccount(username))
                    {
                        LoadData();
                    }
                    else
                    {
						MessageBox.Show("Xóa không thành công!");
					}
                }
            }
            else if (dgvAccount.Columns[e.ColumnIndex].Name == "reset")
            {
                if(MessageBox.Show("Đặt lại mật khẩu tài khoản thành 1?" , "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (AccountDAO.Instance.ResetPassword(username))
                    {
                        MessageBox.Show("Đặt lại mật khẩu thành công!");
                    }
                    else
                    {
						MessageBox.Show("Lỗi không thể đặt lại mật khẩu thành công!");

					}
				}
            }
            else
            {
                txbUsername.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
                txbTenHienThi.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
                cbLoaiTaiKhoan.SelectedIndex = listAccount[e.RowIndex].Type;
            }
        }

		private void txbTimKiem_TextChanged(object sender, EventArgs e)
		{
            string keyword = txbTimKiem.Text;
            LoadTimKiemTaiKhoan(keyword);
		}

		private void btnCapNhap_Click(object sender, EventArgs e)
		{
			if (CheckEmptyForm() != "")
			{
				MessageBox.Show(CheckEmptyForm(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				UpdateAccount();
				LoadData();
				ClearForm();
			}
		}
	}
}
