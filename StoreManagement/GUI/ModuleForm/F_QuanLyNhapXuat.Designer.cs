namespace StoreManagement.GUI.ModuleForm
{
    partial class F_QuanLyNhapXuat
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
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.btnDSHoaDon = new FontAwesome.Sharp.IconButton();
            this.panelChildContent = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panelheader.Controls.Add(this.btnNhapHang);
            this.panelheader.Controls.Add(this.btnDSHoaDon);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1092, 40);
            this.panelheader.TabIndex = 2;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.AutoSize = true;
            this.btnNhapHang.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnNhapHang.IconColor = System.Drawing.Color.Black;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.IconSize = 35;
            this.btnNhapHang.Location = new System.Drawing.Point(131, 0);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(163, 40);
            this.btnNhapHang.TabIndex = 3;
            this.btnNhapHang.Text = "DS Nhập hàng";
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnDSHoaDon
            // 
            this.btnDSHoaDon.AutoSize = true;
            this.btnDSHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnDSHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSHoaDon.FlatAppearance.BorderSize = 0;
            this.btnDSHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSHoaDon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDSHoaDon.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnDSHoaDon.IconColor = System.Drawing.Color.Black;
            this.btnDSHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDSHoaDon.IconSize = 35;
            this.btnDSHoaDon.Location = new System.Drawing.Point(0, 0);
            this.btnDSHoaDon.Name = "btnDSHoaDon";
            this.btnDSHoaDon.Size = new System.Drawing.Size(131, 40);
            this.btnDSHoaDon.TabIndex = 2;
            this.btnDSHoaDon.Text = "DS Hóa đơn";
            this.btnDSHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSHoaDon.UseVisualStyleBackColor = false;
            this.btnDSHoaDon.Click += new System.EventHandler(this.btnDSHoaDon_Click);
            // 
            // panelChildContent
            // 
            this.panelChildContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildContent.Location = new System.Drawing.Point(0, 40);
            this.panelChildContent.Name = "panelChildContent";
            this.panelChildContent.Size = new System.Drawing.Size(1092, 700);
            this.panelChildContent.TabIndex = 3;
            // 
            // F_QuanLyNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 740);
            this.Controls.Add(this.panelChildContent);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_QuanLyNhapXuat";
            this.Text = "F_QuanLyNhapXuat";
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private FontAwesome.Sharp.IconButton btnDSHoaDon;
        private System.Windows.Forms.Panel panelChildContent;
    }
}