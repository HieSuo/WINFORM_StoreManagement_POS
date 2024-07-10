using BunifuAnimatorNS;
using System.Windows.Media.Media3D;

namespace StoreManagement.GUI.ModuleForm
{
    partial class F_BanHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BanHang));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.panelheader = new System.Windows.Forms.Panel();
			this.btnRefresh = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panelRight = new System.Windows.Forms.Panel();
			this.panelBottomThemSP = new System.Windows.Forms.Panel();
			this.btnThemSPVaoDS = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.numbSoLuongSP = new System.Windows.Forms.NumericUpDown();
			this.txbThongTinSanPham = new Bunifu.UI.WinForms.BunifuTextBox();
			this.panelAllBillAction = new Bunifu.UI.WinForms.BunifuPanel();
			this.panelShowCurrentBIll = new System.Windows.Forms.Panel();
			this.paneltableBill = new System.Windows.Forms.Panel();
			this.dgvCurrentBill = new System.Windows.Forms.DataGridView();
			this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panelThanhTien = new System.Windows.Forms.Panel();
			this.lbTongTien = new System.Windows.Forms.Label();
			this.panelbottom = new System.Windows.Forms.Panel();
			this.btnChonKhachHang = new FontAwesome.Sharp.IconButton();
			this.btnThanhToan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.txbKhachHangDuocChon = new Bunifu.UI.WinForms.BunifuTextBox();
			this.panelTopOfBIll = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnTimKiem = new FontAwesome.Sharp.IconButton();
			this.txbTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
			this.cbLoaiSanPham = new Bunifu.UI.WinForms.BunifuDropdown();
			this.cbCamera = new Bunifu.UI.WinForms.BunifuDropdown();
			this.btnOnCamera = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.panelHangHoa = new Bunifu.UI.WinForms.BunifuPanel();
			this.flowDanhSachSP = new System.Windows.Forms.FlowLayoutPanel();
			this.panelheader.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.panelBottomThemSP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numbSoLuongSP)).BeginInit();
			this.panelAllBillAction.SuspendLayout();
			this.panelShowCurrentBIll.SuspendLayout();
			this.paneltableBill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBill)).BeginInit();
			this.panelThanhTien.SuspendLayout();
			this.panelbottom.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelHangHoa.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelheader
			// 
			this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.panelheader.Controls.Add(this.btnRefresh);
			this.panelheader.Controls.Add(this.label1);
			this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelheader.Location = new System.Drawing.Point(0, 0);
			this.panelheader.Name = "panelheader";
			this.panelheader.Size = new System.Drawing.Size(1092, 40);
			this.panelheader.TabIndex = 1;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
			this.btnRefresh.IconColor = System.Drawing.Color.Black;
			this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnRefresh.IconSize = 35;
			this.btnRefresh.Location = new System.Drawing.Point(1014, 0);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(78, 41);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bán hàng";
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.panelBottomThemSP);
			this.panelRight.Controls.Add(this.panelAllBillAction);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelRight.Location = new System.Drawing.Point(608, 40);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(484, 700);
			this.panelRight.TabIndex = 6;
			// 
			// panelBottomThemSP
			// 
			this.panelBottomThemSP.Controls.Add(this.btnThemSPVaoDS);
			this.panelBottomThemSP.Controls.Add(this.numbSoLuongSP);
			this.panelBottomThemSP.Controls.Add(this.txbThongTinSanPham);
			this.panelBottomThemSP.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBottomThemSP.Location = new System.Drawing.Point(0, 0);
			this.panelBottomThemSP.Name = "panelBottomThemSP";
			this.panelBottomThemSP.Size = new System.Drawing.Size(484, 57);
			this.panelBottomThemSP.TabIndex = 7;
			// 
			// btnThemSPVaoDS
			// 
			this.btnThemSPVaoDS.AllowAnimations = true;
			this.btnThemSPVaoDS.AllowMouseEffects = true;
			this.btnThemSPVaoDS.AllowToggling = false;
			this.btnThemSPVaoDS.AnimationSpeed = 200;
			this.btnThemSPVaoDS.AutoGenerateColors = false;
			this.btnThemSPVaoDS.AutoRoundBorders = false;
			this.btnThemSPVaoDS.AutoSizeLeftIcon = true;
			this.btnThemSPVaoDS.AutoSizeRightIcon = true;
			this.btnThemSPVaoDS.BackColor = System.Drawing.Color.Transparent;
			this.btnThemSPVaoDS.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnThemSPVaoDS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemSPVaoDS.BackgroundImage")));
			this.btnThemSPVaoDS.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemSPVaoDS.ButtonText = "Thêm hàng";
			this.btnThemSPVaoDS.ButtonTextMarginLeft = 0;
			this.btnThemSPVaoDS.ColorContrastOnClick = 45;
			this.btnThemSPVaoDS.ColorContrastOnHover = 45;
			this.btnThemSPVaoDS.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.btnThemSPVaoDS.CustomizableEdges = borderEdges1;
			this.btnThemSPVaoDS.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnThemSPVaoDS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThemSPVaoDS.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThemSPVaoDS.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThemSPVaoDS.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnThemSPVaoDS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThemSPVaoDS.ForeColor = System.Drawing.Color.Black;
			this.btnThemSPVaoDS.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemSPVaoDS.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnThemSPVaoDS.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnThemSPVaoDS.IconMarginLeft = 11;
			this.btnThemSPVaoDS.IconPadding = 10;
			this.btnThemSPVaoDS.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemSPVaoDS.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnThemSPVaoDS.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnThemSPVaoDS.IconSize = 25;
			this.btnThemSPVaoDS.IdleBorderColor = System.Drawing.Color.Black;
			this.btnThemSPVaoDS.IdleBorderRadius = 10;
			this.btnThemSPVaoDS.IdleBorderThickness = 1;
			this.btnThemSPVaoDS.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnThemSPVaoDS.IdleIconLeftImage = null;
			this.btnThemSPVaoDS.IdleIconRightImage = null;
			this.btnThemSPVaoDS.IndicateFocus = false;
			this.btnThemSPVaoDS.Location = new System.Drawing.Point(382, 7);
			this.btnThemSPVaoDS.Name = "btnThemSPVaoDS";
			this.btnThemSPVaoDS.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThemSPVaoDS.OnDisabledState.BorderRadius = 10;
			this.btnThemSPVaoDS.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemSPVaoDS.OnDisabledState.BorderThickness = 1;
			this.btnThemSPVaoDS.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThemSPVaoDS.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThemSPVaoDS.OnDisabledState.IconLeftImage = null;
			this.btnThemSPVaoDS.OnDisabledState.IconRightImage = null;
			this.btnThemSPVaoDS.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThemSPVaoDS.onHoverState.BorderRadius = 10;
			this.btnThemSPVaoDS.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemSPVaoDS.onHoverState.BorderThickness = 1;
			this.btnThemSPVaoDS.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThemSPVaoDS.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnThemSPVaoDS.onHoverState.IconLeftImage = null;
			this.btnThemSPVaoDS.onHoverState.IconRightImage = null;
			this.btnThemSPVaoDS.OnIdleState.BorderColor = System.Drawing.Color.Black;
			this.btnThemSPVaoDS.OnIdleState.BorderRadius = 10;
			this.btnThemSPVaoDS.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemSPVaoDS.OnIdleState.BorderThickness = 1;
			this.btnThemSPVaoDS.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnThemSPVaoDS.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.btnThemSPVaoDS.OnIdleState.IconLeftImage = null;
			this.btnThemSPVaoDS.OnIdleState.IconRightImage = null;
			this.btnThemSPVaoDS.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThemSPVaoDS.OnPressedState.BorderRadius = 10;
			this.btnThemSPVaoDS.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThemSPVaoDS.OnPressedState.BorderThickness = 1;
			this.btnThemSPVaoDS.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThemSPVaoDS.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnThemSPVaoDS.OnPressedState.IconLeftImage = null;
			this.btnThemSPVaoDS.OnPressedState.IconRightImage = null;
			this.btnThemSPVaoDS.Size = new System.Drawing.Size(99, 37);
			this.btnThemSPVaoDS.TabIndex = 11;
			this.btnThemSPVaoDS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnThemSPVaoDS.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnThemSPVaoDS.TextMarginLeft = 0;
			this.btnThemSPVaoDS.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnThemSPVaoDS.UseDefaultRadiusAndThickness = true;
			this.btnThemSPVaoDS.Click += new System.EventHandler(this.btnThemSPVaoDS_Click);
			// 
			// numbSoLuongSP
			// 
			this.numbSoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.numbSoLuongSP.Location = new System.Drawing.Point(322, 13);
			this.numbSoLuongSP.Name = "numbSoLuongSP";
			this.numbSoLuongSP.Size = new System.Drawing.Size(54, 26);
			this.numbSoLuongSP.TabIndex = 10;
			// 
			// txbThongTinSanPham
			// 
			this.txbThongTinSanPham.AcceptsReturn = false;
			this.txbThongTinSanPham.AcceptsTab = false;
			this.txbThongTinSanPham.AnimationSpeed = 200;
			this.txbThongTinSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbThongTinSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbThongTinSanPham.BackColor = System.Drawing.Color.Transparent;
			this.txbThongTinSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbThongTinSanPham.BackgroundImage")));
			this.txbThongTinSanPham.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbThongTinSanPham.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbThongTinSanPham.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbThongTinSanPham.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbThongTinSanPham.BorderRadius = 20;
			this.txbThongTinSanPham.BorderThickness = 1;
			this.txbThongTinSanPham.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbThongTinSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbThongTinSanPham.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.txbThongTinSanPham.DefaultText = "";
			this.txbThongTinSanPham.FillColor = System.Drawing.Color.White;
			this.txbThongTinSanPham.HideSelection = true;
			this.txbThongTinSanPham.IconLeft = null;
			this.txbThongTinSanPham.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbThongTinSanPham.IconPadding = 10;
			this.txbThongTinSanPham.IconRight = null;
			this.txbThongTinSanPham.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbThongTinSanPham.Lines = new string[0];
			this.txbThongTinSanPham.Location = new System.Drawing.Point(16, 7);
			this.txbThongTinSanPham.MaxLength = 32767;
			this.txbThongTinSanPham.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbThongTinSanPham.Modified = false;
			this.txbThongTinSanPham.Multiline = false;
			this.txbThongTinSanPham.Name = "txbThongTinSanPham";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbThongTinSanPham.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbThongTinSanPham.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbThongTinSanPham.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbThongTinSanPham.OnIdleState = stateProperties4;
			this.txbThongTinSanPham.Padding = new System.Windows.Forms.Padding(3);
			this.txbThongTinSanPham.PasswordChar = '\0';
			this.txbThongTinSanPham.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbThongTinSanPham.PlaceholderText = "Tên sản phẩm";
			this.txbThongTinSanPham.ReadOnly = true;
			this.txbThongTinSanPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbThongTinSanPham.SelectedText = "";
			this.txbThongTinSanPham.SelectionLength = 0;
			this.txbThongTinSanPham.SelectionStart = 0;
			this.txbThongTinSanPham.ShortcutsEnabled = true;
			this.txbThongTinSanPham.Size = new System.Drawing.Size(272, 32);
			this.txbThongTinSanPham.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbThongTinSanPham.TabIndex = 9;
			this.txbThongTinSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbThongTinSanPham.TextMarginBottom = 0;
			this.txbThongTinSanPham.TextMarginLeft = 3;
			this.txbThongTinSanPham.TextMarginTop = 0;
			this.txbThongTinSanPham.TextPlaceholder = "Tên sản phẩm";
			this.txbThongTinSanPham.UseSystemPasswordChar = false;
			this.txbThongTinSanPham.WordWrap = true;
			// 
			// panelAllBillAction
			// 
			this.panelAllBillAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelAllBillAction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.panelAllBillAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAllBillAction.BackgroundImage")));
			this.panelAllBillAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelAllBillAction.BorderColor = System.Drawing.Color.Transparent;
			this.panelAllBillAction.BorderRadius = 20;
			this.panelAllBillAction.BorderThickness = 1;
			this.panelAllBillAction.Controls.Add(this.panelShowCurrentBIll);
			this.panelAllBillAction.Controls.Add(this.panelbottom);
			this.panelAllBillAction.Controls.Add(this.panelTopOfBIll);
			this.panelAllBillAction.Location = new System.Drawing.Point(16, 63);
			this.panelAllBillAction.Name = "panelAllBillAction";
			this.panelAllBillAction.ShowBorders = true;
			this.panelAllBillAction.Size = new System.Drawing.Size(456, 625);
			this.panelAllBillAction.TabIndex = 6;
			// 
			// panelShowCurrentBIll
			// 
			this.panelShowCurrentBIll.AutoScroll = true;
			this.panelShowCurrentBIll.BackColor = System.Drawing.Color.Transparent;
			this.panelShowCurrentBIll.Controls.Add(this.paneltableBill);
			this.panelShowCurrentBIll.Controls.Add(this.panelThanhTien);
			this.panelShowCurrentBIll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelShowCurrentBIll.Location = new System.Drawing.Point(0, 26);
			this.panelShowCurrentBIll.Name = "panelShowCurrentBIll";
			this.panelShowCurrentBIll.Size = new System.Drawing.Size(456, 524);
			this.panelShowCurrentBIll.TabIndex = 6;
			// 
			// paneltableBill
			// 
			this.paneltableBill.AutoScroll = true;
			this.paneltableBill.Controls.Add(this.dgvCurrentBill);
			this.paneltableBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paneltableBill.Location = new System.Drawing.Point(0, 0);
			this.paneltableBill.Name = "paneltableBill";
			this.paneltableBill.Size = new System.Drawing.Size(456, 485);
			this.paneltableBill.TabIndex = 2;
			// 
			// dgvCurrentBill
			// 
			this.dgvCurrentBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCurrentBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCurrentBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCurrentBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCurrentBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.tenSP,
            this.donGia,
            this.soLuong,
            this.thanhTien,
            this.delete});
			this.dgvCurrentBill.Location = new System.Drawing.Point(3, 3);
			this.dgvCurrentBill.Name = "dgvCurrentBill";
			this.dgvCurrentBill.Size = new System.Drawing.Size(449, 479);
			this.dgvCurrentBill.TabIndex = 1;
			this.dgvCurrentBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentBill_CellContentClick);
			// 
			// MaSP
			// 
			this.MaSP.DataPropertyName = "maSanPham";
			this.MaSP.FillWeight = 100.2421F;
			this.MaSP.HeaderText = "MSP";
			this.MaSP.Name = "MaSP";
			// 
			// tenSP
			// 
			this.tenSP.DataPropertyName = "tenSanPham";
			this.tenSP.FillWeight = 100.2051F;
			this.tenSP.HeaderText = "Tên Sản Phẩm";
			this.tenSP.Name = "tenSP";
			// 
			// donGia
			// 
			this.donGia.DataPropertyName = "giaBan";
			this.donGia.FillWeight = 100.1743F;
			this.donGia.HeaderText = "Đơn giá";
			this.donGia.Name = "donGia";
			// 
			// soLuong
			// 
			this.soLuong.DataPropertyName = "soLuong";
			this.soLuong.FillWeight = 98.69723F;
			this.soLuong.HeaderText = "Số lượng";
			this.soLuong.Name = "soLuong";
			// 
			// thanhTien
			// 
			this.thanhTien.DataPropertyName = "thanhTien";
			this.thanhTien.FillWeight = 100.3698F;
			this.thanhTien.HeaderText = "Thành tiền";
			this.thanhTien.Name = "thanhTien";
			// 
			// delete
			// 
			this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.delete.DataPropertyName = "delete";
			this.delete.FillWeight = 100.3115F;
			this.delete.HeaderText = "Action";
			this.delete.Name = "delete";
			this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.delete.Text = "Xóa";
			this.delete.UseColumnTextForButtonValue = true;
			this.delete.Width = 40;
			// 
			// panelThanhTien
			// 
			this.panelThanhTien.BackColor = System.Drawing.Color.Transparent;
			this.panelThanhTien.Controls.Add(this.lbTongTien);
			this.panelThanhTien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelThanhTien.Location = new System.Drawing.Point(0, 485);
			this.panelThanhTien.Name = "panelThanhTien";
			this.panelThanhTien.Size = new System.Drawing.Size(456, 39);
			this.panelThanhTien.TabIndex = 0;
			// 
			// lbTongTien
			// 
			this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTongTien.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTongTien.Location = new System.Drawing.Point(3, 3);
			this.lbTongTien.Name = "lbTongTien";
			this.lbTongTien.Size = new System.Drawing.Size(450, 33);
			this.lbTongTien.TabIndex = 0;
			this.lbTongTien.Text = "Thành tiền: 0";
			this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panelbottom
			// 
			this.panelbottom.BackColor = System.Drawing.Color.Transparent;
			this.panelbottom.Controls.Add(this.btnChonKhachHang);
			this.panelbottom.Controls.Add(this.btnThanhToan);
			this.panelbottom.Controls.Add(this.txbKhachHangDuocChon);
			this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelbottom.Location = new System.Drawing.Point(0, 550);
			this.panelbottom.Name = "panelbottom";
			this.panelbottom.Size = new System.Drawing.Size(456, 75);
			this.panelbottom.TabIndex = 5;
			// 
			// btnChonKhachHang
			// 
			this.btnChonKhachHang.BackColor = System.Drawing.Color.White;
			this.btnChonKhachHang.FlatAppearance.BorderSize = 0;
			this.btnChonKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChonKhachHang.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder;
			this.btnChonKhachHang.IconColor = System.Drawing.Color.Black;
			this.btnChonKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnChonKhachHang.IconSize = 35;
			this.btnChonKhachHang.Location = new System.Drawing.Point(246, 32);
			this.btnChonKhachHang.Name = "btnChonKhachHang";
			this.btnChonKhachHang.Size = new System.Drawing.Size(34, 24);
			this.btnChonKhachHang.TabIndex = 10;
			this.btnChonKhachHang.UseVisualStyleBackColor = false;
			this.btnChonKhachHang.Click += new System.EventHandler(this.btnChonKhachHang_Click);
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.AllowAnimations = true;
			this.btnThanhToan.AllowMouseEffects = true;
			this.btnThanhToan.AllowToggling = false;
			this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThanhToan.AnimationSpeed = 200;
			this.btnThanhToan.AutoGenerateColors = false;
			this.btnThanhToan.AutoRoundBorders = false;
			this.btnThanhToan.AutoSizeLeftIcon = true;
			this.btnThanhToan.AutoSizeRightIcon = true;
			this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
			this.btnThanhToan.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(37)))), ((int)(((byte)(100)))));
			this.btnThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.BackgroundImage")));
			this.btnThanhToan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.ButtonText = "Thanh toán";
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
			this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThanhToan.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThanhToan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnThanhToan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnThanhToan.IconMarginLeft = 11;
			this.btnThanhToan.IconPadding = 10;
			this.btnThanhToan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThanhToan.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnThanhToan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnThanhToan.IconSize = 25;
			this.btnThanhToan.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(37)))), ((int)(((byte)(100)))));
			this.btnThanhToan.IdleBorderRadius = 15;
			this.btnThanhToan.IdleBorderThickness = 1;
			this.btnThanhToan.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(37)))), ((int)(((byte)(100)))));
			this.btnThanhToan.IdleIconLeftImage = null;
			this.btnThanhToan.IdleIconRightImage = null;
			this.btnThanhToan.IndicateFocus = false;
			this.btnThanhToan.Location = new System.Drawing.Point(333, 27);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnThanhToan.OnDisabledState.BorderRadius = 15;
			this.btnThanhToan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.OnDisabledState.BorderThickness = 1;
			this.btnThanhToan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnThanhToan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnThanhToan.OnDisabledState.IconLeftImage = null;
			this.btnThanhToan.OnDisabledState.IconRightImage = null;
			this.btnThanhToan.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThanhToan.onHoverState.BorderRadius = 15;
			this.btnThanhToan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.onHoverState.BorderThickness = 1;
			this.btnThanhToan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnThanhToan.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.onHoverState.IconLeftImage = null;
			this.btnThanhToan.onHoverState.IconRightImage = null;
			this.btnThanhToan.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(37)))), ((int)(((byte)(100)))));
			this.btnThanhToan.OnIdleState.BorderRadius = 15;
			this.btnThanhToan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.OnIdleState.BorderThickness = 1;
			this.btnThanhToan.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(37)))), ((int)(((byte)(100)))));
			this.btnThanhToan.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.OnIdleState.IconLeftImage = null;
			this.btnThanhToan.OnIdleState.IconRightImage = null;
			this.btnThanhToan.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThanhToan.OnPressedState.BorderRadius = 15;
			this.btnThanhToan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnThanhToan.OnPressedState.BorderThickness = 1;
			this.btnThanhToan.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnThanhToan.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.OnPressedState.IconLeftImage = null;
			this.btnThanhToan.OnPressedState.IconRightImage = null;
			this.btnThanhToan.Size = new System.Drawing.Size(110, 33);
			this.btnThanhToan.TabIndex = 4;
			this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnThanhToan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnThanhToan.TextMarginLeft = 0;
			this.btnThanhToan.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnThanhToan.UseDefaultRadiusAndThickness = true;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// txbKhachHangDuocChon
			// 
			this.txbKhachHangDuocChon.AcceptsReturn = false;
			this.txbKhachHangDuocChon.AcceptsTab = false;
			this.txbKhachHangDuocChon.AnimationSpeed = 200;
			this.txbKhachHangDuocChon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txbKhachHangDuocChon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txbKhachHangDuocChon.BackColor = System.Drawing.Color.White;
			this.txbKhachHangDuocChon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbKhachHangDuocChon.BackgroundImage")));
			this.txbKhachHangDuocChon.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txbKhachHangDuocChon.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txbKhachHangDuocChon.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txbKhachHangDuocChon.BorderColorIdle = System.Drawing.Color.Silver;
			this.txbKhachHangDuocChon.BorderRadius = 20;
			this.txbKhachHangDuocChon.BorderThickness = 1;
			this.txbKhachHangDuocChon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbKhachHangDuocChon.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbKhachHangDuocChon.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.txbKhachHangDuocChon.DefaultText = "";
			this.txbKhachHangDuocChon.FillColor = System.Drawing.Color.White;
			this.txbKhachHangDuocChon.HideSelection = true;
			this.txbKhachHangDuocChon.IconLeft = null;
			this.txbKhachHangDuocChon.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbKhachHangDuocChon.IconPadding = 10;
			this.txbKhachHangDuocChon.IconRight = null;
			this.txbKhachHangDuocChon.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txbKhachHangDuocChon.Lines = new string[0];
			this.txbKhachHangDuocChon.Location = new System.Drawing.Point(8, 27);
			this.txbKhachHangDuocChon.MaxLength = 32767;
			this.txbKhachHangDuocChon.MinimumSize = new System.Drawing.Size(1, 1);
			this.txbKhachHangDuocChon.Modified = false;
			this.txbKhachHangDuocChon.Multiline = false;
			this.txbKhachHangDuocChon.Name = "txbKhachHangDuocChon";
			stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbKhachHangDuocChon.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txbKhachHangDuocChon.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbKhachHangDuocChon.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Silver;
			stateProperties8.FillColor = System.Drawing.Color.White;
			stateProperties8.ForeColor = System.Drawing.Color.Empty;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txbKhachHangDuocChon.OnIdleState = stateProperties8;
			this.txbKhachHangDuocChon.Padding = new System.Windows.Forms.Padding(3);
			this.txbKhachHangDuocChon.PasswordChar = '\0';
			this.txbKhachHangDuocChon.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txbKhachHangDuocChon.PlaceholderText = "Chọn khách hàng";
			this.txbKhachHangDuocChon.ReadOnly = true;
			this.txbKhachHangDuocChon.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbKhachHangDuocChon.SelectedText = "";
			this.txbKhachHangDuocChon.SelectionLength = 0;
			this.txbKhachHangDuocChon.SelectionStart = 0;
			this.txbKhachHangDuocChon.ShortcutsEnabled = true;
			this.txbKhachHangDuocChon.Size = new System.Drawing.Size(277, 32);
			this.txbKhachHangDuocChon.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbKhachHangDuocChon.TabIndex = 9;
			this.txbKhachHangDuocChon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbKhachHangDuocChon.TextMarginBottom = 0;
			this.txbKhachHangDuocChon.TextMarginLeft = 3;
			this.txbKhachHangDuocChon.TextMarginTop = 0;
			this.txbKhachHangDuocChon.TextPlaceholder = "Chọn khách hàng";
			this.txbKhachHangDuocChon.UseSystemPasswordChar = false;
			this.txbKhachHangDuocChon.WordWrap = true;
			// 
			// panelTopOfBIll
			// 
			this.panelTopOfBIll.BackColor = System.Drawing.Color.Transparent;
			this.panelTopOfBIll.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopOfBIll.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.panelTopOfBIll.Location = new System.Drawing.Point(0, 0);
			this.panelTopOfBIll.Name = "panelTopOfBIll";
			this.panelTopOfBIll.Size = new System.Drawing.Size(456, 26);
			this.panelTopOfBIll.TabIndex = 0;
			this.panelTopOfBIll.Text = "Giỏ hàng";
			this.panelTopOfBIll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btnTimKiem);
			this.panel1.Controls.Add(this.txbTimKiem);
			this.panel1.Controls.Add(this.cbLoaiSanPham);
			this.panel1.Controls.Add(this.cbCamera);
			this.panel1.Controls.Add(this.btnOnCamera);
			this.panel1.Controls.Add(this.panelHangHoa);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(608, 700);
			this.panel1.TabIndex = 7;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.White;
			this.btnTimKiem.FlatAppearance.BorderSize = 0;
			this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.btnTimKiem.IconColor = System.Drawing.Color.Black;
			this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnTimKiem.IconSize = 30;
			this.btnTimKiem.Location = new System.Drawing.Point(254, 54);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(28, 28);
			this.btnTimKiem.TabIndex = 10;
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txbTimKiem
			// 
			this.txbTimKiem.AcceptsReturn = false;
			this.txbTimKiem.AcceptsTab = false;
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
			this.txbTimKiem.Location = new System.Drawing.Point(9, 49);
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
			this.txbTimKiem.PlaceholderText = "Tìm kiếm ";
			this.txbTimKiem.ReadOnly = false;
			this.txbTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txbTimKiem.SelectedText = "";
			this.txbTimKiem.SelectionLength = 0;
			this.txbTimKiem.SelectionStart = 0;
			this.txbTimKiem.ShortcutsEnabled = true;
			this.txbTimKiem.Size = new System.Drawing.Size(283, 37);
			this.txbTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txbTimKiem.TabIndex = 9;
			this.txbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txbTimKiem.TextMarginBottom = 0;
			this.txbTimKiem.TextMarginLeft = 3;
			this.txbTimKiem.TextMarginTop = 0;
			this.txbTimKiem.TextPlaceholder = "Tìm kiếm ";
			this.txbTimKiem.UseSystemPasswordChar = false;
			this.txbTimKiem.WordWrap = true;
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
			this.cbLoaiSanPham.Location = new System.Drawing.Point(12, 11);
			this.cbLoaiSanPham.Name = "cbLoaiSanPham";
			this.cbLoaiSanPham.Size = new System.Drawing.Size(280, 32);
			this.cbLoaiSanPham.TabIndex = 6;
			this.cbLoaiSanPham.Text = null;
			this.cbLoaiSanPham.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbLoaiSanPham.TextLeftMargin = 5;
			this.cbLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSanPham_SelectedIndexChanged);
			// 
			// cbCamera
			// 
			this.cbCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCamera.BackColor = System.Drawing.Color.Transparent;
			this.cbCamera.BackgroundColor = System.Drawing.Color.White;
			this.cbCamera.BorderColor = System.Drawing.Color.Silver;
			this.cbCamera.BorderRadius = 17;
			this.cbCamera.Color = System.Drawing.Color.Silver;
			this.cbCamera.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbCamera.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbCamera.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.cbCamera.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbCamera.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.cbCamera.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.cbCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbCamera.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCamera.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbCamera.FillDropDown = true;
			this.cbCamera.FillIndicator = false;
			this.cbCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCamera.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbCamera.ForeColor = System.Drawing.Color.Black;
			this.cbCamera.FormattingEnabled = true;
			this.cbCamera.Icon = null;
			this.cbCamera.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbCamera.IndicatorColor = System.Drawing.Color.Gray;
			this.cbCamera.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbCamera.ItemBackColor = System.Drawing.Color.White;
			this.cbCamera.ItemBorderColor = System.Drawing.Color.White;
			this.cbCamera.ItemForeColor = System.Drawing.Color.Black;
			this.cbCamera.ItemHeight = 26;
			this.cbCamera.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.cbCamera.ItemHighLightForeColor = System.Drawing.Color.White;
			this.cbCamera.ItemTopMargin = 3;
			this.cbCamera.Location = new System.Drawing.Point(421, 11);
			this.cbCamera.Name = "cbCamera";
			this.cbCamera.Size = new System.Drawing.Size(181, 32);
			this.cbCamera.TabIndex = 6;
			this.cbCamera.Text = null;
			this.cbCamera.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbCamera.TextLeftMargin = 5;
			// 
			// btnOnCamera
			// 
			this.btnOnCamera.AllowAnimations = true;
			this.btnOnCamera.AllowMouseEffects = true;
			this.btnOnCamera.AllowToggling = false;
			this.btnOnCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOnCamera.AnimationSpeed = 200;
			this.btnOnCamera.AutoGenerateColors = false;
			this.btnOnCamera.AutoRoundBorders = false;
			this.btnOnCamera.AutoSizeLeftIcon = true;
			this.btnOnCamera.AutoSizeRightIcon = true;
			this.btnOnCamera.BackColor = System.Drawing.Color.Transparent;
			this.btnOnCamera.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnOnCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnCamera.BackgroundImage")));
			this.btnOnCamera.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOnCamera.ButtonText = "Bật camera";
			this.btnOnCamera.ButtonTextMarginLeft = 0;
			this.btnOnCamera.ColorContrastOnClick = 45;
			this.btnOnCamera.ColorContrastOnHover = 45;
			this.btnOnCamera.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges3.BottomLeft = true;
			borderEdges3.BottomRight = true;
			borderEdges3.TopLeft = true;
			borderEdges3.TopRight = true;
			this.btnOnCamera.CustomizableEdges = borderEdges3;
			this.btnOnCamera.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnOnCamera.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnOnCamera.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnOnCamera.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnOnCamera.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnOnCamera.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnOnCamera.ForeColor = System.Drawing.Color.Black;
			this.btnOnCamera.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOnCamera.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnOnCamera.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnOnCamera.IconMarginLeft = 11;
			this.btnOnCamera.IconPadding = 10;
			this.btnOnCamera.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOnCamera.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnOnCamera.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnOnCamera.IconSize = 25;
			this.btnOnCamera.IdleBorderColor = System.Drawing.Color.Black;
			this.btnOnCamera.IdleBorderRadius = 10;
			this.btnOnCamera.IdleBorderThickness = 1;
			this.btnOnCamera.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnOnCamera.IdleIconLeftImage = null;
			this.btnOnCamera.IdleIconRightImage = null;
			this.btnOnCamera.IndicateFocus = false;
			this.btnOnCamera.Location = new System.Drawing.Point(492, 55);
			this.btnOnCamera.Name = "btnOnCamera";
			this.btnOnCamera.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnOnCamera.OnDisabledState.BorderRadius = 10;
			this.btnOnCamera.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOnCamera.OnDisabledState.BorderThickness = 1;
			this.btnOnCamera.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnOnCamera.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnOnCamera.OnDisabledState.IconLeftImage = null;
			this.btnOnCamera.OnDisabledState.IconRightImage = null;
			this.btnOnCamera.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnOnCamera.onHoverState.BorderRadius = 10;
			this.btnOnCamera.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOnCamera.onHoverState.BorderThickness = 1;
			this.btnOnCamera.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnOnCamera.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnOnCamera.onHoverState.IconLeftImage = null;
			this.btnOnCamera.onHoverState.IconRightImage = null;
			this.btnOnCamera.OnIdleState.BorderColor = System.Drawing.Color.Black;
			this.btnOnCamera.OnIdleState.BorderRadius = 10;
			this.btnOnCamera.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOnCamera.OnIdleState.BorderThickness = 1;
			this.btnOnCamera.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
			this.btnOnCamera.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.btnOnCamera.OnIdleState.IconLeftImage = null;
			this.btnOnCamera.OnIdleState.IconRightImage = null;
			this.btnOnCamera.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnOnCamera.OnPressedState.BorderRadius = 10;
			this.btnOnCamera.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOnCamera.OnPressedState.BorderThickness = 1;
			this.btnOnCamera.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnOnCamera.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnOnCamera.OnPressedState.IconLeftImage = null;
			this.btnOnCamera.OnPressedState.IconRightImage = null;
			this.btnOnCamera.Size = new System.Drawing.Size(110, 33);
			this.btnOnCamera.TabIndex = 8;
			this.btnOnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnOnCamera.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnOnCamera.TextMarginLeft = 0;
			this.btnOnCamera.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnOnCamera.UseDefaultRadiusAndThickness = true;
			this.btnOnCamera.Click += new System.EventHandler(this.btnOnCamera_Click);
			// 
			// panelHangHoa
			// 
			this.panelHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelHangHoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.panelHangHoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHangHoa.BackgroundImage")));
			this.panelHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelHangHoa.BorderColor = System.Drawing.Color.Transparent;
			this.panelHangHoa.BorderRadius = 20;
			this.panelHangHoa.BorderThickness = 1;
			this.panelHangHoa.Controls.Add(this.flowDanhSachSP);
			this.panelHangHoa.Location = new System.Drawing.Point(9, 111);
			this.panelHangHoa.Name = "panelHangHoa";
			this.panelHangHoa.ShowBorders = true;
			this.panelHangHoa.Size = new System.Drawing.Size(590, 573);
			this.panelHangHoa.TabIndex = 7;
			// 
			// flowDanhSachSP
			// 
			this.flowDanhSachSP.AutoScroll = true;
			this.flowDanhSachSP.BackColor = System.Drawing.Color.Transparent;
			this.flowDanhSachSP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowDanhSachSP.Location = new System.Drawing.Point(0, 0);
			this.flowDanhSachSP.Name = "flowDanhSachSP";
			this.flowDanhSachSP.Size = new System.Drawing.Size(590, 573);
			this.flowDanhSachSP.TabIndex = 0;
			// 
			// F_BanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 740);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelheader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "F_BanHang";
			this.Text = "F_BanHang";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_BanHang_FormClosing);
			this.panelheader.ResumeLayout(false);
			this.panelheader.PerformLayout();
			this.panelRight.ResumeLayout(false);
			this.panelBottomThemSP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numbSoLuongSP)).EndInit();
			this.panelAllBillAction.ResumeLayout(false);
			this.panelShowCurrentBIll.ResumeLayout(false);
			this.paneltableBill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBill)).EndInit();
			this.panelThanhTien.ResumeLayout(false);
			this.panelbottom.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panelHangHoa.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRight;
        private Bunifu.UI.WinForms.BunifuPanel panelAllBillAction;
        private System.Windows.Forms.Panel panelbottom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThanhToan;
        private System.Windows.Forms.Label panelTopOfBIll;
        private System.Windows.Forms.Panel panelShowCurrentBIll;
        private System.Windows.Forms.Panel panelThanhTien;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DataGridView dgvCurrentBill;
        private System.Windows.Forms.Panel panelBottomThemSP;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemSPVaoDS;
        private System.Windows.Forms.NumericUpDown numbSoLuongSP;
        private Bunifu.UI.WinForms.BunifuTextBox txbThongTinSanPham;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox txbTimKiem;
        private Bunifu.UI.WinForms.BunifuDropdown cbCamera;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOnCamera;
        private Bunifu.UI.WinForms.BunifuPanel panelHangHoa;
        private System.Windows.Forms.FlowLayoutPanel flowDanhSachSP;
        private System.Windows.Forms.Panel paneltableBill;
        private Bunifu.UI.WinForms.BunifuDropdown cbLoaiSanPham;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private Bunifu.UI.WinForms.BunifuTextBox txbKhachHangDuocChon;
        private FontAwesome.Sharp.IconButton btnChonKhachHang;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}