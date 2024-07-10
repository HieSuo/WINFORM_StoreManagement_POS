namespace StoreManagement.GUI.ModuleForm
{
    partial class F_QuanLyPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_QuanLyPhieuNhap));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txbTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ngayTao,
            this.nhaCungCap,
            this.nguoiTao,
            this.tongGiaTri});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 75);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1081, 591);
            this.dgvPhieuNhap.TabIndex = 1;
            this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellContentClick);
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
            this.btnExport.Location = new System.Drawing.Point(971, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 40);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(289, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(28, 26);
            this.btnTimKiem.TabIndex = 16;
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
            this.txbTimKiem.Location = new System.Drawing.Point(2, 37);
            this.txbTimKiem.MaxLength = 32767;
            this.txbTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbTimKiem.Modified = false;
            this.txbTimKiem.Multiline = false;
            this.txbTimKiem.Name = "txbTimKiem";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTimKiem.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbTimKiem.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTimKiem.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbTimKiem.OnIdleState = stateProperties8;
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
            this.txbTimKiem.Size = new System.Drawing.Size(325, 32);
            this.txbTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbTimKiem.TabIndex = 15;
            this.txbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTimKiem.TextMarginBottom = 0;
            this.txbTimKiem.TextMarginLeft = 3;
            this.txbTimKiem.TextMarginTop = 0;
            this.txbTimKiem.TextPlaceholder = "Tìm kiếm";
            this.txbTimKiem.UseSystemPasswordChar = false;
            this.txbTimKiem.WordWrap = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "ID Phiếu nhập";
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // ngayTao
            // 
            this.ngayTao.HeaderText = "Ngày tạo";
            this.ngayTao.Name = "ngayTao";
            // 
            // nhaCungCap
            // 
            this.nhaCungCap.HeaderText = "Nhà cung cấp";
            this.nhaCungCap.Name = "nhaCungCap";
            // 
            // nguoiTao
            // 
            this.nguoiTao.HeaderText = "Người tạo";
            this.nguoiTao.Name = "nguoiTao";
            // 
            // tongGiaTri
            // 
            this.tongGiaTri.HeaderText = "Tổng giá trị";
            this.tongGiaTri.Name = "tongGiaTri";
            // 
            // F_QuanLyPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_QuanLyPhieuNhap";
            this.Text = "F_QuanLyPhieuNhap";
            this.Load += new System.EventHandler(this.F_QuanLyPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private Bunifu.UI.WinForms.BunifuTextBox txbTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGiaTri;
    }
}