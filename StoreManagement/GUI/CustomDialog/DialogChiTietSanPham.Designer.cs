namespace StoreManagement.GUI.CustomDialog
{
    partial class DialogChiTietSanPham
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogChiTietSanPham));
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.noticeHeader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCloseDialog = new FontAwesome.Sharp.IconButton();
			this.dgvLichSuNhap = new System.Windows.Forms.DataGridView();
			this.idPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnUpdate = new FontAwesome.Sharp.IconButton();
			this.label2 = new System.Windows.Forms.Label();
			this.picAnhSanPham = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbMaSanPham = new Bunifu.UI.WinForms.BunifuTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbTenSanPham = new Bunifu.UI.WinForms.BunifuTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txbSoLuong = new Bunifu.UI.WinForms.BunifuTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txbGiaBan = new Bunifu.UI.WinForms.BunifuTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbLoaiSanPham = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbTrangThai = new Bunifu.UI.WinForms.BunifuDropdown();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.noticeHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLichSuNhap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAnhSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// noticeHeader
			// 
			this.noticeHeader.BackColor = System.Drawing.Color.White;
			this.noticeHeader.Controls.Add(this.label1);
			this.noticeHeader.Controls.Add(this.btnCloseDialog);
			this.noticeHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.noticeHeader.Location = new System.Drawing.Point(0, 0);
			this.noticeHeader.Name = "noticeHeader";
			this.noticeHeader.Size = new System.Drawing.Size(760, 32);
			this.noticeHeader.TabIndex = 4;
			this.noticeHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Chi tiết sản phẩm";
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
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
			this.btnCloseDialog.Location = new System.Drawing.Point(718, 0);
			this.btnCloseDialog.Margin = new System.Windows.Forms.Padding(20);
			this.btnCloseDialog.Name = "btnCloseDialog";
			this.btnCloseDialog.Size = new System.Drawing.Size(42, 32);
			this.btnCloseDialog.TabIndex = 1;
			this.btnCloseDialog.UseVisualStyleBackColor = false;
			this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
			// 
			// dgvLichSuNhap
			// 
			this.dgvLichSuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLichSuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvLichSuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLichSuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvLichSuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLichSuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPhieu,
            this.ngayNhap,
            this.nhaCungCap,
            this.soLuong,
            this.giaNhap});
			this.dgvLichSuNhap.Location = new System.Drawing.Point(0, 232);
			this.dgvLichSuNhap.Name = "dgvLichSuNhap";
			this.dgvLichSuNhap.Size = new System.Drawing.Size(760, 343);
			this.dgvLichSuNhap.TabIndex = 6;
			// 
			// idPhieu
			// 
			this.idPhieu.HeaderText = "Mã phiếu nhập";
			this.idPhieu.Name = "idPhieu";
			// 
			// ngayNhap
			// 
			this.ngayNhap.HeaderText = "Ngày Nhập";
			this.ngayNhap.Name = "ngayNhap";
			// 
			// nhaCungCap
			// 
			this.nhaCungCap.HeaderText = "Nhà cung cấp";
			this.nhaCungCap.Name = "nhaCungCap";
			// 
			// soLuong
			// 
			this.soLuong.HeaderText = "Số lượng";
			this.soLuong.Name = "soLuong";
			// 
			// giaNhap
			// 
			this.giaNhap.HeaderText = "Giá nhập";
			this.giaNhap.Name = "giaNhap";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
			this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
			this.btnUpdate.IconColor = System.Drawing.Color.White;
			this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnUpdate.IconSize = 25;
			this.btnUpdate.Location = new System.Drawing.Point(638, 175);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(105, 34);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(2, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Lịch sử nhập hàng";
			// 
			// picAnhSanPham
			// 
			this.picAnhSanPham.BackColor = System.Drawing.Color.White;
			this.picAnhSanPham.Image = ((System.Drawing.Image)(resources.GetObject("picAnhSanPham.Image")));
			this.picAnhSanPham.Location = new System.Drawing.Point(6, 38);
			this.picAnhSanPham.Name = "picAnhSanPham";
			this.picAnhSanPham.Size = new System.Drawing.Size(156, 165);
			this.picAnhSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAnhSanPham.TabIndex = 9;
			this.picAnhSanPham.TabStop = false;
			this.picAnhSanPham.Click += new System.EventHandler(this.picSanPham_Click);
			this.picAnhSanPham.MouseEnter += new System.EventHandler(this.picAnhSanPham_MouseEnter);
			this.picAnhSanPham.MouseLeave += new System.EventHandler(this.picAnhSanPham_MouseLeave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(171, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Mã sản phẩm:";
			// 
			// txbMaSanPham
			// 
			this.txbMaSanPham.AcceptsReturn = false;
			this.txbMaSanPham.AcceptsTab = false;
			this.txbMaSanPham.AnimationSpeed = 200;
			this.txbMaSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbMaSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbMaSanPham.BackColor = System.Drawing.Color.Transparent;
			this.txbMaSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbMaSanPham.BackgroundImage")));
			this.txbMaSanPham.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbMaSanPham.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbMaSanPham.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbMaSanPham.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbMaSanPham.BorderRadius = 35;
			this.txbMaSanPham.BorderThickness = 1;
			this.txbMaSanPham.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbMaSanPham.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbMaSanPham.DefaultText = "";
			this.txbMaSanPham.FillColor = System.Drawing.Color.White;
			this.txbMaSanPham.HideSelection = true;
			this.txbMaSanPham.IconLeft = null;
			this.txbMaSanPham.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbMaSanPham.IconPadding = 10;
			this.txbMaSanPham.IconRight = null;
			this.txbMaSanPham.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbMaSanPham.Lines = new string[0];
			this.txbMaSanPham.Location = new System.Drawing.Point(291, 39);
			this.txbMaSanPham.MaxLength = 32767;
			this.txbMaSanPham.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbMaSanPham.Modified = false;
			this.txbMaSanPham.Multiline = false;
			this.txbMaSanPham.Name = "txbMaSanPham";
			stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties13.FillColor = System.Drawing.Color.Empty;
			stateProperties13.ForeColor = System.Drawing.Color.Empty;
			stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbMaSanPham.OnActiveState = stateProperties13;
			stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbMaSanPham.OnDisabledState = stateProperties14;
			stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties15.FillColor = System.Drawing.Color.Empty;
			stateProperties15.ForeColor = System.Drawing.Color.Empty;
			stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbMaSanPham.OnHoverState = stateProperties15;
			stateProperties16.BorderColor = System.Drawing.Color.Silver;
			stateProperties16.FillColor = System.Drawing.Color.White;
			stateProperties16.ForeColor = System.Drawing.Color.Empty;
			stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbMaSanPham.OnIdleState = stateProperties16;
			this.txbMaSanPham.Padding = new System.Windows.Forms.Padding(3);
			this.txbMaSanPham.PasswordChar = '\0';
			this.txbMaSanPham.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbMaSanPham.PlaceholderText = "Enter text";
			this.txbMaSanPham.ReadOnly = false;
			this.txbMaSanPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbMaSanPham.SelectedText = "";
			this.txbMaSanPham.SelectionLength = 0;
			this.txbMaSanPham.SelectionStart = 0;
			this.txbMaSanPham.ShortcutsEnabled = true;
			this.txbMaSanPham.Size = new System.Drawing.Size(175, 38);
			this.txbMaSanPham.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbMaSanPham.TabIndex = 11;
			this.txbMaSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbMaSanPham.TextMarginBottom = 0;
			this.txbMaSanPham.TextMarginLeft = 3;
			this.txbMaSanPham.TextMarginTop = 0;
			this.txbMaSanPham.TextPlaceholder = "Enter text";
			this.txbMaSanPham.UseSystemPasswordChar = false;
			this.txbMaSanPham.WordWrap = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(171, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Tên sản phẩm:";
			// 
			// txbTenSanPham
			// 
			this.txbTenSanPham.AcceptsReturn = false;
			this.txbTenSanPham.AcceptsTab = false;
			this.txbTenSanPham.AnimationSpeed = 200;
			this.txbTenSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbTenSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbTenSanPham.BackColor = System.Drawing.Color.Transparent;
			this.txbTenSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbTenSanPham.BackgroundImage")));
			this.txbTenSanPham.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbTenSanPham.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbTenSanPham.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbTenSanPham.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbTenSanPham.BorderRadius = 35;
			this.txbTenSanPham.BorderThickness = 1;
			this.txbTenSanPham.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbTenSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTenSanPham.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbTenSanPham.DefaultText = "";
			this.txbTenSanPham.FillColor = System.Drawing.Color.White;
			this.txbTenSanPham.HideSelection = true;
			this.txbTenSanPham.IconLeft = null;
			this.txbTenSanPham.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTenSanPham.IconPadding = 10;
			this.txbTenSanPham.IconRight = null;
			this.txbTenSanPham.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTenSanPham.Lines = new string[0];
			this.txbTenSanPham.Location = new System.Drawing.Point(291, 83);
			this.txbTenSanPham.MaxLength = 32767;
			this.txbTenSanPham.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbTenSanPham.Modified = false;
			this.txbTenSanPham.Multiline = false;
			this.txbTenSanPham.Name = "txbTenSanPham";
			stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties9.FillColor = System.Drawing.Color.Empty;
			stateProperties9.ForeColor = System.Drawing.Color.Empty;
			stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTenSanPham.OnActiveState = stateProperties9;
			stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbTenSanPham.OnDisabledState = stateProperties10;
			stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties11.FillColor = System.Drawing.Color.Empty;
			stateProperties11.ForeColor = System.Drawing.Color.Empty;
			stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTenSanPham.OnHoverState = stateProperties11;
			stateProperties12.BorderColor = System.Drawing.Color.Silver;
			stateProperties12.FillColor = System.Drawing.Color.White;
			stateProperties12.ForeColor = System.Drawing.Color.Empty;
			stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTenSanPham.OnIdleState = stateProperties12;
			this.txbTenSanPham.Padding = new System.Windows.Forms.Padding(3);
			this.txbTenSanPham.PasswordChar = '\0';
			this.txbTenSanPham.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbTenSanPham.PlaceholderText = "Enter text";
			this.txbTenSanPham.ReadOnly = false;
			this.txbTenSanPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbTenSanPham.SelectedText = "";
			this.txbTenSanPham.SelectionLength = 0;
			this.txbTenSanPham.SelectionStart = 0;
			this.txbTenSanPham.ShortcutsEnabled = true;
			this.txbTenSanPham.Size = new System.Drawing.Size(175, 38);
			this.txbTenSanPham.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbTenSanPham.TabIndex = 11;
			this.txbTenSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbTenSanPham.TextMarginBottom = 0;
			this.txbTenSanPham.TextMarginLeft = 3;
			this.txbTenSanPham.TextMarginTop = 0;
			this.txbTenSanPham.TextPlaceholder = "Enter text";
			this.txbTenSanPham.UseSystemPasswordChar = false;
			this.txbTenSanPham.WordWrap = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(171, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Loại sản phẩm:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(465, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Số lượng :";
			// 
			// txbSoLuong
			// 
			this.txbSoLuong.AcceptsReturn = false;
			this.txbSoLuong.AcceptsTab = false;
			this.txbSoLuong.AnimationSpeed = 200;
			this.txbSoLuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbSoLuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbSoLuong.BackColor = System.Drawing.Color.Transparent;
			this.txbSoLuong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbSoLuong.BackgroundImage")));
			this.txbSoLuong.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbSoLuong.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbSoLuong.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbSoLuong.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbSoLuong.BorderRadius = 35;
			this.txbSoLuong.BorderThickness = 1;
			this.txbSoLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbSoLuong.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbSoLuong.DefaultText = "";
			this.txbSoLuong.FillColor = System.Drawing.Color.White;
			this.txbSoLuong.HideSelection = true;
			this.txbSoLuong.IconLeft = null;
			this.txbSoLuong.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbSoLuong.IconPadding = 10;
			this.txbSoLuong.IconRight = null;
			this.txbSoLuong.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbSoLuong.Lines = new string[0];
			this.txbSoLuong.Location = new System.Drawing.Point(551, 39);
			this.txbSoLuong.MaxLength = 32767;
			this.txbSoLuong.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbSoLuong.Modified = false;
			this.txbSoLuong.Multiline = false;
			this.txbSoLuong.Name = "txbSoLuong";
			stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbSoLuong.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbSoLuong.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbSoLuong.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Silver;
			stateProperties8.FillColor = System.Drawing.Color.White;
			stateProperties8.ForeColor = System.Drawing.Color.Empty;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbSoLuong.OnIdleState = stateProperties8;
			this.txbSoLuong.Padding = new System.Windows.Forms.Padding(3);
			this.txbSoLuong.PasswordChar = '\0';
			this.txbSoLuong.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbSoLuong.PlaceholderText = "Enter text";
			this.txbSoLuong.ReadOnly = false;
			this.txbSoLuong.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbSoLuong.SelectedText = "";
			this.txbSoLuong.SelectionLength = 0;
			this.txbSoLuong.SelectionStart = 0;
			this.txbSoLuong.ShortcutsEnabled = true;
			this.txbSoLuong.Size = new System.Drawing.Size(192, 38);
			this.txbSoLuong.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbSoLuong.TabIndex = 11;
			this.txbSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbSoLuong.TextMarginBottom = 0;
			this.txbSoLuong.TextMarginLeft = 3;
			this.txbSoLuong.TextMarginTop = 0;
			this.txbSoLuong.TextPlaceholder = "Enter text";
			this.txbSoLuong.UseSystemPasswordChar = false;
			this.txbSoLuong.WordWrap = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(465, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Giá bán:";
			// 
			// txbGiaBan
			// 
			this.txbGiaBan.AcceptsReturn = false;
			this.txbGiaBan.AcceptsTab = false;
			this.txbGiaBan.AnimationSpeed = 200;
			this.txbGiaBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbGiaBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbGiaBan.BackColor = System.Drawing.Color.Transparent;
			this.txbGiaBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbGiaBan.BackgroundImage")));
			this.txbGiaBan.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbGiaBan.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbGiaBan.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbGiaBan.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbGiaBan.BorderRadius = 35;
			this.txbGiaBan.BorderThickness = 1;
			this.txbGiaBan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbGiaBan.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbGiaBan.DefaultText = "";
			this.txbGiaBan.FillColor = System.Drawing.Color.White;
			this.txbGiaBan.HideSelection = true;
			this.txbGiaBan.IconLeft = null;
			this.txbGiaBan.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbGiaBan.IconPadding = 10;
			this.txbGiaBan.IconRight = null;
			this.txbGiaBan.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbGiaBan.Lines = new string[0];
			this.txbGiaBan.Location = new System.Drawing.Point(551, 83);
			this.txbGiaBan.MaxLength = 32767;
			this.txbGiaBan.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbGiaBan.Modified = false;
			this.txbGiaBan.Multiline = false;
			this.txbGiaBan.Name = "txbGiaBan";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbGiaBan.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbGiaBan.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbGiaBan.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbGiaBan.OnIdleState = stateProperties4;
			this.txbGiaBan.Padding = new System.Windows.Forms.Padding(3);
			this.txbGiaBan.PasswordChar = '\0';
			this.txbGiaBan.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbGiaBan.PlaceholderText = "Enter text";
			this.txbGiaBan.ReadOnly = false;
			this.txbGiaBan.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbGiaBan.SelectedText = "";
			this.txbGiaBan.SelectionLength = 0;
			this.txbGiaBan.SelectionStart = 0;
			this.txbGiaBan.ShortcutsEnabled = true;
			this.txbGiaBan.Size = new System.Drawing.Size(192, 38);
			this.txbGiaBan.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbGiaBan.TabIndex = 11;
			this.txbGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbGiaBan.TextMarginBottom = 0;
			this.txbGiaBan.TextMarginLeft = 3;
			this.txbGiaBan.TextMarginTop = 0;
			this.txbGiaBan.TextPlaceholder = "Enter text";
			this.txbGiaBan.UseSystemPasswordChar = false;
			this.txbGiaBan.WordWrap = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(465, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Trạng thái:";
			// 
			// cbLoaiSanPham
			// 
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
			this.cbLoaiSanPham.Location = new System.Drawing.Point(291, 126);
			this.cbLoaiSanPham.Name = "cbLoaiSanPham";
			this.cbLoaiSanPham.Size = new System.Drawing.Size(175, 32);
			this.cbLoaiSanPham.TabIndex = 12;
			this.cbLoaiSanPham.Text = null;
			this.cbLoaiSanPham.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbLoaiSanPham.TextLeftMargin = 5;
			// 
			// cbTrangThai
			// 
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
			this.cbTrangThai.Location = new System.Drawing.Point(551, 126);
			this.cbTrangThai.Name = "cbTrangThai";
			this.cbTrangThai.Size = new System.Drawing.Size(192, 32);
			this.cbTrangThai.TabIndex = 12;
			this.cbTrangThai.Text = null;
			this.cbTrangThai.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbTrangThai.TextLeftMargin = 5;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// DialogChiTietSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 577);
			this.Controls.Add(this.cbTrangThai);
			this.Controls.Add(this.cbLoaiSanPham);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txbGiaBan);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txbSoLuong);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txbTenSanPham);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txbMaSanPham);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.picAnhSanPham);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.dgvLichSuNhap);
			this.Controls.Add(this.noticeHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DialogChiTietSanPham";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DialogChiTietSanPham";
			this.Load += new System.EventHandler(this.DialogChiTietSanPham_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
			this.noticeHeader.ResumeLayout(false);
			this.noticeHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLichSuNhap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAnhSanPham)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel noticeHeader;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseDialog;
        private System.Windows.Forms.DataGridView dgvLichSuNhap;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAnhSanPham;
        private Bunifu.UI.WinForms.BunifuTextBox txbMaSanPham;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txbTenSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuTextBox txbGiaBan;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuTextBox txbSoLuong;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDropdown cbTrangThai;
        private Bunifu.UI.WinForms.BunifuDropdown cbLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}