
namespace ThisIsWin11
{
    partial class HomeWindow
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnPresenterMenu = new System.Windows.Forms.Button();
            this.btnConfigurator = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCustomizer = new System.Windows.Forms.Button();
            this.btnPresenter = new System.Windows.Forms.CheckBox();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.menuPresenter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPresenterInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            this.menuPresenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Controls.Add(this.cbTable);
            this.pnlLeft.Controls.Add(this.btnPresenterMenu);
            this.pnlLeft.Controls.Add(this.btnConfigurator);
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Controls.Add(this.btnCustomizer);
            this.pnlLeft.Controls.Add(this.btnPresenter);
            this.pnlLeft.Controls.Add(this.pbView);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(371, 770);
            this.pnlLeft.TabIndex = 163;
            // 
            // cbTable
            // 
            this.cbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(238, 735);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 23);
            this.cbTable.TabIndex = 135;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // btnPresenterMenu
            // 
            this.btnPresenterMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresenterMenu.FlatAppearance.BorderSize = 0;
            this.btnPresenterMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnPresenterMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresenterMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenterMenu.Location = new System.Drawing.Point(322, 0);
            this.btnPresenterMenu.Name = "btnPresenterMenu";
            this.btnPresenterMenu.Size = new System.Drawing.Size(48, 51);
            this.btnPresenterMenu.TabIndex = 136;
            this.btnPresenterMenu.UseVisualStyleBackColor = true;
            this.btnPresenterMenu.Click += new System.EventHandler(this.btnPresenterMenu_Click);
            // 
            // btnConfigurator
            // 
            this.btnConfigurator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfigurator.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurator.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnConfigurator.FlatAppearance.BorderSize = 0;
            this.btnConfigurator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurator.ForeColor = System.Drawing.Color.Black;
            this.btnConfigurator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfigurator.Location = new System.Drawing.Point(83, 206);
            this.btnConfigurator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfigurator.Name = "btnConfigurator";
            this.btnConfigurator.Size = new System.Drawing.Size(181, 32);
            this.btnConfigurator.TabIndex = 137;
            this.btnConfigurator.Text = "Configure this page";
            this.btnConfigurator.UseVisualStyleBackColor = false;
            this.btnConfigurator.Visible = false;
            this.btnConfigurator.Click += new System.EventHandler(this.btnConfigurator_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(24, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(283, 35);
            this.lblHeader.TabIndex = 134;
            this.lblHeader.Text = "Hi";
            // 
            // btnCustomizer
            // 
            this.btnCustomizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomizer.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCustomizer.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnCustomizer.FlatAppearance.BorderSize = 0;
            this.btnCustomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizer.ForeColor = System.Drawing.Color.White;
            this.btnCustomizer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCustomizer.Location = new System.Drawing.Point(83, 166);
            this.btnCustomizer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomizer.Name = "btnCustomizer";
            this.btnCustomizer.Size = new System.Drawing.Size(181, 32);
            this.btnCustomizer.TabIndex = 138;
            this.btnCustomizer.Text = "Customize this page";
            this.btnCustomizer.UseVisualStyleBackColor = false;
            this.btnCustomizer.Visible = false;
            this.btnCustomizer.Click += new System.EventHandler(this.btnCustomizer_Click);
            // 
            // btnPresenter
            // 
            this.btnPresenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPresenter.BackColor = System.Drawing.Color.DeepPink;
            this.btnPresenter.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.btnPresenter.FlatAppearance.BorderSize = 0;
            this.btnPresenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepPink;
            this.btnPresenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresenter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenter.ForeColor = System.Drawing.Color.White;
            this.btnPresenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPresenter.Location = new System.Drawing.Point(0, 250);
            this.btnPresenter.Name = "btnPresenter";
            this.btnPresenter.Size = new System.Drawing.Size(371, 32);
            this.btnPresenter.TabIndex = 139;
            this.btnPresenter.Text = "Preview this page";
            this.btnPresenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPresenter.UseVisualStyleBackColor = false;
            this.btnPresenter.CheckedChanged += new System.EventHandler(this.btnPresenter_CheckedChanged);
            // 
            // pbView
            // 
            this.pbView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbView.ErrorImage = null;
            this.pbView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbView.InitialImage = null;
            this.pbView.Location = new System.Drawing.Point(0, 209);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(371, 561);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbView.TabIndex = 127;
            this.pbView.TabStop = false;
            this.pbView.Paint += new System.Windows.Forms.PaintEventHandler(this.pbView_Paint);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubHeader.Location = new System.Drawing.Point(24, 19);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(672, 32);
            this.lblSubHeader.TabIndex = 135;
            this.lblSubHeader.Text = "Get Started with Windows 11";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.AutoScroll = true;
            this.pnlMiddle.AutoSize = true;
            this.pnlMiddle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMiddle.Controls.Add(this.lnkSubHeader);
            this.pnlMiddle.Controls.Add(this.btnBack);
            this.pnlMiddle.Controls.Add(this.lblSubHeader);
            this.pnlMiddle.Controls.Add(this.btnNext);
            this.pnlMiddle.Controls.Add(this.btnHome);
            this.pnlMiddle.Controls.Add(this.linkLabel1);
            this.pnlMiddle.Controls.Add(this.lblDesc);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(371, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(716, 770);
            this.pnlMiddle.TabIndex = 164;
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ForeColor = System.Drawing.Color.Gray;
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Location = new System.Drawing.Point(24, 68);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(313, 18);
            this.lnkSubHeader.TabIndex = 24;
            this.lnkSubHeader.TabStop = true;
            this.lnkSubHeader.Text = "Os";
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(590, 726);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 32);
            this.btnBack.TabIndex = 136;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(646, 726);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 32);
            this.btnNext.TabIndex = 135;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(534, 726);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 32);
            this.btnHome.TabIndex = 128;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(13, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(565, 18);
            this.linkLabel1.TabIndex = 24;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoEllipsis = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesc.Location = new System.Drawing.Point(24, 172);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(672, 454);
            this.lblDesc.TabIndex = 137;
            this.lblDesc.Text = "description";
            // 
            // menuPresenter
            // 
            this.menuPresenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuPresenter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPresenter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPresenterInfo});
            this.menuPresenter.Name = "menuMain";
            this.menuPresenter.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPresenter.Size = new System.Drawing.Size(118, 34);
            // 
            // menuPresenterInfo
            // 
            this.menuPresenterInfo.Name = "menuPresenterInfo";
            this.menuPresenterInfo.Size = new System.Drawing.Size(117, 30);
            this.menuPresenterInfo.Text = "Info";
            this.menuPresenterInfo.Click += new System.EventHandler(this.menuPresenterInfo_Click);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomeWindow";
            this.ShowIcon = false;
            this.Text = "Presenter";
            this.Shown += new System.EventHandler(this.HomeWindow_Shown);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            this.menuPresenter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button btnPresenterMenu;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.CheckBox btnPresenter;
        public System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnConfigurator;
        private System.Windows.Forms.Button btnCustomizer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip menuPresenter;
        private System.Windows.Forms.ToolStripMenuItem menuPresenterInfo;
        private System.Windows.Forms.Label lblDesc;
    }
}