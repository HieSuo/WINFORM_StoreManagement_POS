namespace StoreManagement.GUI.ModuleForm
{
    partial class F_KhachHang
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnHangThanhVien = new FontAwesome.Sharp.IconButton();
            this.btnDSKH = new FontAwesome.Sharp.IconButton();
            this.panelConTentCSKH = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panelheader.Controls.Add(this.btnHangThanhVien);
            this.panelheader.Controls.Add(this.btnDSKH);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1092, 40);
            this.panelheader.TabIndex = 3;
            // 
            // btnHangThanhVien
            // 
            this.btnHangThanhVien.AutoSize = true;
            this.btnHangThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.btnHangThanhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHangThanhVien.FlatAppearance.BorderSize = 0;
            this.btnHangThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangThanhVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHangThanhVien.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            this.btnHangThanhVien.IconColor = System.Drawing.Color.Black;
            this.btnHangThanhVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHangThanhVien.IconSize = 35;
            this.btnHangThanhVien.Location = new System.Drawing.Point(200, 0);
            this.btnHangThanhVien.Name = "btnHangThanhVien";
            this.btnHangThanhVien.Size = new System.Drawing.Size(163, 40);
            this.btnHangThanhVien.TabIndex = 1;
            this.btnHangThanhVien.Text = "Hạng thành viên";
            this.btnHangThanhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHangThanhVien.UseVisualStyleBackColor = false;
            this.btnHangThanhVien.Click += new System.EventHandler(this.btnHangThanhVien_Click);
            // 
            // btnDSKH
            // 
            this.btnDSKH.AutoSize = true;
            this.btnDSKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSKH.BackColor = System.Drawing.Color.Transparent;
            this.btnDSKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSKH.FlatAppearance.BorderSize = 0;
            this.btnDSKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDSKH.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnDSKH.IconColor = System.Drawing.Color.Black;
            this.btnDSKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDSKH.IconSize = 35;
            this.btnDSKH.Location = new System.Drawing.Point(0, 0);
            this.btnDSKH.Name = "btnDSKH";
            this.btnDSKH.Size = new System.Drawing.Size(200, 40);
            this.btnDSKH.TabIndex = 0;
            this.btnDSKH.Text = "Danh sách khách hàng";
            this.btnDSKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSKH.UseVisualStyleBackColor = false;
            this.btnDSKH.Click += new System.EventHandler(this.btnDSKH_Click);
            // 
            // panelConTentCSKH
            // 
            this.panelConTentCSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConTentCSKH.Location = new System.Drawing.Point(0, 40);
            this.panelConTentCSKH.Name = "panelConTentCSKH";
            this.panelConTentCSKH.Size = new System.Drawing.Size(1092, 700);
            this.panelConTentCSKH.TabIndex = 4;
            // 
            // F_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 740);
            this.Controls.Add(this.panelConTentCSKH);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_KhachHang";
            this.Text = "F_KhachHang";
            this.Load += new System.EventHandler(this.F_KhachHang_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelConTentCSKH;
        private FontAwesome.Sharp.IconButton btnDSKH;
        private FontAwesome.Sharp.IconButton btnHangThanhVien;
    }
}