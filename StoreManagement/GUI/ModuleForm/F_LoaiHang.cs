using StoreManagement.DAO;
using StoreManagement.GUI.CustomDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.GUI.ModuleForm
{
    public partial class F_LoaiHang : Form
    {
        public F_LoaiHang()
        {
            InitializeComponent();
            LoadData();
        }
        
        public void LoadData()
        {
            dgvLoaiSanPham.DataSource = LoaiSanPhamDAO.Instance.GetAllLoaiSanPham();
        }
		public void LoadTimKiemLoaiSanPham(string keyword)
		{
			dgvLoaiSanPham.DataSource = LoaiSanPhamDAO.Instance.GetLoaiSanPhamByKeyword(keyword);
		}
		#region Method
		public void AddLoaiSanPham()
        {
            string id = txbMaLoai.Text;
            string tenLoai = txbTenLoai.Text;
            if(LoaiSanPhamDAO.Instance.InsertLoaiSanPham(id, tenLoai))
            {
                LoadData();
                txbMaLoai.Clear();
                txbTenLoai.Clear();
            }
            else
            {
                NoticeDialog.Show(new NoticeDialog("Lỗi thêm mới", "Kiểm tra lại thông tin loại sản phẩm"));
            }
        }
        #endregion

        #region event element
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            AddLoaiSanPham();
        }

        private void dgvLoaiSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiSanPham.Columns[e.ColumnIndex].Name == "update")
            {
                string id = dgvLoaiSanPham.CurrentRow.Cells[2].Value.ToString();
                string tenLoai = dgvLoaiSanPham.CurrentRow.Cells[3].Value.ToString();

                if (MessageBox.Show("Sửa "+e.RowIndex+e.ColumnIndex+id+tenLoai+" này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if(LoaiSanPhamDAO.Instance.UpdateLoaiSanPham(id, tenLoai))
                    {
                        LoadData();
                    }
                }
            }
            else if (dgvLoaiSanPham.Columns[e.ColumnIndex].Name == "delete")
            {
                string id = dgvLoaiSanPham.CurrentRow.Cells[2].Value.ToString();
                if(MessageBox.Show("Xoá loại sản phẩm này?"+id, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    LoaiSanPhamDAO.Instance.DeleteLoaiSanPham(id);
                    LoadData();
                }
            }
            else
            {
                string id = dgvLoaiSanPham.CurrentRow.Cells[2].Value.ToString();
                string tenLoai = dgvLoaiSanPham.CurrentRow.Cells[3].Value.ToString();
               
            }
        }



		private void btnTimkiem_Click(object sender, EventArgs e)
		{
            string keyword = txbTimKiem.Text;
            LoadTimKiemLoaiSanPham(keyword);
		}
		#endregion

		private void txbTimKiem_TextChanged(object sender, EventArgs e)
		{
			string keyword = txbTimKiem.Text;
			LoadTimKiemLoaiSanPham(keyword);
		}
	}
}
