namespace StoreManagement.GUI
{
    partial class HomePage
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
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnQLLoaiHang = new FontAwesome.Sharp.IconButton();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.btniconPerson = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyHangHoa = new FontAwesome.Sharp.IconButton();
            this.btnBanHang = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelNavbar.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panelNavbar.Controls.Add(this.btnQLLoaiHang);
            this.panelNavbar.Controls.Add(this.panelPersonal);
            this.panelNavbar.Controls.Add(this.btnQuanLyTaiKhoan);
            this.panelNavbar.Controls.Add(this.btnNhaCungCap);
            this.panelNavbar.Controls.Add(this.btnKhachHang);
            this.panelNavbar.Controls.Add(this.btnHoaDon);
            this.panelNavbar.Controls.Add(this.btnNhapHang);
            this.panelNavbar.Controls.Add(this.btnQuanLyHangHoa);
            this.panelNavbar.Controls.Add(this.btnBanHang);
            this.panelNavbar.Controls.Add(this.btnTrangChu);
            this.panelNavbar.Controls.Add(this.panel1);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(188, 740);
            this.panelNavbar.TabIndex = 0;
            // 
            // btnQLLoaiHang
            // 
            this.btnQLLoaiHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLLoaiHang.FlatAppearance.BorderSize = 0;
            this.btnQLLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLLoaiHang.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLLoaiHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQLLoaiHang.IconColor = System.Drawing.Color.Black;
            this.btnQLLoaiHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLLoaiHang.Location = new System.Drawing.Point(0, 440);
            this.btnQLLoaiHang.Name = "btnQLLoaiHang";
            this.btnQLLoaiHang.Size = new System.Drawing.Size(188, 40);
            this.btnQLLoaiHang.TabIndex = 10;
            this.btnQLLoaiHang.Text = "Quản lý loại hàng";
            this.btnQLLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLoaiHang.UseVisualStyleBackColor = true;
            this.btnQLLoaiHang.Click += new System.EventHandler(this.btnQLLoaiHang_Click);
            // 
            // panelPersonal
            // 
            this.panelPersonal.Controls.Add(this.btnLogOut);
            this.panelPersonal.Controls.Add(this.lbDisplayName);
            this.panelPersonal.Controls.Add(this.btniconPerson);
            this.panelPersonal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPersonal.Location = new System.Drawing.Point(0, 598);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(188, 142);
            this.panelPersonal.TabIndex = 9;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.Location = new System.Drawing.Point(56, 103);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 19);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDisplayName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDisplayName.Location = new System.Drawing.Point(0, 80);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(188, 23);
            this.lbDisplayName.TabIndex = 1;
            this.lbDisplayName.Text = "Thân Mạnh Hiếu";
            this.lbDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btniconPerson
            // 
            this.btniconPerson.FlatAppearance.BorderSize = 0;
            this.btniconPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniconPerson.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btniconPerson.IconColor = System.Drawing.Color.Black;
            this.btniconPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btniconPerson.IconSize = 70;
            this.btniconPerson.Location = new System.Drawing.Point(56, 19);
            this.btniconPerson.Name = "btniconPerson";
            this.btniconPerson.Size = new System.Drawing.Size(75, 66);
            this.btniconPerson.TabIndex = 0;
            this.btniconPerson.UseVisualStyleBackColor = true;
            this.btniconPerson.Click += new System.EventHandler(this.btniconPerson_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQuanLyTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.btnQuanLyTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 400);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(188, 40);
            this.btnQuanLyTaiKhoan.TabIndex = 8;
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNhaCungCap.IconColor = System.Drawing.Color.Black;
            this.btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhaCungCap.Location = new System.Drawing.Point(0, 360);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(188, 40);
            this.btnNhaCungCap.TabIndex = 7;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnKhachHang.IconColor = System.Drawing.Color.Black;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 320);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(188, 40);
            this.btnKhachHang.TabIndex = 6;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHoaDon.IconColor = System.Drawing.Color.Black;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 280);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(188, 40);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Lịch sử Nhập-Xuất";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNhapHang.IconColor = System.Drawing.Color.Black;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 240);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(188, 40);
            this.btnNhapHang.TabIndex = 4;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnQuanLyHangHoa
            // 
            this.btnQuanLyHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyHangHoa.FlatAppearance.BorderSize = 0;
            this.btnQuanLyHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHangHoa.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyHangHoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQuanLyHangHoa.IconColor = System.Drawing.Color.Black;
            this.btnQuanLyHangHoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyHangHoa.Location = new System.Drawing.Point(0, 200);
            this.btnQuanLyHangHoa.Name = "btnQuanLyHangHoa";
            this.btnQuanLyHangHoa.Size = new System.Drawing.Size(188, 40);
            this.btnQuanLyHangHoa.TabIndex = 3;
            this.btnQuanLyHangHoa.Text = "Quản lý hàng hóa";
            this.btnQuanLyHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHangHoa.UseVisualStyleBackColor = true;
            this.btnQuanLyHangHoa.Click += new System.EventHandler(this.btnQuanLyHangHoa_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBanHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBanHang.IconColor = System.Drawing.Color.Black;
            this.btnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBanHang.Location = new System.Drawing.Point(0, 160);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(188, 40);
            this.btnBanHang.TabIndex = 2;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTrangChu.IconColor = System.Drawing.Color.Black;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 120);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(188, 40);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 120);
            this.panel1.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(188, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1092, 740);
            this.panelChildForm.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panelNavbar.ResumeLayout(false);
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private FontAwesome.Sharp.IconButton btnQuanLyTaiKhoan;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private FontAwesome.Sharp.IconButton btnQuanLyHangHoa;
        private FontAwesome.Sharp.IconButton btnBanHang;
        private System.Windows.Forms.Panel panelPersonal;
        private FontAwesome.Sharp.IconButton btniconPerson;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Label btnLogOut;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnQLLoaiHang;
    }
}