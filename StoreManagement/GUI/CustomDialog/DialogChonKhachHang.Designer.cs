namespace StoreManagement.GUI.CustomDialog
{
    partial class DialogChonKhachHang
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
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogChonKhachHang));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnCloseDialog = new FontAwesome.Sharp.IconButton();
			this.noticeHeader = new System.Windows.Forms.Panel();
			this.txbTimKiemKh = new Bunifu.UI.WinForms.BunifuTextBox();
			this.btnSearch = new FontAwesome.Sharp.IconButton();
			this.dgvKhachHang = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hangThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.btnThemKhachHang = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.noticeHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Chọn khách hàng";
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
			this.btnCloseDialog.Location = new System.Drawing.Point(662, 0);
			this.btnCloseDialog.Margin = new System.Windows.Forms.Padding(20);
			this.btnCloseDialog.Name = "btnCloseDialog";
			this.btnCloseDialog.Size = new System.Drawing.Size(42, 32);
			this.btnCloseDialog.TabIndex = 1;
			this.btnCloseDialog.UseVisualStyleBackColor = false;
			this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
			// 
			// noticeHeader
			// 
			this.noticeHeader.BackColor = System.Drawing.Color.White;
			this.noticeHeader.Controls.Add(this.label1);
			this.noticeHeader.Controls.Add(this.btnCloseDialog);
			this.noticeHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.noticeHeader.Location = new System.Drawing.Point(0, 0);
			this.noticeHeader.Name = "noticeHeader";
			this.noticeHeader.Size = new System.Drawing.Size(704, 32);
			this.noticeHeader.TabIndex = 2;
			this.noticeHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
			// 
			// txbTimKiemKh
			// 
			this.txbTimKiemKh.AcceptsReturn = false;
			this.txbTimKiemKh.AcceptsTab = false;
			this.txbTimKiemKh.AnimationSpeed = 200;
			this.txbTimKiemKh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbTimKiemKh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbTimKiemKh.BackColor = System.Drawing.Color.Transparent;
			this.txbTimKiemKh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbTimKiemKh.BackgroundImage")));
			this.txbTimKiemKh.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbTimKiemKh.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbTimKiemKh.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbTimKiemKh.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbTimKiemKh.BorderRadius = 20;
			this.txbTimKiemKh.BorderThickness = 1;
			this.txbTimKiemKh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbTimKiemKh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTimKiemKh.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.txbTimKiemKh.DefaultText = "";
			this.txbTimKiemKh.FillColor = System.Drawing.Color.White;
			this.txbTimKiemKh.HideSelection = true;
			this.txbTimKiemKh.IconLeft = null;
			this.txbTimKiemKh.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTimKiemKh.IconPadding = 10;
			this.txbTimKiemKh.IconRight = null;
			this.txbTimKiemKh.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTimKiemKh.Lines = new string[0];
			this.txbTimKiemKh.Location = new System.Drawing.Point(472, 38);
			this.txbTimKiemKh.MaxLength = 32767;
			this.txbTimKiemKh.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbTimKiemKh.Modified = false;
			this.txbTimKiemKh.Multiline = false;
			this.txbTimKiemKh.Name = "txbTimKiemKh";
			stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTimKiemKh.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbTimKiemKh.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTimKiemKh.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Silver;
			stateProperties8.FillColor = System.Drawing.Color.White;
			stateProperties8.ForeColor = System.Drawing.Color.Empty;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbTimKiemKh.OnIdleState = stateProperties8;
			this.txbTimKiemKh.Padding = new System.Windows.Forms.Padding(3);
			this.txbTimKiemKh.PasswordChar = '\0';
			this.txbTimKiemKh.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbTimKiemKh.PlaceholderText = "Tên hoặc sdt khách hàng";
			this.txbTimKiemKh.ReadOnly = false;
			this.txbTimKiemKh.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbTimKiemKh.SelectedText = "";
			this.txbTimKiemKh.SelectionLength = 0;
			this.txbTimKiemKh.SelectionStart = 0;
			this.txbTimKiemKh.ShortcutsEnabled = true;
			this.txbTimKiemKh.Size = new System.Drawing.Size(186, 28);
			this.txbTimKiemKh.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbTimKiemKh.TabIndex = 18;
			this.txbTimKiemKh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbTimKiemKh.TextMarginBottom = 0;
			this.txbTimKiemKh.TextMarginLeft = 3;
			this.txbTimKiemKh.TextMarginTop = 0;
			this.txbTimKiemKh.TextPlaceholder = "Tên hoặc sdt khách hàng";
			this.txbTimKiemKh.UseSystemPasswordChar = false;
			this.txbTimKiemKh.WordWrap = true;
			// 
			// btnSearch
			// 
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnSearch.IconColor = System.Drawing.Color.Black;
			this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSearch.IconSize = 30;
			this.btnSearch.Location = new System.Drawing.Point(653, 38);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(41, 33);
			this.btnSearch.TabIndex = 17;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dgvKhachHang
			// 
			this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.hoten,
            this.sodt,
            this.diemTichLuy,
            this.hangThanhVien,
            this.giamGia});
			this.dgvKhachHang.Location = new System.Drawing.Point(10, 72);
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.RowTemplate.Height = 30;
			this.dgvKhachHang.Size = new System.Drawing.Size(684, 306);
			this.dgvKhachHang.TabIndex = 16;
			this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "Id";
			this.id.FillWeight = 94.78796F;
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			// 
			// hoten
			// 
			this.hoten.HeaderText = "Họ và tên";
			this.hoten.Name = "hoten";
			// 
			// sodt
			// 
			this.sodt.HeaderText = "Số điện thoại";
			this.sodt.Name = "sodt";
			// 
			// diemTichLuy
			// 
			this.diemTichLuy.HeaderText = "Điểm tích lũy";
			this.diemTichLuy.Name = "diemTichLuy";
			// 
			// hangThanhVien
			// 
			this.hangThanhVien.HeaderText = "Hạng thành viên";
			this.hangThanhVien.Name = "hangThanhVien";
			// 
			// giamGia
			// 
			this.giamGia.HeaderText = "Giảm giá";
			this.giamGia.Name = "giamGia";
			// 
			// btnCancel
			// 
			this.btnCancel.AllowAnimations = true;
			this.btnCancel.AllowMouseEffects = true;
			this.btnCancel.AllowToggling = false;
			this.btnCancel.AnimationSpeed = 200;
			this.btnCancel.AutoGenerateColors = false;
			this.btnCancel.AutoRoundBorders = false;
			this.btnCancel.AutoSizeLeftIcon = true;
			this.btnCancel.AutoSizeRightIcon = true;
			this.btnCancel.BackColor = System.Drawing.Color.Transparent;
			this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.ButtonText = "Hủy";
			this.btnCancel.ButtonTextMarginLeft = 0;
			this.btnCancel.ColorContrastOnClick = 45;
			this.btnCancel.ColorContrastOnHover = 45;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges4.BottomLeft = true;
			borderEdges4.BottomRight = true;
			borderEdges4.TopLeft = true;
			borderEdges4.TopRight = true;
			this.btnCancel.CustomizableEdges = borderEdges4;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnCancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnCancel.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnCancel.IconMarginLeft = 11;
			this.btnCancel.IconPadding = 10;
			this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnCancel.IconSize = 25;
			this.btnCancel.IdleBorderColor = System.Drawing.Color.Black;
			this.btnCancel.IdleBorderRadius = 15;
			this.btnCancel.IdleBorderThickness = 1;
			this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnCancel.IdleIconLeftImage = null;
			this.btnCancel.IdleIconRightImage = null;
			this.btnCancel.IndicateFocus = false;
			this.btnCancel.Location = new System.Drawing.Point(584, 384);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnCancel.OnDisabledState.BorderRadius = 15;
			this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.OnDisabledState.BorderThickness = 1;
			this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnCancel.OnDisabledState.IconLeftImage = null;
			this.btnCancel.OnDisabledState.IconRightImage = null;
			this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnCancel.onHoverState.BorderRadius = 15;
			this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.onHoverState.BorderThickness = 1;
			this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnCancel.onHoverState.IconLeftImage = null;
			this.btnCancel.onHoverState.IconRightImage = null;
			this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.Black;
			this.btnCancel.OnIdleState.BorderRadius = 15;
			this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.OnIdleState.BorderThickness = 1;
			this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.OnIdleState.IconLeftImage = null;
			this.btnCancel.OnIdleState.IconRightImage = null;
			this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnCancel.OnPressedState.BorderRadius = 15;
			this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.OnPressedState.BorderThickness = 1;
			this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnCancel.OnPressedState.IconLeftImage = null;
			this.btnCancel.OnPressedState.IconRightImage = null;
			this.btnCancel.Size = new System.Drawing.Size(100, 29);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnCancel.TextMarginLeft = 0;
			this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnCancel.UseDefaultRadiusAndThickness = true;
			// 
			// btnThemKhachHang
			// 
			this.btnThemKhachHang.AllowAnimations = true;
			this.btnThemKhachHang.AllowMouseEffects = true;
			this.btnThemKhachHang.AllowToggling = false;
			this.btnThemKhachHang.AnimationSpeed = 200;
			this.btnThemKhachHang.AutoGenerateColors = false;
			this.btnThemKhachHang.AutoRoundBorders = false;
			this.btnThemKhachHang.AutoSizeLeftIcon = true;
			this.btnThemKhachHang.AutoSizeRightIcon = true;
			this.btnThemKhachHang.BackColor = System.Drawing.Color.Transparent;
			this.btnThemKhachHang.BackColor1 = System.Drawing.Color.DodgerBlue;
			this.btnThemKhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemKhachHang.BackgroundImage")));
			this.btnThemKhachHang.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemKhachHang.ButtonText = "Thêm khách hàng";
			this.btnThemKhachHang.ButtonTextMarginLeft = 0;
			this.btnThemKhachHang.ColorContrastOnClick = 45;
			this.btnThemKhachHang.ColorContrastOnHover = 45;
			this.btnThemKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges3.BottomLeft = true;
			borderEdges3.BottomRight = true;
			borderEdges3.TopLeft = true;
			borderEdges3.TopRight = true;
			this.btnThemKhachHang.CustomizableEdges = borderEdges3;
			this.btnThemKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnThemKhachHang.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThemKhachHang.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThemKhachHang.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThemKhachHang.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnThemKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThemKhachHang.ForeColor = System.Drawing.Color.White;
			this.btnThemKhachHang.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemKhachHang.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnThemKhachHang.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnThemKhachHang.IconMarginLeft = 11;
			this.btnThemKhachHang.IconPadding = 10;
			this.btnThemKhachHang.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemKhachHang.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnThemKhachHang.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnThemKhachHang.IconSize = 25;
			this.btnThemKhachHang.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.btnThemKhachHang.IdleBorderRadius = 20;
			this.btnThemKhachHang.IdleBorderThickness = 1;
			this.btnThemKhachHang.IdleFillColor = System.Drawing.Color.DodgerBlue;
			this.btnThemKhachHang.IdleIconLeftImage = null;
			this.btnThemKhachHang.IdleIconRightImage = null;
			this.btnThemKhachHang.IndicateFocus = false;
			this.btnThemKhachHang.Location = new System.Drawing.Point(10, 37);
			this.btnThemKhachHang.Name = "btnThemKhachHang";
			this.btnThemKhachHang.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThemKhachHang.OnDisabledState.BorderRadius = 20;
			this.btnThemKhachHang.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemKhachHang.OnDisabledState.BorderThickness = 1;
			this.btnThemKhachHang.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThemKhachHang.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThemKhachHang.OnDisabledState.IconLeftImage = null;
			this.btnThemKhachHang.OnDisabledState.IconRightImage = null;
			this.btnThemKhachHang.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThemKhachHang.onHoverState.BorderRadius = 20;
			this.btnThemKhachHang.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemKhachHang.onHoverState.BorderThickness = 1;
			this.btnThemKhachHang.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThemKhachHang.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnThemKhachHang.onHoverState.IconLeftImage = null;
			this.btnThemKhachHang.onHoverState.IconRightImage = null;
			this.btnThemKhachHang.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnThemKhachHang.OnIdleState.BorderRadius = 20;
			this.btnThemKhachHang.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemKhachHang.OnIdleState.BorderThickness = 1;
			this.btnThemKhachHang.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnThemKhachHang.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnThemKhachHang.OnIdleState.IconLeftImage = null;
			this.btnThemKhachHang.OnIdleState.IconRightImage = null;
			this.btnThemKhachHang.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThemKhachHang.OnPressedState.BorderRadius = 20;
			this.btnThemKhachHang.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemKhachHang.OnPressedState.BorderThickness = 1;
			this.btnThemKhachHang.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThemKhachHang.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnThemKhachHang.OnPressedState.IconLeftImage = null;
			this.btnThemKhachHang.OnPressedState.IconRightImage = null;
			this.btnThemKhachHang.Size = new System.Drawing.Size(113, 30);
			this.btnThemKhachHang.TabIndex = 19;
			this.btnThemKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnThemKhachHang.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnThemKhachHang.TextMarginLeft = 0;
			this.btnThemKhachHang.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnThemKhachHang.UseDefaultRadiusAndThickness = true;
			this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
			// 
			// DialogChonKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 421);
			this.Controls.Add(this.btnThemKhachHang);
			this.Controls.Add(this.txbTimKiemKh);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dgvKhachHang);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.noticeHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DialogChonKhachHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DialogChonKhachHang";
			this.noticeHeader.ResumeLayout(false);
			this.noticeHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel noticeHeader;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseDialog;
        private Bunifu.UI.WinForms.BunifuTextBox txbTimKiemKh;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTichLuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemKhachHang;
    }
}