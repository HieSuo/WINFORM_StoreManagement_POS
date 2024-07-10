using BunifuAnimatorNS;

namespace StoreManagement.GUI.ModuleForm
{
    partial class F_LoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LoaiHang));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panelheader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaLoai = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnThemMoi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.maLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txbTenLoai = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txbTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.btnExportExcel = new FontAwesome.Sharp.IconButton();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý loại hàng";
            // 
            // txbMaLoai
            // 
            this.txbMaLoai.AcceptsReturn = false;
            this.txbMaLoai.AcceptsTab = false;
            this.txbMaLoai.AnimationSpeed = 200;
            this.txbMaLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbMaLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.txbMaLoai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbMaLoai.BackgroundImage")));
            this.txbMaLoai.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbMaLoai.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbMaLoai.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbMaLoai.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbMaLoai.BorderRadius = 15;
            this.txbMaLoai.BorderThickness = 1;
            this.txbMaLoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbMaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaLoai.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbMaLoai.DefaultText = "";
            this.txbMaLoai.FillColor = System.Drawing.Color.White;
            this.txbMaLoai.HideSelection = true;
            this.txbMaLoai.IconLeft = null;
            this.txbMaLoai.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaLoai.IconPadding = 10;
            this.txbMaLoai.IconRight = null;
            this.txbMaLoai.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaLoai.Lines = new string[0];
            this.txbMaLoai.Location = new System.Drawing.Point(17, 80);
            this.txbMaLoai.MaxLength = 32767;
            this.txbMaLoai.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbMaLoai.Modified = false;
            this.txbMaLoai.Multiline = false;
            this.txbMaLoai.Name = "txbMaLoai";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbMaLoai.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbMaLoai.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbMaLoai.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbMaLoai.OnIdleState = stateProperties4;
            this.txbMaLoai.Padding = new System.Windows.Forms.Padding(3);
            this.txbMaLoai.PasswordChar = '\0';
            this.txbMaLoai.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbMaLoai.PlaceholderText = "Enter text";
            this.txbMaLoai.ReadOnly = false;
            this.txbMaLoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMaLoai.SelectedText = "";
            this.txbMaLoai.SelectionLength = 0;
            this.txbMaLoai.SelectionStart = 0;
            this.txbMaLoai.ShortcutsEnabled = true;
            this.txbMaLoai.Size = new System.Drawing.Size(304, 37);
            this.txbMaLoai.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbMaLoai.TabIndex = 3;
            this.txbMaLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMaLoai.TextMarginBottom = 0;
            this.txbMaLoai.TextMarginLeft = 3;
            this.txbMaLoai.TextMarginTop = 0;
            this.txbMaLoai.TextPlaceholder = "Enter text";
            this.txbMaLoai.UseSystemPasswordChar = false;
            this.txbMaLoai.WordWrap = true;
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
            this.btnThemMoi.IdleBorderRadius = 20;
            this.btnThemMoi.IdleBorderThickness = 1;
            this.btnThemMoi.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnThemMoi.IdleIconLeftImage = null;
            this.btnThemMoi.IdleIconRightImage = null;
            this.btnThemMoi.IndicateFocus = false;
            this.btnThemMoi.Location = new System.Drawing.Point(336, 158);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemMoi.OnDisabledState.BorderRadius = 20;
            this.btnThemMoi.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.OnDisabledState.BorderThickness = 1;
            this.btnThemMoi.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemMoi.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemMoi.OnDisabledState.IconLeftImage = null;
            this.btnThemMoi.OnDisabledState.IconRightImage = null;
            this.btnThemMoi.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemMoi.onHoverState.BorderRadius = 20;
            this.btnThemMoi.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.onHoverState.BorderThickness = 1;
            this.btnThemMoi.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemMoi.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.onHoverState.IconLeftImage = null;
            this.btnThemMoi.onHoverState.IconRightImage = null;
            this.btnThemMoi.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemMoi.OnIdleState.BorderRadius = 20;
            this.btnThemMoi.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.OnIdleState.BorderThickness = 1;
            this.btnThemMoi.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThemMoi.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.OnIdleState.IconLeftImage = null;
            this.btnThemMoi.OnIdleState.IconRightImage = null;
            this.btnThemMoi.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemMoi.OnPressedState.BorderRadius = 20;
            this.btnThemMoi.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.OnPressedState.BorderThickness = 1;
            this.btnThemMoi.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemMoi.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.OnPressedState.IconLeftImage = null;
            this.btnThemMoi.OnPressedState.IconRightImage = null;
            this.btnThemMoi.Size = new System.Drawing.Size(108, 39);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemMoi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemMoi.TextMarginLeft = 0;
            this.btnThemMoi.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThemMoi.UseDefaultRadiusAndThickness = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiSanPham,
            this.tenLoaiSanPham,
            this.update,
            this.delete});
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(12, 203);
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(1068, 525);
            this.dgvLoaiSanPham.TabIndex = 5;
            this.dgvLoaiSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSanPham_CellContentClick);
            // 
            // maLoaiSanPham
            // 
            this.maLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maLoaiSanPham.DataPropertyName = "id";
            this.maLoaiSanPham.HeaderText = "Mã loại sản phẩm";
            this.maLoaiSanPham.Name = "maLoaiSanPham";
            this.maLoaiSanPham.ReadOnly = true;
            this.maLoaiSanPham.Width = 200;
            // 
            // tenLoaiSanPham
            // 
            this.tenLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiSanPham.DataPropertyName = "tenLoaiSanPham";
            this.tenLoaiSanPham.HeaderText = "Tên Loại Sản Phẩm";
            this.tenLoaiSanPham.Name = "tenLoaiSanPham";
            // 
            // update
            // 
            this.update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.update.HeaderText = "Cập nhật";
            this.update.Name = "update";
            this.update.Text = "Cập nhật";
            this.update.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Text = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // txbTenLoai
            // 
            this.txbTenLoai.AcceptsReturn = false;
            this.txbTenLoai.AcceptsTab = false;
            this.txbTenLoai.AnimationSpeed = 200;
            this.txbTenLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbTenLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbTenLoai.BackColor = System.Drawing.Color.Transparent;
            this.txbTenLoai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbTenLoai.BackgroundImage")));
            this.txbTenLoai.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbTenLoai.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbTenLoai.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbTenLoai.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbTenLoai.BorderRadius = 15;
            this.txbTenLoai.BorderThickness = 1;
            this.txbTenLoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenLoai.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbTenLoai.DefaultText = "";
            this.txbTenLoai.FillColor = System.Drawing.Color.White;
            this.txbTenLoai.HideSelection = true;
            this.txbTenLoai.IconLeft = null;
            this.txbTenLoai.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenLoai.IconPadding = 10;
            this.txbTenLoai.IconRight = null;
            this.txbTenLoai.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenLoai.Lines = new string[0];
            this.txbTenLoai.Location = new System.Drawing.Point(17, 160);
            this.txbTenLoai.MaxLength = 32767;
            this.txbTenLoai.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbTenLoai.Modified = false;
            this.txbTenLoai.Multiline = false;
            this.txbTenLoai.Name = "txbTenLoai";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTenLoai.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbTenLoai.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTenLoai.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTenLoai.OnIdleState = stateProperties8;
            this.txbTenLoai.Padding = new System.Windows.Forms.Padding(3);
            this.txbTenLoai.PasswordChar = '\0';
            this.txbTenLoai.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbTenLoai.PlaceholderText = "Enter text";
            this.txbTenLoai.ReadOnly = false;
            this.txbTenLoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTenLoai.SelectedText = "";
            this.txbTenLoai.SelectionLength = 0;
            this.txbTenLoai.SelectionStart = 0;
            this.txbTenLoai.ShortcutsEnabled = true;
            this.txbTenLoai.Size = new System.Drawing.Size(304, 37);
            this.txbTenLoai.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbTenLoai.TabIndex = 3;
            this.txbTenLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTenLoai.TextMarginBottom = 0;
            this.txbTenLoai.TextMarginLeft = 3;
            this.txbTenLoai.TextMarginTop = 0;
            this.txbTenLoai.TextPlaceholder = "Enter text";
            this.txbTenLoai.UseSystemPasswordChar = false;
            this.txbTenLoai.WordWrap = true;
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
            this.txbTimKiem.BorderRadius = 15;
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
            this.txbTimKiem.Location = new System.Drawing.Point(742, 80);
            this.txbTimKiem.MaxLength = 32767;
            this.txbTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbTimKiem.Modified = false;
            this.txbTimKiem.Multiline = false;
            this.txbTimKiem.Name = "txbTimKiem";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTimKiem.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbTimKiem.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTimKiem.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTimKiem.OnIdleState = stateProperties12;
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
            this.txbTimKiem.Size = new System.Drawing.Size(293, 37);
            this.txbTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbTimKiem.TabIndex = 3;
            this.txbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTimKiem.TextMarginBottom = 0;
            this.txbTimKiem.TextMarginLeft = 3;
            this.txbTimKiem.TextMarginTop = 0;
            this.txbTimKiem.TextPlaceholder = "Tìm kiếm";
            this.txbTimKiem.UseSystemPasswordChar = false;
            this.txbTimKiem.WordWrap = true;
            this.txbTimKiem.TextChanged += new System.EventHandler(this.txbTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã loại hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên loại hàng";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimkiem.IconColor = System.Drawing.Color.Black;
            this.btnTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimkiem.IconSize = 35;
            this.btnTimkiem.Location = new System.Drawing.Point(1041, 80);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(39, 37);
            this.btnTimkiem.TabIndex = 7;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportExcel.IconColor = System.Drawing.Color.White;
            this.btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportExcel.IconSize = 35;
            this.btnExportExcel.Location = new System.Drawing.Point(916, 44);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(176, 39);
            this.btnExportExcel.TabIndex = 8;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // F_LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 740);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLoaiSanPham);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.txbTenLoai);
            this.Controls.Add(this.txbMaLoai);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_LoaiHang";
            this.Text = "F_LoaiHang";
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txbMaLoai;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemMoi;
        private System.Windows.Forms.DataGridView dgvLoaiSanPham;
        private Bunifu.UI.WinForms.BunifuTextBox txbTenLoai;
        private Bunifu.UI.WinForms.BunifuTextBox txbTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSanPham;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}