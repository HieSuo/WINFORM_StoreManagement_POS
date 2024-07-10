namespace StoreManagement.GUI
{
    partial class FormHoaDon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbKhachHang = new System.Windows.Forms.Label();
			this.lbNguoiTao = new System.Windows.Forms.Label();
			this.lbNgayTao = new System.Windows.Forms.Label();
			this.lbTTCuaHang = new System.Windows.Forms.Label();
			this.lbTenCuaHang = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDSSP = new System.Windows.Forms.DataGridView();
			this.sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnHuy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.btnThanhToan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.lbThanhTien = new System.Windows.Forms.Label();
			this.lbGiamGia = new System.Windows.Forms.Label();
			this.lbTongTien = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbKhachHang);
			this.panel1.Controls.Add(this.lbNguoiTao);
			this.panel1.Controls.Add(this.lbNgayTao);
			this.panel1.Controls.Add(this.lbTTCuaHang);
			this.panel1.Controls.Add(this.lbTenCuaHang);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(412, 159);
			this.panel1.TabIndex = 0;
			// 
			// lbKhachHang
			// 
			this.lbKhachHang.AutoSize = true;
			this.lbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbKhachHang.Location = new System.Drawing.Point(0, 131);
			this.lbKhachHang.Name = "lbKhachHang";
			this.lbKhachHang.Size = new System.Drawing.Size(227, 20);
			this.lbKhachHang.TabIndex = 11;
			this.lbKhachHang.Text = "Khách hàng: 01-Nguyễn Văn A";
			// 
			// lbNguoiTao
			// 
			this.lbNguoiTao.AutoSize = true;
			this.lbNguoiTao.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbNguoiTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbNguoiTao.Location = new System.Drawing.Point(0, 111);
			this.lbNguoiTao.Name = "lbNguoiTao";
			this.lbNguoiTao.Size = new System.Drawing.Size(202, 20);
			this.lbNguoiTao.TabIndex = 10;
			this.lbNguoiTao.Text = "Người tạo: Thân Mạnh Hiếu";
			// 
			// lbNgayTao
			// 
			this.lbNgayTao.AutoSize = true;
			this.lbNgayTao.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbNgayTao.Location = new System.Drawing.Point(0, 91);
			this.lbNgayTao.Name = "lbNgayTao";
			this.lbNgayTao.Size = new System.Drawing.Size(160, 20);
			this.lbNgayTao.TabIndex = 9;
			this.lbNgayTao.Text = "Ngày tạo: 08/04/2024";
			// 
			// lbTTCuaHang
			// 
			this.lbTTCuaHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTTCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTTCuaHang.Location = new System.Drawing.Point(0, 71);
			this.lbTTCuaHang.Name = "lbTTCuaHang";
			this.lbTTCuaHang.Size = new System.Drawing.Size(412, 20);
			this.lbTTCuaHang.TabIndex = 8;
			this.lbTTCuaHang.Text = "0123456789-46 Xuân Phương Nam Từ Liêm Hà Nội";
			this.lbTTCuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTenCuaHang
			// 
			this.lbTenCuaHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTenCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTenCuaHang.Location = new System.Drawing.Point(0, 31);
			this.lbTenCuaHang.Name = "lbTenCuaHang";
			this.lbTenCuaHang.Size = new System.Drawing.Size(412, 40);
			this.lbTenCuaHang.TabIndex = 4;
			this.lbTenCuaHang.Text = "Cửa hàng hêhhehe";
			this.lbTenCuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(412, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hóa đơn thanh toán";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvDSSP
			// 
			this.dgvDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanPham,
            this.soLuong,
            this.donGia});
			this.dgvDSSP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDSSP.Location = new System.Drawing.Point(0, 159);
			this.dgvDSSP.Name = "dgvDSSP";
			this.dgvDSSP.Size = new System.Drawing.Size(412, 499);
			this.dgvDSSP.TabIndex = 1;
			// 
			// sanPham
			// 
			this.sanPham.HeaderText = "Tên sản phẩm";
			this.sanPham.Name = "sanPham";
			// 
			// soLuong
			// 
			this.soLuong.HeaderText = "Số lượng";
			this.soLuong.Name = "soLuong";
			// 
			// donGia
			// 
			this.donGia.HeaderText = "Đơn giá";
			this.donGia.Name = "donGia";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnHuy);
			this.panel2.Controls.Add(this.btnThanhToan);
			this.panel2.Controls.Add(this.lbThanhTien);
			this.panel2.Controls.Add(this.lbGiamGia);
			this.panel2.Controls.Add(this.lbTongTien);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 505);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(412, 153);
			this.panel2.TabIndex = 2;
			// 
			// btnHuy
			// 
			this.btnHuy.AllowAnimations = true;
			this.btnHuy.AllowMouseEffects = true;
			this.btnHuy.AllowToggling = false;
			this.btnHuy.AnimationSpeed = 200;
			this.btnHuy.AutoGenerateColors = false;
			this.btnHuy.AutoRoundBorders = false;
			this.btnHuy.AutoSizeLeftIcon = true;
			this.btnHuy.AutoSizeRightIcon = true;
			this.btnHuy.BackColor = System.Drawing.Color.Transparent;
			this.btnHuy.BackColor1 = System.Drawing.Color.Red;
			this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
			this.btnHuy.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnHuy.ButtonText = "Hủy";
			this.btnHuy.ButtonTextMarginLeft = 0;
			this.btnHuy.ColorContrastOnClick = 45;
			this.btnHuy.ColorContrastOnHover = 45;
			this.btnHuy.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.btnHuy.CustomizableEdges = borderEdges1;
			this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnHuy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnHuy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnHuy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnHuy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnHuy.ForeColor = System.Drawing.Color.Black;
			this.btnHuy.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHuy.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnHuy.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnHuy.IconMarginLeft = 11;
			this.btnHuy.IconPadding = 10;
			this.btnHuy.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnHuy.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnHuy.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnHuy.IconSize = 25;
			this.btnHuy.IdleBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.btnHuy.IdleBorderRadius = 30;
			this.btnHuy.IdleBorderThickness = 1;
			this.btnHuy.IdleFillColor = System.Drawing.Color.Red;
			this.btnHuy.IdleIconLeftImage = null;
			this.btnHuy.IdleIconRightImage = null;
			this.btnHuy.IndicateFocus = false;
			this.btnHuy.Location = new System.Drawing.Point(117, 111);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnHuy.OnDisabledState.BorderRadius = 30;
			this.btnHuy.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnHuy.OnDisabledState.BorderThickness = 1;
			this.btnHuy.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnHuy.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnHuy.OnDisabledState.IconLeftImage = null;
			this.btnHuy.OnDisabledState.IconRightImage = null;
			this.btnHuy.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnHuy.onHoverState.BorderRadius = 30;
			this.btnHuy.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnHuy.onHoverState.BorderThickness = 1;
			this.btnHuy.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnHuy.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnHuy.onHoverState.IconLeftImage = null;
			this.btnHuy.onHoverState.IconRightImage = null;
			this.btnHuy.OnIdleState.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.btnHuy.OnIdleState.BorderRadius = 30;
			this.btnHuy.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnHuy.OnIdleState.BorderThickness = 1;
			this.btnHuy.OnIdleState.FillColor = System.Drawing.Color.Red;
			this.btnHuy.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.btnHuy.OnIdleState.IconLeftImage = null;
			this.btnHuy.OnIdleState.IconRightImage = null;
			this.btnHuy.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnHuy.OnPressedState.BorderRadius = 30;
			this.btnHuy.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnHuy.OnPressedState.BorderThickness = 1;
			this.btnHuy.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnHuy.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnHuy.OnPressedState.IconLeftImage = null;
			this.btnHuy.OnPressedState.IconRightImage = null;
			this.btnHuy.Size = new System.Drawing.Size(70, 39);
			this.btnHuy.TabIndex = 3;
			this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnHuy.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnHuy.TextMarginLeft = 0;
			this.btnHuy.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnHuy.UseDefaultRadiusAndThickness = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.AllowAnimations = true;
			this.btnThanhToan.AllowMouseEffects = true;
			this.btnThanhToan.AllowToggling = false;
			this.btnThanhToan.AnimationSpeed = 200;
			this.btnThanhToan.AutoGenerateColors = false;
			this.btnThanhToan.AutoRoundBorders = false;
			this.btnThanhToan.AutoSizeLeftIcon = true;
			this.btnThanhToan.AutoSizeRightIcon = true;
			this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
			this.btnThanhToan.BackColor1 = System.Drawing.Color.Lime;
			this.btnThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.BackgroundImage")));
			this.btnThanhToan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.ButtonText = "Thanh Toán";
			this.btnThanhToan.ButtonTextMarginLeft = 0;
			this.btnThanhToan.ColorContrastOnClick = 45;
			this.btnThanhToan.ColorContrastOnHover = 45;
			this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges2.BottomLeft = true;
			borderEdges2.BottomRight = true;
			borderEdges2.TopLeft = true;
			borderEdges2.TopRight = true;
			this.btnThanhToan.CustomizableEdges = borderEdges2;
			this.btnThanhToan.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnThanhToan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThanhToan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThanhToan.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThanhToan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
			this.btnThanhToan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThanhToan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnThanhToan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnThanhToan.IconMarginLeft = 11;
			this.btnThanhToan.IconPadding = 10;
			this.btnThanhToan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThanhToan.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnThanhToan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnThanhToan.IconSize = 25;
			this.btnThanhToan.IdleBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.btnThanhToan.IdleBorderRadius = 30;
			this.btnThanhToan.IdleBorderThickness = 1;
			this.btnThanhToan.IdleFillColor = System.Drawing.Color.Lime;
			this.btnThanhToan.IdleIconLeftImage = null;
			this.btnThanhToan.IdleIconRightImage = null;
			this.btnThanhToan.IndicateFocus = false;
			this.btnThanhToan.Location = new System.Drawing.Point(205, 111);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThanhToan.OnDisabledState.BorderRadius = 30;
			this.btnThanhToan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.OnDisabledState.BorderThickness = 1;
			this.btnThanhToan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThanhToan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThanhToan.OnDisabledState.IconLeftImage = null;
			this.btnThanhToan.OnDisabledState.IconRightImage = null;
			this.btnThanhToan.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThanhToan.onHoverState.BorderRadius = 30;
			this.btnThanhToan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.onHoverState.BorderThickness = 1;
			this.btnThanhToan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThanhToan.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.onHoverState.IconLeftImage = null;
			this.btnThanhToan.onHoverState.IconRightImage = null;
			this.btnThanhToan.OnIdleState.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.btnThanhToan.OnIdleState.BorderRadius = 30;
			this.btnThanhToan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.OnIdleState.BorderThickness = 1;
			this.btnThanhToan.OnIdleState.FillColor = System.Drawing.Color.Lime;
			this.btnThanhToan.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.btnThanhToan.OnIdleState.IconLeftImage = null;
			this.btnThanhToan.OnIdleState.IconRightImage = null;
			this.btnThanhToan.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThanhToan.OnPressedState.BorderRadius = 30;
			this.btnThanhToan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.OnPressedState.BorderThickness = 1;
			this.btnThanhToan.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThanhToan.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.OnPressedState.IconLeftImage = null;
			this.btnThanhToan.OnPressedState.IconRightImage = null;
			this.btnThanhToan.Size = new System.Drawing.Size(109, 39);
			this.btnThanhToan.TabIndex = 3;
			this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnThanhToan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnThanhToan.TextMarginLeft = 0;
			this.btnThanhToan.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnThanhToan.UseDefaultRadiusAndThickness = true;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// lbThanhTien
			// 
			this.lbThanhTien.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThanhTien.Location = new System.Drawing.Point(0, 60);
			this.lbThanhTien.Name = "lbThanhTien";
			this.lbThanhTien.Size = new System.Drawing.Size(412, 30);
			this.lbThanhTien.TabIndex = 2;
			this.lbThanhTien.Text = "Thành tiền: 198.000 VND";
			this.lbThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbGiamGia
			// 
			this.lbGiamGia.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbGiamGia.Location = new System.Drawing.Point(0, 30);
			this.lbGiamGia.Name = "lbGiamGia";
			this.lbGiamGia.Size = new System.Drawing.Size(412, 30);
			this.lbGiamGia.TabIndex = 1;
			this.lbGiamGia.Text = "Giảm giá thành viên: 0.5%";
			this.lbGiamGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbTongTien
			// 
			this.lbTongTien.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTongTien.Location = new System.Drawing.Point(0, 0);
			this.lbTongTien.Name = "lbTongTien";
			this.lbTongTien.Size = new System.Drawing.Size(412, 30);
			this.lbTongTien.TabIndex = 0;
			this.lbTongTien.Text = "Tổng tiền: 200.000 VND";
			this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(412, 658);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dgvDSSP);
			this.Controls.Add(this.panel1);
			this.Name = "FormHoaDon";
			this.Text = "Hóa đơn thanh toán";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Label lbTenCuaHang;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbNguoiTao;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.Label lbTTCuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.Label lbThanhTien;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHuy;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThanhToan;
    }
}