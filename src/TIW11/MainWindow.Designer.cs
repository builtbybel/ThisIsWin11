
namespace ThisIsWin11
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.richDesc = new System.Windows.Forms.RichTextBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnOptimizer = new System.Windows.Forms.Button();
            this.btnConfigurator = new System.Windows.Forms.Button();
            this.btnPresenter = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.textPS = new System.Windows.Forms.TextBox();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCaptureToShare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTweaker = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoSize = true;
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Controls.Add(this.lblSubHeader);
            this.pnlLeft.Controls.Add(this.btnBack);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.lblMainMenu);
            this.pnlLeft.Controls.Add(this.btnNext);
            this.pnlLeft.Controls.Add(this.richDesc);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(400, 770);
            this.pnlLeft.TabIndex = 130;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubHeader.Location = new System.Drawing.Point(13, 21);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(371, 43);
            this.lblSubHeader.TabIndex = 134;
            this.lblSubHeader.Text = "Welcome";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(267, 726);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 32);
            this.btnBack.TabIndex = 136;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHome.AutoSize = true;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(12, 725);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 32);
            this.btnHome.TabIndex = 128;
            this.tt.SetToolTip(this.btnHome, "Goto start");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainMenu.FlatAppearance.BorderSize = 0;
            this.lblMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.lblMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMainMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblMainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMainMenu.Location = new System.Drawing.Point(0, 2);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(48, 51);
            this.lblMainMenu.TabIndex = 113;
            this.lblMainMenu.UseVisualStyleBackColor = false;
            this.lblMainMenu.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(323, 726);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 32);
            this.btnNext.TabIndex = 135;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // richDesc
            // 
            this.richDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richDesc.Location = new System.Drawing.Point(18, 149);
            this.richDesc.Name = "richDesc";
            this.richDesc.ReadOnly = true;
            this.richDesc.Size = new System.Drawing.Size(366, 571);
            this.richDesc.TabIndex = 133;
            this.richDesc.Text = "";
            // 
            // cbTable
            // 
            this.cbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(255, 735);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 23);
            this.cbTable.TabIndex = 135;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMiddle.AutoScroll = true;
            this.pnlMiddle.BackColor = System.Drawing.Color.White;
            this.pnlMiddle.Controls.Add(this.btnOptimizer);
            this.pnlMiddle.Controls.Add(this.btnConfigurator);
            this.pnlMiddle.Controls.Add(this.btnPresenter);
            this.pnlMiddle.Controls.Add(this.lblHeader);
            this.pnlMiddle.Controls.Add(this.lnkSubHeader);
            this.pnlMiddle.Location = new System.Drawing.Point(401, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(371, 770);
            this.pnlMiddle.TabIndex = 134;
            // 
            // btnOptimizer
            // 
            this.btnOptimizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptimizer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOptimizer.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOptimizer.FlatAppearance.BorderSize = 0;
            this.btnOptimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptimizer.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnOptimizer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOptimizer.Location = new System.Drawing.Point(16, 245);
            this.btnOptimizer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOptimizer.Name = "btnOptimizer";
            this.btnOptimizer.Size = new System.Drawing.Size(337, 32);
            this.btnOptimizer.TabIndex = 138;
            this.btnOptimizer.Text = "This page can be optimized";
            this.btnOptimizer.UseVisualStyleBackColor = false;
            this.btnOptimizer.Click += new System.EventHandler(this.btnOptimizer_Click);
            // 
            // btnConfigurator
            // 
            this.btnConfigurator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigurator.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurator.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurator.FlatAppearance.BorderSize = 0;
            this.btnConfigurator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurator.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnConfigurator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfigurator.Location = new System.Drawing.Point(16, 205);
            this.btnConfigurator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfigurator.Name = "btnConfigurator";
            this.btnConfigurator.Size = new System.Drawing.Size(337, 32);
            this.btnConfigurator.TabIndex = 137;
            this.btnConfigurator.Text = "This page can be configured";
            this.btnConfigurator.UseVisualStyleBackColor = false;
            this.btnConfigurator.Click += new System.EventHandler(this.btnConfigurator_Click);
            // 
            // btnPresenter
            // 
            this.btnPresenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPresenter.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnPresenter.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnPresenter.FlatAppearance.BorderSize = 0;
            this.btnPresenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnPresenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresenter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenter.ForeColor = System.Drawing.Color.White;
            this.btnPresenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPresenter.Location = new System.Drawing.Point(16, 149);
            this.btnPresenter.Name = "btnPresenter";
            this.btnPresenter.Size = new System.Drawing.Size(337, 32);
            this.btnPresenter.TabIndex = 130;
            this.btnPresenter.Text = "This page can be previewed";
            this.btnPresenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPresenter.UseVisualStyleBackColor = false;
            this.btnPresenter.CheckedChanged += new System.EventHandler(this.btnPresenter_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(12, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(339, 32);
            this.lblHeader.TabIndex = 25;
            this.lblHeader.Text = "Get started with Windows 11";
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.DeepPink;
            this.lnkSubHeader.Location = new System.Drawing.Point(13, 68);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(338, 18);
            this.lnkSubHeader.TabIndex = 24;
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.btnSettings);
            this.pnlRight.Controls.Add(this.lblPreview);
            this.pnlRight.Controls.Add(this.cbTable);
            this.pnlRight.Controls.Add(this.textPS);
            this.pnlRight.Controls.Add(this.pbView);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(771, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(395, 770);
            this.pnlRight.TabIndex = 135;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(345, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(48, 51);
            this.btnSettings.TabIndex = 136;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreview.AutoEllipsis = true;
            this.lblPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.DimGray;
            this.lblPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPreview.Location = new System.Drawing.Point(21, 21);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(121, 32);
            this.lblPreview.TabIndex = 135;
            this.lblPreview.Text = "Preview";
            // 
            // textPS
            // 
            this.textPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPS.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPS.Location = new System.Drawing.Point(21, 116);
            this.textPS.Multiline = true;
            this.textPS.Name = "textPS";
            this.textPS.ReadOnly = true;
            this.textPS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPS.Size = new System.Drawing.Size(374, 654);
            this.textPS.TabIndex = 137;
            this.textPS.Visible = false;
            // 
            // pbView
            // 
            this.pbView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbView.Location = new System.Drawing.Point(0, 116);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(395, 654);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbView.TabIndex = 127;
            this.pbView.TabStop = false;
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTweaker,
            this.menuCaptureToShare,
            this.menuAppInfo});
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMain.Size = new System.Drawing.Size(331, 94);
            // 
            // menuCaptureToShare
            // 
            this.menuCaptureToShare.Name = "menuCaptureToShare";
            this.menuCaptureToShare.Size = new System.Drawing.Size(330, 30);
            this.menuCaptureToShare.Text = "Capture and Share on Twitter";
            this.menuCaptureToShare.Click += new System.EventHandler(this.menuCaptureToShare_Click);
            // 
            // menuAppInfo
            // 
            this.menuAppInfo.Name = "menuAppInfo";
            this.menuAppInfo.Size = new System.Drawing.Size(330, 30);
            this.menuAppInfo.Text = "About this App";
            // 
            // menuTweaker
            // 
            this.menuTweaker.Name = "menuTweaker";
            this.menuTweaker.Size = new System.Drawing.Size(330, 30);
            this.menuTweaker.Text = "Open Tweaker";
            this.menuTweaker.Click += new System.EventHandler(this.menuTweaker_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1166, 770);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlLeft);
            this.MinimumSize = new System.Drawing.Size(814, 735);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11 (Preview)";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button lblMainMenu;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.CheckBox btnPresenter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnConfigurator;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem menuAppInfo;
        private System.Windows.Forms.ToolStripMenuItem menuCaptureToShare;
        private System.Windows.Forms.Button btnOptimizer;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.RichTextBox richDesc;
        public System.Windows.Forms.TextBox textPS;
        private System.Windows.Forms.ToolStripMenuItem menuTweaker;
        private System.Windows.Forms.PictureBox pbView;
    }
}

