namespace StoreManagement.GUI.CustomDialog
{
    partial class NoticeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeDialog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.noticeHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseDialog = new FontAwesome.Sharp.IconButton();
            this.lbNoticeHeader = new System.Windows.Forms.Label();
            this.lbNoticeText = new System.Windows.Forms.Label();
            this.btnOK = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.noticeHeader.Size = new System.Drawing.Size(316, 32);
            this.noticeHeader.TabIndex = 0;
            this.noticeHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noticeHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông báo";
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
            this.btnCloseDialog.Location = new System.Drawing.Point(274, 0);
            this.btnCloseDialog.Margin = new System.Windows.Forms.Padding(20);
            this.btnCloseDialog.Name = "btnCloseDialog";
            this.btnCloseDialog.Size = new System.Drawing.Size(42, 32);
            this.btnCloseDialog.TabIndex = 1;
            this.btnCloseDialog.UseVisualStyleBackColor = false;
            this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
            // 
            // lbNoticeHeader
            // 
            this.lbNoticeHeader.AutoSize = true;
            this.lbNoticeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNoticeHeader.Location = new System.Drawing.Point(54, 52);
            this.lbNoticeHeader.Name = "lbNoticeHeader";
            this.lbNoticeHeader.Size = new System.Drawing.Size(206, 16);
            this.lbNoticeHeader.TabIndex = 1;
            this.lbNoticeHeader.Text = "Đăng nhập không thành công";
            // 
            // lbNoticeText
            // 
            this.lbNoticeText.AutoSize = true;
            this.lbNoticeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNoticeText.Location = new System.Drawing.Point(10, 84);
            this.lbNoticeText.Name = "lbNoticeText";
            this.lbNoticeText.Size = new System.Drawing.Size(295, 18);
            this.lbNoticeText.TabIndex = 2;
            this.lbNoticeText.Text = "Tài khoản không tồn tại, vui lòng kiểm tra lại";
            this.lbNoticeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.AllowAnimations = true;
            this.btnOK.AllowMouseEffects = true;
            this.btnOK.AllowToggling = false;
            this.btnOK.AnimationSpeed = 200;
            this.btnOK.AutoGenerateColors = false;
            this.btnOK.AutoRoundBorders = false;
            this.btnOK.AutoSizeLeftIcon = true;
            this.btnOK.AutoSizeRightIcon = true;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackColor1 = System.Drawing.Color.Black;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.ButtonText = "OK";
            this.btnOK.ButtonTextMarginLeft = 0;
            this.btnOK.ColorContrastOnClick = 45;
            this.btnOK.ColorContrastOnHover = 45;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnOK.CustomizableEdges = borderEdges1;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOK.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOK.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOK.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOK.IconMarginLeft = 11;
            this.btnOK.IconPadding = 10;
            this.btnOK.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOK.IconSize = 25;
            this.btnOK.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.IdleBorderRadius = 20;
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleFillColor = System.Drawing.Color.Black;
            this.btnOK.IdleIconLeftImage = null;
            this.btnOK.IdleIconRightImage = null;
            this.btnOK.IndicateFocus = false;
            this.btnOK.Location = new System.Drawing.Point(108, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOK.OnDisabledState.BorderRadius = 20;
            this.btnOK.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.OnDisabledState.BorderThickness = 1;
            this.btnOK.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOK.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOK.OnDisabledState.IconLeftImage = null;
            this.btnOK.OnDisabledState.IconRightImage = null;
            this.btnOK.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnOK.onHoverState.BorderRadius = 20;
            this.btnOK.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.onHoverState.BorderThickness = 1;
            this.btnOK.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnOK.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOK.onHoverState.IconLeftImage = null;
            this.btnOK.onHoverState.IconRightImage = null;
            this.btnOK.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.OnIdleState.BorderRadius = 20;
            this.btnOK.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.OnIdleState.BorderThickness = 1;
            this.btnOK.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnOK.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOK.OnIdleState.IconLeftImage = null;
            this.btnOK.OnIdleState.IconRightImage = null;
            this.btnOK.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.OnPressedState.BorderRadius = 20;
            this.btnOK.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.OnPressedState.BorderThickness = 1;
            this.btnOK.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOK.OnPressedState.IconLeftImage = null;
            this.btnOK.OnPressedState.IconRightImage = null;
            this.btnOK.Size = new System.Drawing.Size(98, 39);
            this.btnOK.TabIndex = 3;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOK.TextMarginLeft = 0;
            this.btnOK.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOK.UseDefaultRadiusAndThickness = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NoticeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 214);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbNoticeText);
            this.Controls.Add(this.lbNoticeHeader);
            this.Controls.Add(this.noticeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoticeDialog";
            this.Text = "DialogCheckLogin";
            this.noticeHeader.ResumeLayout(false);
            this.noticeHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel noticeHeader;
        private FontAwesome.Sharp.IconButton btnCloseDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNoticeHeader;
        private System.Windows.Forms.Label lbNoticeText;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOK;
    }
}