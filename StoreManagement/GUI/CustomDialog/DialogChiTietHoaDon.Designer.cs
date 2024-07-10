namespace StoreManagement.GUI.CustomDialog
{
    partial class DialogChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseDialog = new FontAwesome.Sharp.IconButton();
            this.noticeHeader = new System.Windows.Forms.Panel();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbNgayTao = new System.Windows.Forms.Label();
            this.lbNguoiTao = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.noticeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // btnCloseDialog
            // 
            this.btnCloseDialog.BackColor = System.Drawing.Color.White;
            this.btnCloseDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseDialog.FlatAppearance.BorderSize = 0;
            this.btnCloseDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDialog.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnCloseDialog.IconColor = System.Drawing.Color.Black;
            this.btnCloseDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseDialog.IconSize = 30;
            this.btnCloseDialog.Location = new System.Drawing.Point(470, 0);
            this.btnCloseDialog.Margin = new System.Windows.Forms.Padding(20);
            this.btnCloseDialog.Name = "btnCloseDialog";
            this.btnCloseDialog.Size = new System.Drawing.Size(42, 32);
            this.btnCloseDialog.TabIndex = 1;
            this.btnCloseDialog.UseVisualStyleBackColor = false;
            this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
            // 
            // noticeHeader
            // 
            this.noticeHeader.BackColor = System.Drawing.Color.White;
            this.noticeHeader.Controls.Add(this.label1);
            this.noticeHeader.Controls.Add(this.btnCloseDialog);
            this.noticeHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.noticeHeader.Location = new System.Drawing.Point(0, 0);
            this.noticeHeader.Name = "noticeHeader";
            this.noticeHeader.Size = new System.Drawing.Size(512, 32);
            this.noticeHeader.TabIndex = 4;
            this.noticeHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaHoaDon.Location = new System.Drawing.Point(2, 35);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(96, 19);
            this.lbMaHoaDon.TabIndex = 6;
            this.lbMaHoaDon.Text = "Mã hóa đơn: ";
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayTao.Location = new System.Drawing.Point(1, 54);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(75, 19);
            this.lbNgayTao.TabIndex = 7;
            this.lbNgayTao.Text = "Ngày tạo: ";
            // 
            // lbNguoiTao
            // 
            this.lbNguoiTao.AutoSize = true;
            this.lbNguoiTao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNguoiTao.Location = new System.Drawing.Point(-1, 93);
            this.lbNguoiTao.Name = "lbNguoiTao";
            this.lbNguoiTao.Size = new System.Drawing.Size(83, 19);
            this.lbNguoiTao.TabIndex = 8;
            this.lbNguoiTao.Text = "Người tạo: ";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKhachHang.Location = new System.Drawing.Point(0, 73);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(105, 19);
            this.lbKhachHang.TabIndex = 9;
            this.lbKhachHang.Text = "Nhà cung cấp: ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.Location = new System.Drawing.Point(100, 539);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(412, 30);
            this.lbTongTien.TabIndex = 11;
            this.lbTongTien.Text = "Tổng tiền: ";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.sanPham,
            this.soLuong,
            this.giaBan});
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 119);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(506, 417);
            this.dgvHoaDon.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // sanPham
            // 
            this.sanPham.HeaderText = "Tên sản phẩm";
            this.sanPham.Name = "sanPham";
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            // 
            // giaBan
            // 
            this.giaBan.HeaderText = "Giá bán";
            this.giaBan.Name = "giaBan";
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiamGia.Location = new System.Drawing.Point(100, 569);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(412, 30);
            this.lbGiamGia.TabIndex = 11;
            this.lbGiamGia.Text = "Giảm giá: ";
            this.lbGiamGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThanhTien.Location = new System.Drawing.Point(100, 599);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(412, 30);
            this.lbThanhTien.TabIndex = 11;
            this.lbThanhTien.Text = "Thành tiền: ";
            this.lbThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DialogChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 648);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbGiamGia);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.lbMaHoaDon);
            this.Controls.Add(this.lbNgayTao);
            this.Controls.Add(this.lbNguoiTao);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.noticeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogChiTietHoaDon";
            this.noticeHeader.ResumeLayout(false);
            this.noticeHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel noticeHeader;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseDialog;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.Label lbNguoiTao;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label lbGiamGia;
    }
}