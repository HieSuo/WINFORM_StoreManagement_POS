namespace StoreManagement.GUI.ModuleForm
{
    partial class ViewSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSanPham));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.txbTenSP = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.BackColor = System.Drawing.Color.White;
            this.lbGiaBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaBan.Location = new System.Drawing.Point(0, 157);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(100, 27);
            this.lbGiaBan.TabIndex = 7;
            this.lbGiaBan.Text = "139.000";
            this.lbGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaSP
            // 
            this.lbMaSP.BackColor = System.Drawing.Color.White;
            this.lbMaSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMaSP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSP.Location = new System.Drawing.Point(0, 90);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(100, 13);
            this.lbMaSP.TabIndex = 5;
            this.lbMaSP.Text = "122666888";
            this.lbMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSanPham
            // 
            this.picSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.picSanPham.Image = ((System.Drawing.Image)(resources.GetObject("picSanPham.Image")));
            this.picSanPham.Location = new System.Drawing.Point(0, 0);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(100, 90);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 4;
            this.picSanPham.TabStop = false;
            // 
            // txbTenSP
            // 
            this.txbTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTenSP.BackColor = System.Drawing.Color.White;
            this.txbTenSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenSP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenSP.Location = new System.Drawing.Point(0, 119);
            this.txbTenSP.Multiline = true;
            this.txbTenSP.Name = "txbTenSP";
            this.txbTenSP.ReadOnly = true;
            this.txbTenSP.Size = new System.Drawing.Size(100, 35);
            this.txbTenSP.TabIndex = 6;
            this.txbTenSP.Text = "Bột giặt omo hương nắng mai";
            this.txbTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.BackColor = System.Drawing.Color.White;
            this.lbSoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSoLuong.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLuong.Location = new System.Drawing.Point(0, 103);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(100, 13);
            this.lbSoLuong.TabIndex = 8;
            this.lbSoLuong.Text = "SL:1";
            this.lbSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbGiaBan);
            this.Controls.Add(this.txbTenSP);
            this.Controls.Add(this.lbMaSP);
            this.Controls.Add(this.picSanPham);
            this.Name = "ViewSanPham";
            this.Size = new System.Drawing.Size(100, 184);
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.TextBox txbTenSP;
        private System.Windows.Forms.Label lbSoLuong;
    }
}
