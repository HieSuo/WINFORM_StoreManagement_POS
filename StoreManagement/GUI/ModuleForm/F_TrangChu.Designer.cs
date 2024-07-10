namespace StoreManagement.GUI.ModuleForm
{
    partial class F_TrangChu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TrangChu));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXem = new FontAwesome.Sharp.IconButton();
			this.label8 = new System.Windows.Forms.Label();
			this.dpkDayTo = new Bunifu.UI.WinForms.BunifuDatePicker();
			this.dpkDayFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.pnDashBoardContent = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.dgvThongSoSanPham = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panelBieuDoDoanhThu = new System.Windows.Forms.Panel();
			this.chartThongKe = new LiveCharts.WinForms.CartesianChart();
			this.panelTopBieuDo = new System.Windows.Forms.Panel();
			this.cbChonThoiGian = new Bunifu.UI.WinForms.BunifuDropdown();
			this.label4 = new System.Windows.Forms.Label();
			this.panelPieChart = new System.Windows.Forms.Panel();
			this.cbThiPhan = new Bunifu.UI.WinForms.BunifuDropdown();
			this.panelConPie = new System.Windows.Forms.Panel();
			this.chartThiPhan = new LiveCharts.WinForms.PieChart();
			this.label9 = new System.Windows.Forms.Label();
			this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbSoLuonSP = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbTongChi = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbTongThu = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.pnDashBoardContent.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThongSoSanPham)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelBieuDoDoanhThu.SuspendLayout();
			this.panelTopBieuDo.SuspendLayout();
			this.panelPieChart.SuspendLayout();
			this.panelConPie.SuspendLayout();
			this.tblLayout.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.panel1.Controls.Add(this.btnXem);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dpkDayTo);
			this.panel1.Controls.Add(this.dpkDayFrom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1092, 40);
			this.panel1.TabIndex = 0;
			// 
			// btnXem
			// 
			this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnXem.BackColor = System.Drawing.Color.SpringGreen;
			this.btnXem.FlatAppearance.BorderSize = 0;
			this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXem.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnXem.IconColor = System.Drawing.Color.Black;
			this.btnXem.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnXem.Location = new System.Drawing.Point(1004, 3);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(75, 30);
			this.btnXem.TabIndex = 3;
			this.btnXem.Text = "Xem";
			this.btnXem.UseVisualStyleBackColor = false;
			this.btnXem.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(740, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 24);
			this.label8.TabIndex = 2;
			this.label8.Text = "->";
			// 
			// dpkDayTo
			// 
			this.dpkDayTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dpkDayTo.BackColor = System.Drawing.Color.Transparent;
			this.dpkDayTo.BorderRadius = 1;
			this.dpkDayTo.Color = System.Drawing.Color.Silver;
			this.dpkDayTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
			this.dpkDayTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
			this.dpkDayTo.DisabledColor = System.Drawing.Color.Gray;
			this.dpkDayTo.DisplayWeekNumbers = false;
			this.dpkDayTo.DPHeight = 0;
			this.dpkDayTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dpkDayTo.FillDatePicker = false;
			this.dpkDayTo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dpkDayTo.ForeColor = System.Drawing.Color.Black;
			this.dpkDayTo.Icon = ((System.Drawing.Image)(resources.GetObject("dpkDayTo.Icon")));
			this.dpkDayTo.IconColor = System.Drawing.Color.Gray;
			this.dpkDayTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
			this.dpkDayTo.LeftTextMargin = 5;
			this.dpkDayTo.Location = new System.Drawing.Point(778, 2);
			this.dpkDayTo.MinimumSize = new System.Drawing.Size(4, 32);
			this.dpkDayTo.Name = "dpkDayTo";
			this.dpkDayTo.Size = new System.Drawing.Size(220, 32);
			this.dpkDayTo.TabIndex = 1;
			// 
			// dpkDayFrom
			// 
			this.dpkDayFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dpkDayFrom.BackColor = System.Drawing.Color.Transparent;
			this.dpkDayFrom.BorderRadius = 1;
			this.dpkDayFrom.Color = System.Drawing.Color.Silver;
			this.dpkDayFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
			this.dpkDayFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
			this.dpkDayFrom.DisabledColor = System.Drawing.Color.Gray;
			this.dpkDayFrom.DisplayWeekNumbers = false;
			this.dpkDayFrom.DPHeight = 0;
			this.dpkDayFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dpkDayFrom.FillDatePicker = false;
			this.dpkDayFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dpkDayFrom.ForeColor = System.Drawing.Color.Black;
			this.dpkDayFrom.Icon = ((System.Drawing.Image)(resources.GetObject("dpkDayFrom.Icon")));
			this.dpkDayFrom.IconColor = System.Drawing.Color.Gray;
			this.dpkDayFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
			this.dpkDayFrom.LeftTextMargin = 5;
			this.dpkDayFrom.Location = new System.Drawing.Point(514, 2);
			this.dpkDayFrom.MinimumSize = new System.Drawing.Size(4, 32);
			this.dpkDayFrom.Name = "dpkDayFrom";
			this.dpkDayFrom.Size = new System.Drawing.Size(220, 32);
			this.dpkDayFrom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Trang chủ";
			// 
			// pnDashBoardContent
			// 
			this.pnDashBoardContent.Controls.Add(this.panel7);
			this.pnDashBoardContent.Controls.Add(this.tableLayoutPanel1);
			this.pnDashBoardContent.Controls.Add(this.tblLayout);
			this.pnDashBoardContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnDashBoardContent.Location = new System.Drawing.Point(0, 40);
			this.pnDashBoardContent.Name = "pnDashBoardContent";
			this.pnDashBoardContent.Padding = new System.Windows.Forms.Padding(10);
			this.pnDashBoardContent.Size = new System.Drawing.Size(1092, 700);
			this.pnDashBoardContent.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.Control;
			this.panel7.Controls.Add(this.dgvThongSoSanPham);
			this.panel7.Controls.Add(this.label3);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(10, 523);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1072, 167);
			this.panel7.TabIndex = 2;
			// 
			// dgvThongSoSanPham
			// 
			this.dgvThongSoSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvThongSoSanPham.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvThongSoSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvThongSoSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvThongSoSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dgvThongSoSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvThongSoSanPham.Location = new System.Drawing.Point(0, 25);
			this.dgvThongSoSanPham.Name = "dgvThongSoSanPham";
			this.dgvThongSoSanPham.Size = new System.Drawing.Size(1072, 142);
			this.dgvThongSoSanPham.TabIndex = 1;
			this.dgvThongSoSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongSoSanPham_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mã SP";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Tên sản phẩm";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Số lượng";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Giá bán";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Giá nhập gần nhất";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Đã bán";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Đã nhập";
			this.Column7.Name = "Column7";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(269, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Thông số sản phẩm bán ra";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.Controls.Add(this.panelBieuDoDoanhThu, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelPieChart, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 130);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 393);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panelBieuDoDoanhThu
			// 
			this.panelBieuDoDoanhThu.BackColor = System.Drawing.Color.White;
			this.panelBieuDoDoanhThu.Controls.Add(this.chartThongKe);
			this.panelBieuDoDoanhThu.Controls.Add(this.panelTopBieuDo);
			this.panelBieuDoDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBieuDoDoanhThu.Location = new System.Drawing.Point(0, 0);
			this.panelBieuDoDoanhThu.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
			this.panelBieuDoDoanhThu.Name = "panelBieuDoDoanhThu";
			this.panelBieuDoDoanhThu.Size = new System.Drawing.Size(740, 383);
			this.panelBieuDoDoanhThu.TabIndex = 0;
			// 
			// chartThongKe
			// 
			this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartThongKe.Location = new System.Drawing.Point(0, 33);
			this.chartThongKe.Name = "chartThongKe";
			this.chartThongKe.Size = new System.Drawing.Size(740, 350);
			this.chartThongKe.TabIndex = 1;
			this.chartThongKe.Text = "bieuDoThuChi";
			// 
			// panelTopBieuDo
			// 
			this.panelTopBieuDo.Controls.Add(this.cbChonThoiGian);
			this.panelTopBieuDo.Controls.Add(this.label4);
			this.panelTopBieuDo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopBieuDo.Location = new System.Drawing.Point(0, 0);
			this.panelTopBieuDo.Name = "panelTopBieuDo";
			this.panelTopBieuDo.Size = new System.Drawing.Size(740, 33);
			this.panelTopBieuDo.TabIndex = 0;
			// 
			// cbChonThoiGian
			// 
			this.cbChonThoiGian.BackColor = System.Drawing.Color.Transparent;
			this.cbChonThoiGian.BackgroundColor = System.Drawing.Color.White;
			this.cbChonThoiGian.BorderColor = System.Drawing.Color.Gray;
			this.cbChonThoiGian.BorderRadius = 10;
			this.cbChonThoiGian.Color = System.Drawing.Color.Gray;
			this.cbChonThoiGian.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbChonThoiGian.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbChonThoiGian.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.cbChonThoiGian.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbChonThoiGian.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.cbChonThoiGian.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.cbChonThoiGian.Dock = System.Windows.Forms.DockStyle.Right;
			this.cbChonThoiGian.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbChonThoiGian.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbChonThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbChonThoiGian.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbChonThoiGian.FillDropDown = true;
			this.cbChonThoiGian.FillIndicator = false;
			this.cbChonThoiGian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbChonThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbChonThoiGian.ForeColor = System.Drawing.Color.Black;
			this.cbChonThoiGian.FormattingEnabled = true;
			this.cbChonThoiGian.Icon = null;
			this.cbChonThoiGian.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbChonThoiGian.IndicatorColor = System.Drawing.Color.Gray;
			this.cbChonThoiGian.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbChonThoiGian.ItemBackColor = System.Drawing.Color.White;
			this.cbChonThoiGian.ItemBorderColor = System.Drawing.Color.White;
			this.cbChonThoiGian.ItemForeColor = System.Drawing.Color.Black;
			this.cbChonThoiGian.ItemHeight = 26;
			this.cbChonThoiGian.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.cbChonThoiGian.ItemHighLightForeColor = System.Drawing.Color.White;
			this.cbChonThoiGian.Items.AddRange(new object[] {
            "Mặc định",
            "Tuần này",
            "Tháng này",
            "1 Năm",
            "Toàn thời gian"});
			this.cbChonThoiGian.ItemTopMargin = 3;
			this.cbChonThoiGian.Location = new System.Drawing.Point(563, 0);
			this.cbChonThoiGian.Name = "cbChonThoiGian";
			this.cbChonThoiGian.Size = new System.Drawing.Size(177, 32);
			this.cbChonThoiGian.TabIndex = 1;
			this.cbChonThoiGian.Text = null;
			this.cbChonThoiGian.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbChonThoiGian.TextLeftMargin = 5;
			this.cbChonThoiGian.SelectedIndexChanged += new System.EventHandler(this.cbChonThoiGian_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Left;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(244, 33);
			this.label4.TabIndex = 0;
			this.label4.Text = "Biểu đồ thống kê thu chi";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelPieChart
			// 
			this.panelPieChart.BackColor = System.Drawing.SystemColors.Control;
			this.panelPieChart.Controls.Add(this.cbThiPhan);
			this.panelPieChart.Controls.Add(this.panelConPie);
			this.panelPieChart.Controls.Add(this.label9);
			this.panelPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPieChart.Location = new System.Drawing.Point(750, 0);
			this.panelPieChart.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panelPieChart.Name = "panelPieChart";
			this.panelPieChart.Size = new System.Drawing.Size(322, 383);
			this.panelPieChart.TabIndex = 1;
			// 
			// cbThiPhan
			// 
			this.cbThiPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbThiPhan.BackColor = System.Drawing.Color.Transparent;
			this.cbThiPhan.BackgroundColor = System.Drawing.Color.White;
			this.cbThiPhan.BorderColor = System.Drawing.Color.Silver;
			this.cbThiPhan.BorderRadius = 10;
			this.cbThiPhan.Color = System.Drawing.Color.Silver;
			this.cbThiPhan.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
			this.cbThiPhan.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbThiPhan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.cbThiPhan.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cbThiPhan.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.cbThiPhan.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
			this.cbThiPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbThiPhan.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
			this.cbThiPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbThiPhan.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbThiPhan.FillDropDown = true;
			this.cbThiPhan.FillIndicator = false;
			this.cbThiPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbThiPhan.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbThiPhan.ForeColor = System.Drawing.Color.Black;
			this.cbThiPhan.FormattingEnabled = true;
			this.cbThiPhan.Icon = null;
			this.cbThiPhan.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbThiPhan.IndicatorColor = System.Drawing.Color.Gray;
			this.cbThiPhan.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
			this.cbThiPhan.ItemBackColor = System.Drawing.Color.White;
			this.cbThiPhan.ItemBorderColor = System.Drawing.Color.White;
			this.cbThiPhan.ItemForeColor = System.Drawing.Color.Black;
			this.cbThiPhan.ItemHeight = 26;
			this.cbThiPhan.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
			this.cbThiPhan.ItemHighLightForeColor = System.Drawing.Color.White;
			this.cbThiPhan.Items.AddRange(new object[] {
            "Tỷ lệ bán ra",
            "Số lượng sản phẩm"});
			this.cbThiPhan.ItemTopMargin = 3;
			this.cbThiPhan.Location = new System.Drawing.Point(196, 0);
			this.cbThiPhan.Name = "cbThiPhan";
			this.cbThiPhan.Size = new System.Drawing.Size(123, 32);
			this.cbThiPhan.TabIndex = 4;
			this.cbThiPhan.Text = null;
			this.cbThiPhan.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
			this.cbThiPhan.TextLeftMargin = 5;
			this.cbThiPhan.SelectedIndexChanged += new System.EventHandler(this.cbThiPhan_SelectedIndexChanged);
			// 
			// panelConPie
			// 
			this.panelConPie.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelConPie.Controls.Add(this.chartThiPhan);
			this.panelConPie.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelConPie.Location = new System.Drawing.Point(0, 33);
			this.panelConPie.Name = "panelConPie";
			this.panelConPie.Size = new System.Drawing.Size(322, 350);
			this.panelConPie.TabIndex = 3;
			// 
			// chartThiPhan
			// 
			this.chartThiPhan.BackColor = System.Drawing.SystemColors.Control;
			this.chartThiPhan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartThiPhan.Location = new System.Drawing.Point(0, 0);
			this.chartThiPhan.Name = "chartThiPhan";
			this.chartThiPhan.Size = new System.Drawing.Size(322, 350);
			this.chartThiPhan.TabIndex = 0;
			this.chartThiPhan.Text = "pieChart1";
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Top;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(322, 33);
			this.label9.TabIndex = 2;
			this.label9.Text = "Thị phần loại hàng";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tblLayout
			// 
			this.tblLayout.ColumnCount = 3;
			this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tblLayout.Controls.Add(this.panel4, 2, 0);
			this.tblLayout.Controls.Add(this.panel3, 1, 0);
			this.tblLayout.Controls.Add(this.panel2, 0, 0);
			this.tblLayout.Dock = System.Windows.Forms.DockStyle.Top;
			this.tblLayout.Location = new System.Drawing.Point(10, 10);
			this.tblLayout.Name = "tblLayout";
			this.tblLayout.RowCount = 1;
			this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblLayout.Size = new System.Drawing.Size(1072, 120);
			this.tblLayout.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(174)))), ((int)(((byte)(195)))));
			this.panel4.Controls.Add(this.lbSoLuonSP);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(714, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(358, 110);
			this.panel4.TabIndex = 2;
			// 
			// lbSoLuonSP
			// 
			this.lbSoLuonSP.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbSoLuonSP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoLuonSP.ForeColor = System.Drawing.Color.White;
			this.lbSoLuonSP.Location = new System.Drawing.Point(0, 35);
			this.lbSoLuonSP.Name = "lbSoLuonSP";
			this.lbSoLuonSP.Size = new System.Drawing.Size(358, 38);
			this.lbSoLuonSP.TabIndex = 3;
			this.lbSoLuonSP.Text = "50";
			this.lbSoLuonSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(358, 35);
			this.label7.TabIndex = 2;
			this.label7.Text = "Số lượng sản phẩm";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
			this.panel3.Controls.Add(this.lbTongChi);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(357, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(347, 110);
			this.panel3.TabIndex = 1;
			// 
			// lbTongChi
			// 
			this.lbTongChi.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTongChi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTongChi.ForeColor = System.Drawing.Color.White;
			this.lbTongChi.Location = new System.Drawing.Point(0, 35);
			this.lbTongChi.Name = "lbTongChi";
			this.lbTongChi.Size = new System.Drawing.Size(347, 38);
			this.lbTongChi.TabIndex = 3;
			this.lbTongChi.Text = "100.000 VND";
			this.lbTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(347, 35);
			this.label5.TabIndex = 2;
			this.label5.Text = "Tổng chi tiêu";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.lbTongThu);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(347, 110);
			this.panel2.TabIndex = 0;
			// 
			// lbTongThu
			// 
			this.lbTongThu.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTongThu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTongThu.ForeColor = System.Drawing.Color.White;
			this.lbTongThu.Location = new System.Drawing.Point(0, 35);
			this.lbTongThu.Name = "lbTongThu";
			this.lbTongThu.Size = new System.Drawing.Size(347, 38);
			this.lbTongThu.TabIndex = 1;
			this.lbTongThu.Text = "100.000 VND";
			this.lbTongThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(347, 35);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tổng thu";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// F_TrangChu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 740);
			this.Controls.Add(this.pnDashBoardContent);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "F_TrangChu";
			this.Text = "F_TrangChu";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnDashBoardContent.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThongSoSanPham)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panelBieuDoDoanhThu.ResumeLayout(false);
			this.panelTopBieuDo.ResumeLayout(false);
			this.panelPieChart.ResumeLayout(false);
			this.panelConPie.ResumeLayout(false);
			this.tblLayout.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnDashBoardContent;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTongThu;
        private System.Windows.Forms.Label lbTongChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSoLuonSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuDatePicker dpkDayTo;
        private Bunifu.UI.WinForms.BunifuDatePicker dpkDayFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelBieuDoDoanhThu;
        private System.Windows.Forms.Panel panelPieChart;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThongSoSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panelTopBieuDo;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown cbChonThoiGian;
        private LiveCharts.WinForms.CartesianChart chartThongKe;
        private LiveCharts.WinForms.PieChart chartThiPhan;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnXem;
        private System.Windows.Forms.Panel panelConPie;
        private Bunifu.UI.WinForms.BunifuDropdown cbThiPhan;
    }
}