namespace StoreManagement.GUI.CustomDialog
{
    partial class Dialog_ThemKhachHang
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_ThemKhachHang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.noticeHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseDialog = new FontAwesome.Sharp.IconButton();
            this.txbHoTen = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txbSoDienThoai = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDiaChi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemMoi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.noticeHeader.SuspendLayout();
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
            this.noticeHeader.Size = new System.Drawing.Size(433, 32);
            this.noticeHeader.TabIndex = 3;
            this.noticeHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm khách hàng mới";
            // 
            // btnCloseDialog
            // 
            this.btnCloseDialog.BackColor = System.Drawing.Color.White;
            this.btnCloseDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseDialog.FlatAppearance.BorderSize = 0;
            this.btnCloseDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDialog.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnCloseDialog.IconColor = System.Drawing.Color.Red;
            this.btnCloseDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseDialog.IconSize = 30;
            this.btnCloseDialog.Location = new System.Drawing.Point(391, 0);
            this.btnCloseDialog.Margin = new System.Windows.Forms.Padding(20);
            this.btnCloseDialog.Name = "btnCloseDialog";
            this.btnCloseDialog.Size = new System.Drawing.Size(42, 32);
            this.btnCloseDialog.TabIndex = 1;
            this.btnCloseDialog.UseVisualStyleBackColor = false;
            this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
            // 
            // txbHoTen
            // 
            this.txbHoTen.AcceptsReturn = false;
            this.txbHoTen.AcceptsTab = false;
            this.txbHoTen.AnimationSpeed = 200;
            this.txbHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.txbHoTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbHoTen.BackgroundImage")));
            this.txbHoTen.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbHoTen.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbHoTen.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbHoTen.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbHoTen.BorderRadius = 30;
            this.txbHoTen.BorderThickness = 1;
            this.txbHoTen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbHoTen.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbHoTen.DefaultText = "";
            this.txbHoTen.FillColor = System.Drawing.Color.White;
            this.txbHoTen.HideSelection = true;
            this.txbHoTen.IconLeft = null;
            this.txbHoTen.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbHoTen.IconPadding = 10;
            this.txbHoTen.IconRight = null;
            this.txbHoTen.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbHoTen.Lines = new string[0];
            this.txbHoTen.Location = new System.Drawing.Point(143, 56);
            this.txbHoTen.MaxLength = 32767;
            this.txbHoTen.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbHoTen.Modified = false;
            this.txbHoTen.Multiline = false;
            this.txbHoTen.Name = "txbHoTen";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbHoTen.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbHoTen.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbHoTen.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbHoTen.OnIdleState = stateProperties24;
            this.txbHoTen.Padding = new System.Windows.Forms.Padding(3);
            this.txbHoTen.PasswordChar = '\0';
            this.txbHoTen.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbHoTen.PlaceholderText = "Tên khách hàng";
            this.txbHoTen.ReadOnly = false;
            this.txbHoTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHoTen.SelectedText = "";
            this.txbHoTen.SelectionLength = 0;
            this.txbHoTen.SelectionStart = 0;
            this.txbHoTen.ShortcutsEnabled = true;
            this.txbHoTen.Size = new System.Drawing.Size(278, 37);
            this.txbHoTen.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbHoTen.TabIndex = 1;
            this.txbHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbHoTen.TextMarginBottom = 0;
            this.txbHoTen.TextMarginLeft = 3;
            this.txbHoTen.TextMarginTop = 0;
            this.txbHoTen.TextPlaceholder = "Tên khách hàng";
            this.txbHoTen.UseSystemPasswordChar = false;
            this.txbHoTen.WordWrap = true;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTen.Location = new System.Drawing.Point(12, 61);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(93, 26);
            this.lbTen.TabIndex = 5;
            this.lbTen.Text = "Họ và tên";
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.AcceptsReturn = false;
            this.txbSoDienThoai.AcceptsTab = false;
            this.txbSoDienThoai.AnimationSpeed = 200;
            this.txbSoDienThoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbSoDienThoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.txbSoDienThoai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbSoDienThoai.BackgroundImage")));
            this.txbSoDienThoai.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbSoDienThoai.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbSoDienThoai.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbSoDienThoai.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbSoDienThoai.BorderRadius = 30;
            this.txbSoDienThoai.BorderThickness = 1;
            this.txbSoDienThoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDienThoai.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbSoDienThoai.DefaultText = "";
            this.txbSoDienThoai.FillColor = System.Drawing.Color.White;
            this.txbSoDienThoai.HideSelection = true;
            this.txbSoDienThoai.IconLeft = null;
            this.txbSoDienThoai.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDienThoai.IconPadding = 10;
            this.txbSoDienThoai.IconRight = null;
            this.txbSoDienThoai.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDienThoai.Lines = new string[0];
            this.txbSoDienThoai.Location = new System.Drawing.Point(143, 99);
            this.txbSoDienThoai.MaxLength = 32767;
            this.txbSoDienThoai.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbSoDienThoai.Modified = false;
            this.txbSoDienThoai.Multiline = false;
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSoDienThoai.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbSoDienThoai.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSoDienThoai.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSoDienThoai.OnIdleState = stateProperties20;
            this.txbSoDienThoai.Padding = new System.Windows.Forms.Padding(3);
            this.txbSoDienThoai.PasswordChar = '\0';
            this.txbSoDienThoai.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSoDienThoai.PlaceholderText = "Số điện thoại";
            this.txbSoDienThoai.ReadOnly = false;
            this.txbSoDienThoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSoDienThoai.SelectedText = "";
            this.txbSoDienThoai.SelectionLength = 0;
            this.txbSoDienThoai.SelectionStart = 0;
            this.txbSoDienThoai.ShortcutsEnabled = true;
            this.txbSoDienThoai.Size = new System.Drawing.Size(278, 37);
            this.txbSoDienThoai.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbSoDienThoai.TabIndex = 2;
            this.txbSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSoDienThoai.TextMarginBottom = 0;
            this.txbSoDienThoai.TextMarginLeft = 3;
            this.txbSoDienThoai.TextMarginTop = 0;
            this.txbSoDienThoai.TextPlaceholder = "Số điện thoại";
            this.txbSoDienThoai.UseSystemPasswordChar = false;
            this.txbSoDienThoai.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.AcceptsReturn = false;
            this.txbDiaChi.AcceptsTab = false;
            this.txbDiaChi.AnimationSpeed = 200;
            this.txbDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.txbDiaChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbDiaChi.BackgroundImage")));
            this.txbDiaChi.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbDiaChi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbDiaChi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbDiaChi.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbDiaChi.BorderRadius = 30;
            this.txbDiaChi.BorderThickness = 1;
            this.txbDiaChi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDiaChi.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbDiaChi.DefaultText = "";
            this.txbDiaChi.FillColor = System.Drawing.Color.White;
            this.txbDiaChi.HideSelection = true;
            this.txbDiaChi.IconLeft = null;
            this.txbDiaChi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDiaChi.IconPadding = 10;
            this.txbDiaChi.IconRight = null;
            this.txbDiaChi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDiaChi.Lines = new string[0];
            this.txbDiaChi.Location = new System.Drawing.Point(143, 143);
            this.txbDiaChi.MaxLength = 32767;
            this.txbDiaChi.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbDiaChi.Modified = false;
            this.txbDiaChi.Multiline = false;
            this.txbDiaChi.Name = "txbDiaChi";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbDiaChi.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbDiaChi.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbDiaChi.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbDiaChi.OnIdleState = stateProperties16;
            this.txbDiaChi.Padding = new System.Windows.Forms.Padding(3);
            this.txbDiaChi.PasswordChar = '\0';
            this.txbDiaChi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbDiaChi.PlaceholderText = "Địa chỉ khách hàng";
            this.txbDiaChi.ReadOnly = false;
            this.txbDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDiaChi.SelectedText = "";
            this.txbDiaChi.SelectionLength = 0;
            this.txbDiaChi.SelectionStart = 0;
            this.txbDiaChi.ShortcutsEnabled = true;
            this.txbDiaChi.Size = new System.Drawing.Size(278, 37);
            this.txbDiaChi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbDiaChi.TabIndex = 3;
            this.txbDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbDiaChi.TextMarginBottom = 0;
            this.txbDiaChi.TextMarginLeft = 3;
            this.txbDiaChi.TextMarginTop = 0;
            this.txbDiaChi.TextPlaceholder = "Địa chỉ khách hàng";
            this.txbDiaChi.UseSystemPasswordChar = false;
            this.txbDiaChi.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
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
            this.btnThemMoi.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.BackgroundImage")));
            this.btnThemMoi.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.ButtonText = "Thêm mới";
            this.btnThemMoi.ButtonTextMarginLeft = 0;
            this.btnThemMoi.ColorContrastOnClick = 45;
            this.btnThemMoi.ColorContrastOnHover = 45;
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnThemMoi.CustomizableEdges = borderEdges2;
            this.btnThemMoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemMoi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemMoi.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemMoi.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemMoi.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemMoi.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemMoi.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThemMoi.IconMarginLeft = 11;
            this.btnThemMoi.IconPadding = 10;
            this.btnThemMoi.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemMoi.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThemMoi.IconSize = 25;
            this.btnThemMoi.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemMoi.IdleBorderRadius = 20;
            this.btnThemMoi.IdleBorderThickness = 1;
            this.btnThemMoi.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemMoi.IdleIconLeftImage = null;
            this.btnThemMoi.IdleIconRightImage = null;
            this.btnThemMoi.IndicateFocus = false;
            this.btnThemMoi.Location = new System.Drawing.Point(159, 224);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemMoi.OnDisabledState.BorderRadius = 20;
            this.btnThemMoi.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.OnDisabledState.BorderThickness = 1;
            this.btnThemMoi.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemMoi.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemMoi.OnDisabledState.IconLeftImage = null;
            this.btnThemMoi.OnDisabledState.IconRightImage = null;
            this.btnThemMoi.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnThemMoi.onHoverState.BorderRadius = 20;
            this.btnThemMoi.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.onHoverState.BorderThickness = 1;
            this.btnThemMoi.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnThemMoi.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.onHoverState.IconLeftImage = null;
            this.btnThemMoi.onHoverState.IconRightImage = null;
            this.btnThemMoi.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemMoi.OnIdleState.BorderRadius = 20;
            this.btnThemMoi.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.OnIdleState.BorderThickness = 1;
            this.btnThemMoi.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemMoi.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemMoi.OnIdleState.IconLeftImage = null;
            this.btnThemMoi.OnIdleState.IconRightImage = null;
            this.btnThemMoi.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemMoi.OnPressedState.BorderRadius = 20;
            this.btnThemMoi.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemMoi.OnPressedState.BorderThickness = 1;
            this.btnThemMoi.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemMoi.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.OnPressedState.IconLeftImage = null;
            this.btnThemMoi.OnPressedState.IconRightImage = null;
            this.btnThemMoi.Size = new System.Drawing.Size(98, 29);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemMoi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemMoi.TextMarginLeft = 0;
            this.btnThemMoi.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThemMoi.UseDefaultRadiusAndThickness = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // Dialog_ThemKhachHang
            // 
            this.AcceptButton = this.btnThemMoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 265);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbSoDienThoai);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.noticeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog_ThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dialog_ThemKhachHang";
            this.Load += new System.EventHandler(this.Dialog_ThemKhachHang_Load);
            this.noticeHeader.ResumeLayout(false);
            this.noticeHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel noticeHeader;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseDialog;
        private Bunifu.UI.WinForms.BunifuTextBox txbHoTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txbSoDienThoai;
        private Bunifu.UI.WinForms.BunifuTextBox txbDiaChi;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemMoi;
    }
}