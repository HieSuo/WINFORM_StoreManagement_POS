namespace StoreManagement.GUI.ModuleForm
{
    partial class F_QuanLyHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_QuanLyHoaDon));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txbTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ngayTao,
            this.idKH,
            this.giamGia,
            this.idNguoiTao});
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 75);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(1084, 591);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID Hóa đơn";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // ngayTao
            // 
            this.ngayTao.DataPropertyName = "NgayTao";
            this.ngayTao.HeaderText = "Ngày tạo";
            this.ngayTao.Name = "ngayTao";
            // 
            // idKH
            // 
            this.idKH.DataPropertyName = "idKhachHang";
            this.idKH.HeaderText = "ID Khách hàng";
            this.idKH.Name = "idKH";
            // 
            // giamGia
            // 
            this.giamGia.DataPropertyName = "giamGia";
            this.giamGia.HeaderText = "Giảm giá";
            this.giamGia.Name = "giamGia";
            // 
            // idNguoiTao
            // 
            this.idNguoiTao.DataPropertyName = "idNguoiTao";
            this.idNguoiTao.HeaderText = "Người tạo";
            this.idNguoiTao.Name = "idNguoiTao";
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
            this.btnExport.TabIndex = 18;
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
            this.txbTimKiem.Location = new System.Drawing.Point(2, 37);
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
            this.txbTimKiem.Size = new System.Drawing.Size(325, 32);
            this.txbTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbTimKiem.TabIndex = 19;
            this.txbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTimKiem.TextMarginBottom = 0;
            this.txbTimKiem.TextMarginLeft = 3;
            this.txbTimKiem.TextMarginTop = 0;
            this.txbTimKiem.TextPlaceholder = "Tìm kiếm";
            this.txbTimKiem.UseSystemPasswordChar = false;
            this.txbTimKiem.WordWrap = true;
            // 
            // F_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_QuanLyHoaDon";
            this.Text = "F_QuanLyHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private FontAwesome.Sharp.IconButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNguoiTao;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private Bunifu.UI.WinForms.BunifuTextBox txbTimKiem;
    }
}