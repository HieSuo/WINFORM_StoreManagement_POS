namespace StoreManagement.GUI.ModuleForm
{
    partial class F_QuanLyTaiKhoan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_QuanLyTaiKhoan));
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.panelheader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExport = new FontAwesome.Sharp.IconButton();
			this.btnTimKiem = new FontAwesome.Sharp.IconButton();
			this.txbTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.reset = new System.Windows.Forms.DataGridViewImageColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnThemMoi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.txbTenHienThi = new Bunifu.UI.WinForms.BunifuTextBox();
			this.txbUsername = new Bunifu.UI.WinForms.BunifuTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbLoaiTaiKhoan = new Bunifu.UI.WinForms.BunifuDropdown();
			this.btnCapNhap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.panelheader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
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
			this.label1.Size = new System.Drawing.Size(163, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lý tài khoản";
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
			this.btnExport.TabIndex = 21;
			this.btnExport.Text = "Export";
			this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExport.UseVisualStyleBackColor = false;
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
			this.btnTimKiem.Location = new System.Drawing.Point(1051, 128);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(28, 26);
			this.btnTimKiem.TabIndex = 20;
			this.btnTimKiem.UseVisualStyleBackColor = false;
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
			this.txbTimKiem.BorderRadius = 30;
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
			this.txbTimKiem.Location = new System.Drawing.Point(782, 125);
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
			this.txbTimKiem.Size = new System.Drawing.Size(307, 32);
			this.txbTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbTimKiem.TabIndex = 19;
			this.txbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbTimKiem.TextMarginBottom = 0;
			this.txbTimKiem.TextMarginLeft = 3;
			this.txbTimKiem.TextMarginTop = 0;
			this.txbTimKiem.TextPlaceholder = "Tìm kiếm";
			this.txbTimKiem.UseSystemPasswordChar = false;
			this.txbTimKiem.WordWrap = true;
			this.txbTimKiem.TextChanged += new System.EventHandler(this.txbTimKiem_TextChanged);
			// 
			// dgvAccount
			// 
			this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.ngayTao,
            this.nhaCungCap,
            this.delete,
            this.reset});
			this.dgvAccount.Location = new System.Drawing.Point(8, 163);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.Size = new System.Drawing.Size(1081, 541);
			this.dgvAccount.TabIndex = 18;
			this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
			// 
			// Username
			// 
			this.Username.HeaderText = "Username";
			this.Username.Name = "Username";
			// 
			// ngayTao
			// 
			this.ngayTao.DataPropertyName = "display name";
			this.ngayTao.HeaderText = "Tên hiển thị";
			this.ngayTao.Name = "ngayTao";
			// 
			// nhaCungCap
			// 
			this.nhaCungCap.HeaderText = "Phần quyền";
			this.nhaCungCap.Name = "nhaCungCap";
			// 
			// delete
			// 
			this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.delete.HeaderText = "Xóa";
			this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
			this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.delete.Name = "delete";
			this.delete.Width = 80;
			// 
			// reset
			// 
			this.reset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.reset.HeaderText = "Reset PW";
			this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
			this.reset.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.reset.Name = "reset";
			this.reset.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.reset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.reset.Width = 80;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(244, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 26);
			this.label3.TabIndex = 25;
			this.label3.Text = "Tên hiển thị";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(21, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 26);
			this.label2.TabIndex = 26;
			this.label2.Text = "Username";
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.AllowAnimations = true;
			this.btnThemMoi.AllowMouseEffects = true;
			this.btnThemMoi.AllowToggling = false;
			this.btnThemMoi.AnimationSpeed = 200;
			this.btnThemMoi.AutoGenerateColors = false;
			this.btnThemMoi.AutoRoundBorders = false;
			this.btnThemMoi.AutoSizeLeftIcon = true;
			this.btnThemMoi.AutoSizeRightIcon = true;
			this.btnThemMoi.BackColor = System.Drawing.Color.Transparent;
			this.btnThemMoi.BackColor1 = System.Drawing.Color.DodgerBlue;
			this.btnThemMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.BackgroundImage")));
			this.btnThemMoi.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemMoi.ButtonText = "Thêm mới";
			this.btnThemMoi.ButtonTextMarginLeft = 0;
			this.btnThemMoi.ColorContrastOnClick = 45;
			this.btnThemMoi.ColorContrastOnHover = 45;
			this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.btnThemMoi.CustomizableEdges = borderEdges1;
			this.btnThemMoi.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnThemMoi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThemMoi.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThemMoi.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThemMoi.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThemMoi.ForeColor = System.Drawing.Color.White;
			this.btnThemMoi.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemMoi.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnThemMoi.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnThemMoi.IconMarginLeft = 11;
			this.btnThemMoi.IconPadding = 10;
			this.btnThemMoi.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemMoi.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnThemMoi.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnThemMoi.IconSize = 25;
			this.btnThemMoi.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.btnThemMoi.IdleBorderRadius = 35;
			this.btnThemMoi.IdleBorderThickness = 1;
			this.btnThemMoi.IdleFillColor = System.Drawing.Color.DodgerBlue;
			this.btnThemMoi.IdleIconLeftImage = null;
			this.btnThemMoi.IdleIconRightImage = null;
			this.btnThemMoi.IndicateFocus = false;
			this.btnThemMoi.Location = new System.Drawing.Point(668, 115);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThemMoi.OnDisabledState.BorderRadius = 35;
			this.btnThemMoi.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemMoi.OnDisabledState.BorderThickness = 1;
			this.btnThemMoi.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThemMoi.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThemMoi.OnDisabledState.IconLeftImage = null;
			this.btnThemMoi.OnDisabledState.IconRightImage = null;
			this.btnThemMoi.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThemMoi.onHoverState.BorderRadius = 35;
			this.btnThemMoi.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemMoi.onHoverState.BorderThickness = 1;
			this.btnThemMoi.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThemMoi.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnThemMoi.onHoverState.IconLeftImage = null;
			this.btnThemMoi.onHoverState.IconRightImage = null;
			this.btnThemMoi.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnThemMoi.OnIdleState.BorderRadius = 35;
			this.btnThemMoi.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemMoi.OnIdleState.BorderThickness = 1;
			this.btnThemMoi.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnThemMoi.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnThemMoi.OnIdleState.IconLeftImage = null;
			this.btnThemMoi.OnIdleState.IconRightImage = null;
			this.btnThemMoi.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThemMoi.OnPressedState.BorderRadius = 35;
			this.btnThemMoi.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemMoi.OnPressedState.BorderThickness = 1;
			this.btnThemMoi.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThemMoi.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnThemMoi.OnPressedState.IconLeftImage = null;
			this.btnThemMoi.OnPressedState.IconRightImage = null;
			this.btnThemMoi.Size = new System.Drawing.Size(108, 39);
			this.btnThemMoi.TabIndex = 24;
			this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnThemMoi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnThemMoi.TextMarginLeft = 0;
			this.btnThemMoi.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnThemMoi.UseDefaultRadiusAndThickness = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// txbTenHienThi
			// 
			this.txbTenHienThi.AcceptsReturn = false;
			this.txbTenHienThi.AcceptsTab = false;
			this.txbTenHienThi.AnimationSpeed = 200;
			this.txbTenHienThi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbTenHienThi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbTenHienThi.BackColor = System.Drawing.Color.Transparent;
			this.txbTenHienThi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbTenHienThi.BackgroundImage")));
			this.txbTenHienThi.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbTenHienThi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbTenHienThi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbTenHienThi.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbTenHienThi.BorderRadius = 15;
			this.txbTenHienThi.BorderThickness = 1;
			this.txbTenHienThi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbTenHienThi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTenHienThi.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.txbTenHienThi.DefaultText = "";
			this.txbTenHienThi.FillColor = System.Drawing.Color.White;
			this.txbTenHienThi.HideSelection = true;
			this.txbTenHienThi.IconLeft = null;
			this.txbTenHienThi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTenHienThi.IconPadding = 10;
			this.txbTenHienThi.IconRight = null;
			this.txbTenHienThi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTenHienThi.Lines = new string[0];
			this.txbTenHienThi.Location = new System.Drawing.Point(240, 72);
			this.txbTenHienThi.MaxLength = 32767;
			this.txbTenHienThi.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbTenHienThi.Modified = false;
			this.txbTenHienThi.Multiline = false;
			this.txbTenHienThi.Name = "txbTenHienThi";
			stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTenHienThi.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbTenHienThi.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTenHienThi.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Silver;
			stateProperties8.FillColor = System.Drawing.Color.White;
			stateProperties8.ForeColor = System.Drawing.Color.Empty;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTenHienThi.OnIdleState = stateProperties8;
			this.txbTenHienThi.Padding = new System.Windows.Forms.Padding(3);
			this.txbTenHienThi.PasswordChar = '\0';
			this.txbTenHienThi.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbTenHienThi.PlaceholderText = "Enter text";
			this.txbTenHienThi.ReadOnly = false;
			this.txbTenHienThi.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbTenHienThi.SelectedText = "";
			this.txbTenHienThi.SelectionLength = 0;
			this.txbTenHienThi.SelectionStart = 0;
			this.txbTenHienThi.ShortcutsEnabled = true;
			this.txbTenHienThi.Size = new System.Drawing.Size(259, 37);
			this.txbTenHienThi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbTenHienThi.TabIndex = 2;
			this.txbTenHienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbTenHienThi.TextMarginBottom = 0;
			this.txbTenHienThi.TextMarginLeft = 3;
			this.txbTenHienThi.TextMarginTop = 0;
			this.txbTenHienThi.TextPlaceholder = "Enter text";
			this.txbTenHienThi.UseSystemPasswordChar = false;
			this.txbTenHienThi.WordWrap = true;
			// 
			// txbUsername
			// 
			this.txbUsername.AcceptsReturn = false;
			this.txbUsername.AcceptsTab = false;
			this.txbUsername.AnimationSpeed = 200;
			this.txbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbUsername.BackColor = System.Drawing.Color.Transparent;
			this.txbUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbUsername.BackgroundImage")));
			this.txbUsername.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbUsername.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbUsername.BorderRadius = 15;
			this.txbUsername.BorderThickness = 1;
			this.txbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.txbUsername.DefaultText = "";
			this.txbUsername.FillColor = System.Drawing.Color.White;
			this.txbUsername.HideSelection = true;
			this.txbUsername.IconLeft = null;
			this.txbUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbUsername.IconPadding = 10;
			this.txbUsername.IconRight = null;
			this.txbUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbUsername.Lines = new string[0];
			this.txbUsername.Location = new System.Drawing.Point(17, 72);
			this.txbUsername.MaxLength = 32767;
			this.txbUsername.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbUsername.Modified = false;
			this.txbUsername.Multiline = false;
			this.txbUsername.Name = "txbUsername";
			stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties9.FillColor = System.Drawing.Color.Empty;
			stateProperties9.ForeColor = System.Drawing.Color.Empty;
			stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbUsername.OnActiveState = stateProperties9;
			stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbUsername.OnDisabledState = stateProperties10;
			stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties11.FillColor = System.Drawing.Color.Empty;
			stateProperties11.ForeColor = System.Drawing.Color.Empty;
			stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbUsername.OnHoverState = stateProperties11;
			stateProperties12.BorderColor = System.Drawing.Color.Silver;
			stateProperties12.FillColor = System.Drawing.Color.White;
			stateProperties12.ForeColor = System.Drawing.Color.Empty;
			stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbUsername.OnIdleState = stateProperties12;
			this.txbUsername.Padding = new System.Windows.Forms.Padding(3);
			this.txbUsername.PasswordChar = '\0';
			this.txbUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbUsername.PlaceholderText = "Enter text";
			this.txbUsername.ReadOnly = false;
			this.txbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbUsername.SelectedText = "";
			this.txbUsername.SelectionLength = 0;
			this.txbUsername.SelectionStart = 0;
			this.txbUsername.ShortcutsEnabled = true;
			this.txbUsername.Size = new System.Drawing.Size(204, 37);
			this.txbUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbUsername.TabIndex = 1;
			this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbUsername.TextMarginBottom = 0;
			this.txbUsername.TextMarginLeft = 3;
			this.txbUsername.TextMarginTop = 0;
			this.txbUsername.TextPlaceholder = "Enter text";
			this.txbUsername.UseSystemPasswordChar = false;
			this.txbUsername.WordWrap = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(521, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 26);
			this.label4.TabIndex = 25;
			this.label4.Text = "Loại tài khoản";
			// 
			// cbLoaiTaiKhoan
			// 
			this.cbLoaiTaiKhoan.BackColor = System.Drawing.Color.Transparent;
			this.cbLoaiTaiKhoan.BackgroundColor = System.Drawing.Color.White;
			this.cbLoaiTaiKhoan.BorderColor = System.Drawing.Color.Silver;
			this.cbLoaiTaiKhoan.BorderRadius = 7;
			this.cbLoaiTaiKhoan.Color = System.Drawing.Color.Silver;
			this.cbLoaiTaiKhoan.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbLoaiTaiKhoan.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbLoaiTaiKhoan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.cbLoaiTaiKhoan.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbLoaiTaiKhoan.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.cbLoaiTaiKhoan.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.cbLoaiTaiKhoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbLoaiTaiKhoan.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLoaiTaiKhoan.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbLoaiTaiKhoan.FillDropDown = true;
			this.cbLoaiTaiKhoan.FillIndicator = false;
			this.cbLoaiTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbLoaiTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbLoaiTaiKhoan.ForeColor = System.Drawing.Color.Black;
			this.cbLoaiTaiKhoan.FormattingEnabled = true;
			this.cbLoaiTaiKhoan.Icon = null;
			this.cbLoaiTaiKhoan.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbLoaiTaiKhoan.IndicatorColor = System.Drawing.Color.Gray;
			this.cbLoaiTaiKhoan.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbLoaiTaiKhoan.ItemBackColor = System.Drawing.Color.White;
			this.cbLoaiTaiKhoan.ItemBorderColor = System.Drawing.Color.White;
			this.cbLoaiTaiKhoan.ItemForeColor = System.Drawing.Color.Black;
			this.cbLoaiTaiKhoan.ItemHeight = 26;
			this.cbLoaiTaiKhoan.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.cbLoaiTaiKhoan.ItemHighLightForeColor = System.Drawing.Color.White;
			this.cbLoaiTaiKhoan.Items.AddRange(new object[] {
            "staff",
            "admin"});
			this.cbLoaiTaiKhoan.ItemTopMargin = 3;
			this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(526, 73);
			this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
			this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(250, 32);
			this.cbLoaiTaiKhoan.TabIndex = 3;
			this.cbLoaiTaiKhoan.Text = null;
			this.cbLoaiTaiKhoan.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbLoaiTaiKhoan.TextLeftMargin = 5;
			// 
			// btnCapNhap
			// 
			this.btnCapNhap.AllowAnimations = true;
			this.btnCapNhap.AllowMouseEffects = true;
			this.btnCapNhap.AllowToggling = false;
			this.btnCapNhap.AnimationSpeed = 200;
			this.btnCapNhap.AutoGenerateColors = false;
			this.btnCapNhap.AutoRoundBorders = false;
			this.btnCapNhap.AutoSizeLeftIcon = true;
			this.btnCapNhap.AutoSizeRightIcon = true;
			this.btnCapNhap.BackColor = System.Drawing.Color.Transparent;
			this.btnCapNhap.BackColor1 = System.Drawing.Color.Chartreuse;
			this.btnCapNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.BackgroundImage")));
			this.btnCapNhap.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCapNhap.ButtonText = "Cập nhật";
			this.btnCapNhap.ButtonTextMarginLeft = 0;
			this.btnCapNhap.ColorContrastOnClick = 45;
			this.btnCapNhap.ColorContrastOnHover = 45;
			this.btnCapNhap.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges2.BottomLeft = true;
			borderEdges2.BottomRight = true;
			borderEdges2.TopLeft = true;
			borderEdges2.TopRight = true;
			this.btnCapNhap.CustomizableEdges = borderEdges2;
			this.btnCapNhap.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnCapNhap.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnCapNhap.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCapNhap.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnCapNhap.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnCapNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnCapNhap.ForeColor = System.Drawing.Color.Black;
			this.btnCapNhap.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapNhap.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnCapNhap.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnCapNhap.IconMarginLeft = 11;
			this.btnCapNhap.IconPadding = 10;
			this.btnCapNhap.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapNhap.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnCapNhap.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnCapNhap.IconSize = 25;
			this.btnCapNhap.IdleBorderColor = System.Drawing.Color.Chartreuse;
			this.btnCapNhap.IdleBorderRadius = 30;
			this.btnCapNhap.IdleBorderThickness = 1;
			this.btnCapNhap.IdleFillColor = System.Drawing.Color.Chartreuse;
			this.btnCapNhap.IdleIconLeftImage = null;
			this.btnCapNhap.IdleIconRightImage = null;
			this.btnCapNhap.IndicateFocus = false;
			this.btnCapNhap.Location = new System.Drawing.Point(555, 115);
			this.btnCapNhap.Name = "btnCapNhap";
			this.btnCapNhap.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnCapNhap.OnDisabledState.BorderRadius = 30;
			this.btnCapNhap.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCapNhap.OnDisabledState.BorderThickness = 1;
			this.btnCapNhap.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCapNhap.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnCapNhap.OnDisabledState.IconLeftImage = null;
			this.btnCapNhap.OnDisabledState.IconRightImage = null;
			this.btnCapNhap.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnCapNhap.onHoverState.BorderRadius = 30;
			this.btnCapNhap.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCapNhap.onHoverState.BorderThickness = 1;
			this.btnCapNhap.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnCapNhap.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnCapNhap.onHoverState.IconLeftImage = null;
			this.btnCapNhap.onHoverState.IconRightImage = null;
			this.btnCapNhap.OnIdleState.BorderColor = System.Drawing.Color.Chartreuse;
			this.btnCapNhap.OnIdleState.BorderRadius = 30;
			this.btnCapNhap.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCapNhap.OnIdleState.BorderThickness = 1;
			this.btnCapNhap.OnIdleState.FillColor = System.Drawing.Color.Chartreuse;
			this.btnCapNhap.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.btnCapNhap.OnIdleState.IconLeftImage = null;
			this.btnCapNhap.OnIdleState.IconRightImage = null;
			this.btnCapNhap.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnCapNhap.OnPressedState.BorderRadius = 30;
			this.btnCapNhap.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCapNhap.OnPressedState.BorderThickness = 1;
			this.btnCapNhap.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnCapNhap.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnCapNhap.OnPressedState.IconLeftImage = null;
			this.btnCapNhap.OnPressedState.IconRightImage = null;
			this.btnCapNhap.Size = new System.Drawing.Size(107, 35);
			this.btnCapNhap.TabIndex = 27;
			this.btnCapNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCapNhap.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnCapNhap.TextMarginLeft = 0;
			this.btnCapNhap.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnCapNhap.UseDefaultRadiusAndThickness = true;
			this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
			// 
			// F_QuanLyTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 740);
			this.Controls.Add(this.btnCapNhap);
			this.Controls.Add(this.cbLoaiTaiKhoan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnThemMoi);
			this.Controls.Add(this.txbTenHienThi);
			this.Controls.Add(this.txbUsername);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.txbTimKiem);
			this.Controls.Add(this.dgvAccount);
			this.Controls.Add(this.panelheader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "F_QuanLyTaiKhoan";
			this.Text = "QuanLyTaiKhoan";
			this.panelheader.ResumeLayout(false);
			this.panelheader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private Bunifu.UI.WinForms.BunifuTextBox txbTimKiem;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemMoi;
        private Bunifu.UI.WinForms.BunifuTextBox txbTenHienThi;
        private Bunifu.UI.WinForms.BunifuTextBox txbUsername;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown cbLoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaCungCap;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn reset;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCapNhap;
    }
}