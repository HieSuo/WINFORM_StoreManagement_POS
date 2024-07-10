namespace StoreManagement.GUI.ModuleForm
{
    partial class F_QuanLyHangHoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_QuanLyHangHoa));
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelheader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txbTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
			this.dgvSanPham = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anh = new System.Windows.Forms.DataGridViewImageColumn();
			this.mavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.update = new System.Windows.Forms.DataGridViewButtonColumn();
			this.del = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnTimKiem = new FontAwesome.Sharp.IconButton();
			this.cbLoaiSanPham = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbTrangThai = new Bunifu.UI.WinForms.BunifuDropdown();
			this.btnExport = new FontAwesome.Sharp.IconButton();
			this.panelheader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// panelheader
			// 
			this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.panelheader.Controls.Add(this.label1);
			this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelheader.Location = new System.Drawing.Point(0, 0);
			this.panelheader.Name = "panelheader";
			this.panelheader.Size = new System.Drawing.Size(1092, 40);
			this.panelheader.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lý hàng hóa";
			// 
			// txbTimKiem
			// 
			this.txbTimKiem.AcceptsReturn = false;
			this.txbTimKiem.AcceptsTab = false;
			this.txbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txbTimKiem.AnimationSpeed = 200;
			this.txbTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbTimKiem.BackColor = System.Drawing.Color.Transparent;
			this.txbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbTimKiem.BackgroundImage")));
			this.txbTimKiem.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbTimKiem.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbTimKiem.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbTimKiem.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbTimKiem.BorderRadius = 35;
			this.txbTimKiem.BorderThickness = 1;
			this.txbTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTimKiem.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.txbTimKiem.DefaultText = "";
			this.txbTimKiem.FillColor = System.Drawing.Color.White;
			this.txbTimKiem.HideSelection = true;
			this.txbTimKiem.IconLeft = null;
			this.txbTimKiem.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTimKiem.IconPadding = 10;
			this.txbTimKiem.IconRight = null;
			this.txbTimKiem.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTimKiem.Lines = new string[0];
			this.txbTimKiem.Location = new System.Drawing.Point(757, 94);
			this.txbTimKiem.MaxLength = 32767;
			this.txbTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbTimKiem.Modified = false;
			this.txbTimKiem.Multiline = false;
			this.txbTimKiem.Name = "txbTimKiem";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTimKiem.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbTimKiem.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTimKiem.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTimKiem.OnIdleState = stateProperties4;
			this.txbTimKiem.Padding = new System.Windows.Forms.Padding(3);
			this.txbTimKiem.PasswordChar = '\0';
			this.txbTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbTimKiem.PlaceholderText = "Tìm kiếm";
			this.txbTimKiem.ReadOnly = false;
			this.txbTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbTimKiem.SelectedText = "";
			this.txbTimKiem.SelectionLength = 0;
			this.txbTimKiem.SelectionStart = 0;
			this.txbTimKiem.ShortcutsEnabled = true;
			this.txbTimKiem.Size = new System.Drawing.Size(335, 37);
			this.txbTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbTimKiem.TabIndex = 6;
			this.txbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbTimKiem.TextMarginBottom = 0;
			this.txbTimKiem.TextMarginLeft = 3;
			this.txbTimKiem.TextMarginTop = 0;
			this.txbTimKiem.TextPlaceholder = "Tìm kiếm";
			this.txbTimKiem.UseSystemPasswordChar = false;
			this.txbTimKiem.WordWrap = true;
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.IdLoaiSanPham,
            this.ten,
            this.Column1,
            this.soluong,
            this.anh,
            this.mavach,
            this.trangthai,
            this.update,
            this.del});
			this.dgvSanPham.Location = new System.Drawing.Point(13, 137);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.RowTemplate.Height = 60;
			this.dgvSanPham.Size = new System.Drawing.Size(1067, 591);
			this.dgvSanPham.TabIndex = 10;
			this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
			this.dgvSanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSanPham_CellFormatting);
			// 
			// id
			// 
			this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.id.DataPropertyName = "Id";
			this.id.FillWeight = 94.78796F;
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.Width = 30;
			// 
			// IdLoaiSanPham
			// 
			this.IdLoaiSanPham.DataPropertyName = "IdLoaiSanPham";
			this.IdLoaiSanPham.FillWeight = 100.5015F;
			this.IdLoaiSanPham.HeaderText = "Loại";
			this.IdLoaiSanPham.Name = "IdLoaiSanPham";
			// 
			// ten
			// 
			this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ten.DataPropertyName = "TenSanPham";
			this.ten.FillWeight = 97.84017F;
			this.ten.HeaderText = "Tên sản phẩm";
			this.ten.Name = "ten";
			this.ten.Width = 150;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "GiaBan";
			this.Column1.FillWeight = 100.4587F;
			this.Column1.HeaderText = "Giá bán";
			this.Column1.Name = "Column1";
			// 
			// soluong
			// 
			this.soluong.DataPropertyName = "SoLuongTonKho";
			this.soluong.FillWeight = 99.71434F;
			this.soluong.HeaderText = "Số lượng";
			this.soluong.Name = "soluong";
			// 
			// anh
			// 
			this.anh.DataPropertyName = "AnhSanPham";
			this.anh.FillWeight = 102.8336F;
			this.anh.HeaderText = "Ảnh";
			this.anh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.anh.Name = "anh";
			this.anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// mavach
			// 
			this.mavach.DataPropertyName = "MaSanPham";
			this.mavach.FillWeight = 102.9271F;
			this.mavach.HeaderText = "Mã vạch";
			this.mavach.Name = "mavach";
			// 
			// trangthai
			// 
			this.trangthai.DataPropertyName = "TrangThai";
			this.trangthai.FillWeight = 98.99465F;
			this.trangthai.HeaderText = "TrangThai";
			this.trangthai.Name = "trangthai";
			// 
			// update
			// 
			this.update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.update.FillWeight = 102.3328F;
			this.update.HeaderText = "Update";
			this.update.Name = "update";
			this.update.Text = "Cập nhật";
			this.update.UseColumnTextForButtonValue = true;
			this.update.Width = 80;
			// 
			// del
			// 
			this.del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.del.FillWeight = 99.60938F;
			this.del.HeaderText = "Xóa";
			this.del.Name = "del";
			this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.del.Text = "Xóa";
			this.del.UseColumnTextForButtonValue = true;
			this.del.Width = 80;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTimKiem.BackColor = System.Drawing.Color.White;
			this.btnTimKiem.FlatAppearance.BorderSize = 0;
			this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnTimKiem.IconColor = System.Drawing.Color.Black;
			this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnTimKiem.IconSize = 30;
			this.btnTimKiem.Location = new System.Drawing.Point(1052, 100);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(28, 26);
			this.btnTimKiem.TabIndex = 12;
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// cbLoaiSanPham
			// 
			this.cbLoaiSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbLoaiSanPham.BackColor = System.Drawing.Color.Transparent;
			this.cbLoaiSanPham.BackgroundColor = System.Drawing.Color.White;
			this.cbLoaiSanPham.BorderColor = System.Drawing.Color.Silver;
			this.cbLoaiSanPham.BorderRadius = 17;
			this.cbLoaiSanPham.Color = System.Drawing.Color.Silver;
			this.cbLoaiSanPham.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbLoaiSanPham.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbLoaiSanPham.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.cbLoaiSanPham.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbLoaiSanPham.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.cbLoaiSanPham.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.cbLoaiSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbLoaiSanPham.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLoaiSanPham.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbLoaiSanPham.FillDropDown = true;
			this.cbLoaiSanPham.FillIndicator = false;
			this.cbLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbLoaiSanPham.ForeColor = System.Drawing.Color.Black;
			this.cbLoaiSanPham.FormattingEnabled = true;
			this.cbLoaiSanPham.Icon = null;
			this.cbLoaiSanPham.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbLoaiSanPham.IndicatorColor = System.Drawing.Color.Gray;
			this.cbLoaiSanPham.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbLoaiSanPham.ItemBackColor = System.Drawing.Color.White;
			this.cbLoaiSanPham.ItemBorderColor = System.Drawing.Color.White;
			this.cbLoaiSanPham.ItemForeColor = System.Drawing.Color.Black;
			this.cbLoaiSanPham.ItemHeight = 26;
			this.cbLoaiSanPham.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.cbLoaiSanPham.ItemHighLightForeColor = System.Drawing.Color.White;
			this.cbLoaiSanPham.ItemTopMargin = 3;
			this.cbLoaiSanPham.Location = new System.Drawing.Point(397, 99);
			this.cbLoaiSanPham.Name = "cbLoaiSanPham";
			this.cbLoaiSanPham.Size = new System.Drawing.Size(174, 32);
			this.cbLoaiSanPham.TabIndex = 13;
			this.cbLoaiSanPham.Text = null;
			this.cbLoaiSanPham.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbLoaiSanPham.TextLeftMargin = 5;
			this.cbLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSanPham_SelectedIndexChanged);
			// 
			// cbTrangThai
			// 
			this.cbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
			this.cbTrangThai.BackgroundColor = System.Drawing.Color.White;
			this.cbTrangThai.BorderColor = System.Drawing.Color.Silver;
			this.cbTrangThai.BorderRadius = 17;
			this.cbTrangThai.Color = System.Drawing.Color.Silver;
			this.cbTrangThai.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbTrangThai.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbTrangThai.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.cbTrangThai.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbTrangThai.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.cbTrangThai.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbTrangThai.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTrangThai.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbTrangThai.FillDropDown = true;
			this.cbTrangThai.FillIndicator = false;
			this.cbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbTrangThai.ForeColor = System.Drawing.Color.Black;
			this.cbTrangThai.FormattingEnabled = true;
			this.cbTrangThai.Icon = null;
			this.cbTrangThai.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbTrangThai.IndicatorColor = System.Drawing.Color.Gray;
			this.cbTrangThai.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbTrangThai.ItemBackColor = System.Drawing.Color.White;
			this.cbTrangThai.ItemBorderColor = System.Drawing.Color.White;
			this.cbTrangThai.ItemForeColor = System.Drawing.Color.Black;
			this.cbTrangThai.ItemHeight = 26;
			this.cbTrangThai.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.cbTrangThai.ItemHighLightForeColor = System.Drawing.Color.White;
			this.cbTrangThai.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng bán"});
			this.cbTrangThai.ItemTopMargin = 3;
			this.cbTrangThai.Location = new System.Drawing.Point(577, 99);
			this.cbTrangThai.Name = "cbTrangThai";
			this.cbTrangThai.Size = new System.Drawing.Size(174, 32);
			this.cbTrangThai.TabIndex = 13;
			this.cbTrangThai.Text = null;
			this.cbTrangThai.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbTrangThai.TextLeftMargin = 5;
			this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnExport.FlatAppearance.BorderSize = 0;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExport.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
			this.btnExport.IconColor = System.Drawing.Color.Black;
			this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnExport.IconSize = 30;
			this.btnExport.Location = new System.Drawing.Point(979, 39);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(113, 40);
			this.btnExport.TabIndex = 14;
			this.btnExport.Text = "Export";
			this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// F_QuanLyHangHoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 740);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.cbTrangThai);
			this.Controls.Add(this.cbLoaiSanPham);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.dgvSanPham);
			this.Controls.Add(this.txbTimKiem);
			this.Controls.Add(this.panelheader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "F_QuanLyHangHoa";
			this.Text = "F_QuanLyHangHoa";
			this.panelheader.ResumeLayout(false);
			this.panelheader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txbTimKiem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private Bunifu.UI.WinForms.BunifuDropdown cbLoaiSanPham;
        private Bunifu.UI.WinForms.BunifuDropdown cbTrangThai;
        private FontAwesome.Sharp.IconButton btnExport;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdLoaiSanPham;
		private System.Windows.Forms.DataGridViewTextBoxColumn ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
		private System.Windows.Forms.DataGridViewImageColumn anh;
		private System.Windows.Forms.DataGridViewTextBoxColumn mavach;
		private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
		private System.Windows.Forms.DataGridViewButtonColumn update;
		private System.Windows.Forms.DataGridViewButtonColumn del;
	}
}