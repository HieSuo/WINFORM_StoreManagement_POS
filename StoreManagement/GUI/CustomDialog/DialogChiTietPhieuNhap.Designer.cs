namespace StoreManagement.GUI.CustomDialog
{
    partial class DialogChiTietPhieuNhap
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
            this.noticeHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseDialog = new FontAwesome.Sharp.IconButton();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbNgayTao = new System.Windows.Forms.Label();
            this.lbNguoiTao = new System.Windows.Forms.Label();
            this.lbMaPhieuNhap = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbTongTien = new System.Windows.Forms.Label();
            this.noticeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
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
            this.noticeHeader.TabIndex = 3;
            this.noticeHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết phiếu nhập";
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
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.sanPham,
            this.soLuong,
            this.giaNhap});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(2, 122);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(506, 453);
            this.dgvPhieuNhap.TabIndex = 4;
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
            // giaNhap
            // 
            this.giaNhap.HeaderText = "Giá nhập";
            this.giaNhap.Name = "giaNhap";
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhaCungCap.Location = new System.Drawing.Point(2, 75);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(105, 19);
            this.lbNhaCungCap.TabIndex = 5;
            this.lbNhaCungCap.Text = "Nhà cung cấp: ";
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayTao.Location = new System.Drawing.Point(3, 56);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(75, 19);
            this.lbNgayTao.TabIndex = 5;
            this.lbNgayTao.Text = "Ngày tạo: ";
            // 
            // lbNguoiTao
            // 
            this.lbNguoiTao.AutoSize = true;
            this.lbNguoiTao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNguoiTao.Location = new System.Drawing.Point(1, 95);
            this.lbNguoiTao.Name = "lbNguoiTao";
            this.lbNguoiTao.Size = new System.Drawing.Size(83, 19);
            this.lbNguoiTao.TabIndex = 5;
            this.lbNguoiTao.Text = "Người tạo: ";
            // 
            // lbMaPhieuNhap
            // 
            this.lbMaPhieuNhap.AutoSize = true;
            this.lbMaPhieuNhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhieuNhap.Location = new System.Drawing.Point(4, 37);
            this.lbMaPhieuNhap.Name = "lbMaPhieuNhap";
            this.lbMaPhieuNhap.Size = new System.Drawing.Size(114, 19);
            this.lbMaPhieuNhap.TabIndex = 5;
            this.lbMaPhieuNhap.Text = "Mã phiếu nhập: ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.Location = new System.Drawing.Point(96, 578);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(412, 30);
            this.lbTongTien.TabIndex = 6;
            this.lbTongTien.Text = "Tổng tiền:";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DialogChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(512, 648);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbMaPhieuNhap);
            this.Controls.Add(this.lbNgayTao);
            this.Controls.Add(this.lbNguoiTao);
            this.Controls.Add(this.lbNhaCungCap);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.noticeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogChiTietPhieuNhap";
            this.noticeHeader.ResumeLayout(false);
            this.noticeHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel noticeHeader;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseDialog;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.Label lbNguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhap;
        private System.Windows.Forms.Label lbMaPhieuNhap;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbTongTien;
    }
}