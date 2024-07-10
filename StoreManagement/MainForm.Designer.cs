namespace StoreManagement
{
    partial class MainForm
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
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panelHeader = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMaximize = new FontAwesome.Sharp.IconButton();
			this.btnMinimize = new FontAwesome.Sharp.IconButton();
			this.btnCloseApp = new FontAwesome.Sharp.IconButton();
			this.iconHomeButton = new FontAwesome.Sharp.IconButton();
			this.panelMainContent = new System.Windows.Forms.Panel();
			this.panelHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.White;
			this.panelHeader.Controls.Add(this.panel1);
			this.panelHeader.Controls.Add(this.iconHomeButton);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1280, 60);
			this.panelHeader.TabIndex = 0;
			this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMaximize);
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnCloseApp);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(1159, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(121, 60);
			this.panel1.TabIndex = 1;
			// 
			// btnMaximize
			// 
			this.btnMaximize.BackColor = System.Drawing.Color.White;
			this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMaximize.FlatAppearance.BorderSize = 0;
			this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
			this.btnMaximize.IconColor = System.Drawing.Color.Black;
			this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnMaximize.IconSize = 30;
			this.btnMaximize.Location = new System.Drawing.Point(39, 0);
			this.btnMaximize.Margin = new System.Windows.Forms.Padding(20);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(40, 60);
			this.btnMaximize.TabIndex = 2;
			this.btnMaximize.UseVisualStyleBackColor = false;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.White;
			this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.btnMinimize.IconColor = System.Drawing.Color.Black;
			this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnMinimize.IconSize = 30;
			this.btnMinimize.Location = new System.Drawing.Point(0, 0);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(20);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(39, 60);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnCloseApp
			// 
			this.btnCloseApp.BackColor = System.Drawing.Color.White;
			this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCloseApp.FlatAppearance.BorderSize = 0;
			this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseApp.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
			this.btnCloseApp.IconColor = System.Drawing.Color.Black;
			this.btnCloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCloseApp.IconSize = 30;
			this.btnCloseApp.Location = new System.Drawing.Point(79, 0);
			this.btnCloseApp.Margin = new System.Windows.Forms.Padding(20);
			this.btnCloseApp.Name = "btnCloseApp";
			this.btnCloseApp.Size = new System.Drawing.Size(42, 60);
			this.btnCloseApp.TabIndex = 0;
			this.btnCloseApp.UseVisualStyleBackColor = false;
			this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
			// 
			// iconHomeButton
			// 
			this.iconHomeButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.iconHomeButton.FlatAppearance.BorderSize = 0;
			this.iconHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconHomeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconHomeButton.IconChar = FontAwesome.Sharp.IconChar.React;
			this.iconHomeButton.IconColor = System.Drawing.Color.Black;
			this.iconHomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconHomeButton.Location = new System.Drawing.Point(0, 0);
			this.iconHomeButton.Name = "iconHomeButton";
			this.iconHomeButton.Size = new System.Drawing.Size(188, 60);
			this.iconHomeButton.TabIndex = 0;
			this.iconHomeButton.Text = "StoreMNG";
			this.iconHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconHomeButton.UseVisualStyleBackColor = true;
			this.iconHomeButton.Click += new System.EventHandler(this.iconHomeButton_Click);
			// 
			// panelMainContent
			// 
			this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMainContent.Location = new System.Drawing.Point(0, 60);
			this.panelMainContent.Name = "panelMainContent";
			this.panelMainContent.Size = new System.Drawing.Size(1280, 740);
			this.panelMainContent.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 800);
			this.Controls.Add(this.panelMainContent);
			this.Controls.Add(this.panelHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panelHeader.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton iconHomeButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnCloseApp;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel panelMainContent;
    }
}

