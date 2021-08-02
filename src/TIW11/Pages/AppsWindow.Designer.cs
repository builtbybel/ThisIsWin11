
namespace ThisIsWin11
{
    partial class AppsWindow
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
            System.Windows.Forms.ToolStripMenuItem menuAppsSync;
            this.lstUWP = new System.Windows.Forms.CheckedListBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.btnRemoveUWP = new System.Windows.Forms.Button();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnAppsMenu = new System.Windows.Forms.Button();
            this.menuApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAppsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            menuAppsSync = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApps.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAppsSync
            // 
            menuAppsSync.Name = "menuAppsSync";
            menuAppsSync.Size = new System.Drawing.Size(285, 30);
            menuAppsSync.Text = "Run community syncing";
            menuAppsSync.Click += new System.EventHandler(this.menuAppsSync_Click);
            // 
            // lstUWP
            // 
            this.lstUWP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUWP.BackColor = System.Drawing.Color.White;
            this.lstUWP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUWP.CheckOnClick = true;
            this.lstUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUWP.FormattingEnabled = true;
            this.lstUWP.Location = new System.Drawing.Point(24, 99);
            this.lstUWP.Name = "lstUWP";
            this.lstUWP.Size = new System.Drawing.Size(691, 576);
            this.lstUWP.Sorted = true;
            this.lstUWP.TabIndex = 60;
            this.lstUWP.ThreeDCheckBoxes = true;
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.BackColor = System.Drawing.Color.White;
            this.checkAppsSystem.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.checkAppsSystem.FlatAppearance.BorderSize = 0;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkAppsSystem.Location = new System.Drawing.Point(25, 678);
            this.checkAppsSystem.Margin = new System.Windows.Forms.Padding(2);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(163, 25);
            this.checkAppsSystem.TabIndex = 103;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = false;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // btnRemoveUWP
            // 
            this.btnRemoveUWP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveUWP.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveUWP.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnRemoveUWP.FlatAppearance.BorderSize = 0;
            this.btnRemoveUWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUWP.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveUWP.Location = new System.Drawing.Point(24, 715);
            this.btnRemoveUWP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveUWP.Name = "btnRemoveUWP";
            this.btnRemoveUWP.Size = new System.Drawing.Size(213, 30);
            this.btnRemoveUWP.TabIndex = 104;
            this.btnRemoveUWP.Text = "Uninstall";
            this.btnRemoveUWP.UseVisualStyleBackColor = false;
            this.btnRemoveUWP.Click += new System.EventHandler(this.btnRemoveUWP_Click);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.White;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubHeader.Location = new System.Drawing.Point(24, 19);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(160, 32);
            this.lblSubHeader.TabIndex = 137;
            this.lblSubHeader.Text = "Remove apps";
            // 
            // btnAppsMenu
            // 
            this.btnAppsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppsMenu.BackColor = System.Drawing.Color.White;
            this.btnAppsMenu.FlatAppearance.BorderSize = 0;
            this.btnAppsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAppsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppsMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppsMenu.Location = new System.Drawing.Point(667, 0);
            this.btnAppsMenu.Name = "btnAppsMenu";
            this.btnAppsMenu.Size = new System.Drawing.Size(48, 51);
            this.btnAppsMenu.TabIndex = 156;
            this.btnAppsMenu.UseVisualStyleBackColor = false;
            this.btnAppsMenu.Click += new System.EventHandler(this.btnAppsMenu_Click);
            // 
            // menuApps
            // 
            this.menuApps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuApps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppsImport,
            menuAppsSync,
            this.menuAppsRefresh,
            this.menuAppsSelect,
            this.menuAppsRemoveAll,
            this.menuAppsNewWindow,
            this.toolStripSeparator1,
            this.menuAppsInfo});
            this.menuApps.Name = "menuMain";
            this.menuApps.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuApps.Size = new System.Drawing.Size(286, 220);
            this.menuApps.Text = "Info";
            // 
            // menuAppsImport
            // 
            this.menuAppsImport.Name = "menuAppsImport";
            this.menuAppsImport.Size = new System.Drawing.Size(285, 30);
            this.menuAppsImport.Text = "Import bloatware list";
            this.menuAppsImport.Click += new System.EventHandler(this.menuAppsImport_Click);
            // 
            // menuAppsRefresh
            // 
            this.menuAppsRefresh.Name = "menuAppsRefresh";
            this.menuAppsRefresh.Size = new System.Drawing.Size(285, 30);
            this.menuAppsRefresh.Text = "Refresh";
            this.menuAppsRefresh.Click += new System.EventHandler(this.menuAppsRefresh_Click);
            // 
            // menuAppsSelect
            // 
            this.menuAppsSelect.Name = "menuAppsSelect";
            this.menuAppsSelect.Size = new System.Drawing.Size(285, 30);
            this.menuAppsSelect.Text = "Select all";
            this.menuAppsSelect.Click += new System.EventHandler(this.menuAppsSelect_Click);
            // 
            // menuAppsRemoveAll
            // 
            this.menuAppsRemoveAll.Name = "menuAppsRemoveAll";
            this.menuAppsRemoveAll.Size = new System.Drawing.Size(285, 30);
            this.menuAppsRemoveAll.Text = "Uninstall all apps";
            this.menuAppsRemoveAll.Click += new System.EventHandler(this.menuAppsRemoveAll_Click);
            // 
            // menuAppsNewWindow
            // 
            this.menuAppsNewWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAppsNewWindow.Name = "menuAppsNewWindow";
            this.menuAppsNewWindow.Size = new System.Drawing.Size(285, 30);
            this.menuAppsNewWindow.Text = "Open in new window";
            this.menuAppsNewWindow.Click += new System.EventHandler(this.menuAppsNewWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(282, 6);
            // 
            // menuAppsInfo
            // 
            this.menuAppsInfo.Name = "menuAppsInfo";
            this.menuAppsInfo.Size = new System.Drawing.Size(285, 30);
            this.menuAppsInfo.Text = "Info";
            this.menuAppsInfo.Click += new System.EventHandler(this.menuAppsInfo_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.lblPreview);
            this.pnlRight.Controls.Add(this.rtbPS);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(716, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(371, 770);
            this.pnlRight.TabIndex = 157;
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreview.AutoEllipsis = true;
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.Black;
            this.lblPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPreview.Location = new System.Drawing.Point(21, 21);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(131, 32);
            this.lblPreview.TabIndex = 135;
            this.lblPreview.Text = "Preview";
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.Location = new System.Drawing.Point(27, 99);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.ReadOnly = true;
            this.rtbPS.Size = new System.Drawing.Size(343, 668);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // AppsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.btnAppsMenu);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.btnRemoveUWP);
            this.Controls.Add(this.checkAppsSystem);
            this.Controls.Add(this.lstUWP);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AppsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kickassbloat";
            this.Shown += new System.EventHandler(this.AppsWindow_Shown);
            this.menuApps.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstUWP;
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.Button btnRemoveUWP;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnAppsMenu;
        private System.Windows.Forms.ContextMenuStrip menuApps;
        private System.Windows.Forms.ToolStripMenuItem menuAppsNewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem menuAppsSelect;
        private System.Windows.Forms.ToolStripMenuItem menuAppsImport;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuAppsInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblPreview;
        public System.Windows.Forms.RichTextBox rtbPS;
    }
}