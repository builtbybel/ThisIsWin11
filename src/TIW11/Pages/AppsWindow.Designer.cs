
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
            System.Windows.Forms.ToolStripMenuItem menuAppsExport;
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.btnRemoveUWP = new System.Windows.Forms.Button();
            this.lblAppsInstalledCount = new System.Windows.Forms.Label();
            this.btnAppsMenu = new System.Windows.Forms.Button();
            this.menuApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAppsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblAppsBinCount = new System.Windows.Forms.Label();
            this.lstUWPRemove = new System.Windows.Forms.ListBox();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.lblModuleInfo = new System.Windows.Forms.LinkLabel();
            this.lblAppsHeader = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.lstUWP = new System.Windows.Forms.ListBox();
            this.LblLeftAppName = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            menuAppsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApps.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.PnlMiddle.SuspendLayout();
            this.PnlLeft.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAppsExport
            // 
            menuAppsExport.Name = "menuAppsExport";
            menuAppsExport.Size = new System.Drawing.Size(347, 30);
            menuAppsExport.Text = "Export bloatware in Recycle Bin";
            menuAppsExport.Click += new System.EventHandler(this.menuAppsExport_Click);
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAppsSystem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkAppsSystem.FlatAppearance.BorderSize = 0;
            this.checkAppsSystem.FlatAppearance.CheckedBackColor = System.Drawing.Color.HotPink;
            this.checkAppsSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.Black;
            this.checkAppsSystem.Location = new System.Drawing.Point(11, 728);
            this.checkAppsSystem.Margin = new System.Windows.Forms.Padding(2);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(145, 31);
            this.checkAppsSystem.TabIndex = 103;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = false;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // btnRemoveUWP
            // 
            this.btnRemoveUWP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveUWP.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveUWP.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnRemoveUWP.FlatAppearance.BorderSize = 0;
            this.btnRemoveUWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUWP.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveUWP.Location = new System.Drawing.Point(18, 24);
            this.btnRemoveUWP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveUWP.Name = "btnRemoveUWP";
            this.btnRemoveUWP.Size = new System.Drawing.Size(307, 32);
            this.btnRemoveUWP.TabIndex = 104;
            this.btnRemoveUWP.Text = "Empty Recycle Bin";
            this.btnRemoveUWP.UseVisualStyleBackColor = false;
            this.btnRemoveUWP.Click += new System.EventHandler(this.btnRemoveUWP_Click);
            // 
            // lblAppsInstalledCount
            // 
            this.lblAppsInstalledCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppsInstalledCount.AutoEllipsis = true;
            this.lblAppsInstalledCount.AutoSize = true;
            this.lblAppsInstalledCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAppsInstalledCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsInstalledCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppsInstalledCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAppsInstalledCount.Location = new System.Drawing.Point(13, 21);
            this.lblAppsInstalledCount.Name = "lblAppsInstalledCount";
            this.lblAppsInstalledCount.Size = new System.Drawing.Size(69, 32);
            this.lblAppsInstalledCount.TabIndex = 137;
            this.lblAppsInstalledCount.Text = "Apps";
            // 
            // btnAppsMenu
            // 
            this.btnAppsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppsMenu.BackColor = System.Drawing.Color.White;
            this.btnAppsMenu.FlatAppearance.BorderSize = 0;
            this.btnAppsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAppsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppsMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppsMenu.Location = new System.Drawing.Point(293, 0);
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
            menuAppsExport,
            this.menuAppsRefresh,
            this.menuAppsRemoveAll,
            this.menuAppsPopOut,
            this.toolStripSeparator1,
            this.menuAppsInfo});
            this.menuApps.Name = "menuMain";
            this.menuApps.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuApps.Size = new System.Drawing.Size(348, 190);
            this.menuApps.Text = "Info";
            // 
            // menuAppsImport
            // 
            this.menuAppsImport.Name = "menuAppsImport";
            this.menuAppsImport.Size = new System.Drawing.Size(347, 30);
            this.menuAppsImport.Text = "Import bloatware list";
            this.menuAppsImport.Click += new System.EventHandler(this.menuAppsImport_Click);
            // 
            // menuAppsRefresh
            // 
            this.menuAppsRefresh.Name = "menuAppsRefresh";
            this.menuAppsRefresh.Size = new System.Drawing.Size(347, 30);
            this.menuAppsRefresh.Text = "Refresh";
            this.menuAppsRefresh.Click += new System.EventHandler(this.menuAppsRefresh_Click);
            // 
            // menuAppsRemoveAll
            // 
            this.menuAppsRemoveAll.Name = "menuAppsRemoveAll";
            this.menuAppsRemoveAll.Size = new System.Drawing.Size(347, 30);
            this.menuAppsRemoveAll.Text = "Uninstall all apps";
            this.menuAppsRemoveAll.Click += new System.EventHandler(this.menuAppsRemoveAll_Click);
            // 
            // menuAppsPopOut
            // 
            this.menuAppsPopOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAppsPopOut.Name = "menuAppsPopOut";
            this.menuAppsPopOut.Size = new System.Drawing.Size(347, 30);
            this.menuAppsPopOut.Text = "Pop-out-App";
            this.menuAppsPopOut.Click += new System.EventHandler(this.menuAppsPopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(344, 6);
            // 
            // menuAppsInfo
            // 
            this.menuAppsInfo.Name = "menuAppsInfo";
            this.menuAppsInfo.Size = new System.Drawing.Size(347, 30);
            this.menuAppsInfo.Text = "Info";
            this.menuAppsInfo.Click += new System.EventHandler(this.menuAppsInfo_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.lblAppsBinCount);
            this.pnlRight.Controls.Add(this.lstUWPRemove);
            this.pnlRight.Controls.Add(this.rtbPS);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(716, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(371, 770);
            this.pnlRight.TabIndex = 157;
            // 
            // lblAppsBinCount
            // 
            this.lblAppsBinCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppsBinCount.AutoEllipsis = true;
            this.lblAppsBinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAppsBinCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsBinCount.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppsBinCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAppsBinCount.Location = new System.Drawing.Point(21, 21);
            this.lblAppsBinCount.Name = "lblAppsBinCount";
            this.lblAppsBinCount.Size = new System.Drawing.Size(338, 32);
            this.lblAppsBinCount.TabIndex = 135;
            this.lblAppsBinCount.Text = "Recycle Bin";
            // 
            // lstUWPRemove
            // 
            this.lstUWPRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUWPRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstUWPRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUWPRemove.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lstUWPRemove.FormattingEnabled = true;
            this.lstUWPRemove.ItemHeight = 21;
            this.lstUWPRemove.Location = new System.Drawing.Point(27, 110);
            this.lstUWPRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstUWPRemove.Name = "lstUWPRemove";
            this.lstUWPRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstUWPRemove.Size = new System.Drawing.Size(343, 630);
            this.lstUWPRemove.Sorted = true;
            this.lstUWPRemove.TabIndex = 136;
            this.lstUWPRemove.Visible = false;
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.Location = new System.Drawing.Point(27, 110);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.ReadOnly = true;
            this.rtbPS.Size = new System.Drawing.Size(341, 636);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMiddle.Controls.Add(this.lblModuleInfo);
            this.PnlMiddle.Controls.Add(this.lblAppsHeader);
            this.PnlMiddle.Controls.Add(this.btnAddAll);
            this.PnlMiddle.Controls.Add(this.btnAdd);
            this.PnlMiddle.Controls.Add(this.btnRemove);
            this.PnlMiddle.Controls.Add(this.btnRemoveAll);
            this.PnlMiddle.Controls.Add(this.btnAppsMenu);
            this.PnlMiddle.Location = new System.Drawing.Point(374, 3);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(342, 688);
            this.PnlMiddle.TabIndex = 158;
            // 
            // lblModuleInfo
            // 
            this.lblModuleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModuleInfo.AutoEllipsis = true;
            this.lblModuleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblModuleInfo.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblModuleInfo.Location = new System.Drawing.Point(15, 63);
            this.lblModuleInfo.Name = "lblModuleInfo";
            this.lblModuleInfo.Size = new System.Drawing.Size(307, 17);
            this.lblModuleInfo.TabIndex = 163;
            this.lblModuleInfo.TabStop = true;
            this.lblModuleInfo.Text = "Learn more about PumpedApp";
            this.lblModuleInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblModuleInfo_LinkClicked);
            // 
            // lblAppsHeader
            // 
            this.lblAppsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppsHeader.AutoEllipsis = true;
            this.lblAppsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsHeader.ForeColor = System.Drawing.Color.Black;
            this.lblAppsHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAppsHeader.Location = new System.Drawing.Point(12, 21);
            this.lblAppsHeader.Name = "lblAppsHeader";
            this.lblAppsHeader.Size = new System.Drawing.Size(275, 32);
            this.lblAppsHeader.TabIndex = 25;
            this.lblAppsHeader.Text = "PumpedApp";
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddAll.FlatAppearance.BorderSize = 0;
            this.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAll.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnAddAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddAll.Location = new System.Drawing.Point(18, 115);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(307, 32);
            this.btnAddAll.TabIndex = 21;
            this.btnAddAll.Text = "Add all >>";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(18, 155);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(307, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add selected >";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(18, 253);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(307, 32);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "< Restore selected";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnRemoveAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveAll.Location = new System.Drawing.Point(18, 213);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(307, 32);
            this.btnRemoveAll.TabIndex = 22;
            this.btnRemoveAll.Text = "<< Restore all";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlLeft.Controls.Add(this.lstUWP);
            this.PnlLeft.Controls.Add(this.LblLeftAppName);
            this.PnlLeft.Controls.Add(this.lblAppsInstalledCount);
            this.PnlLeft.Controls.Add(this.checkAppsSystem);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(371, 770);
            this.PnlLeft.TabIndex = 159;
            // 
            // lstUWP
            // 
            this.lstUWP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUWP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstUWP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lstUWP.FormattingEnabled = true;
            this.lstUWP.ItemHeight = 21;
            this.lstUWP.Location = new System.Drawing.Point(17, 118);
            this.lstUWP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstUWP.Name = "lstUWP";
            this.lstUWP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstUWP.Size = new System.Drawing.Size(351, 609);
            this.lstUWP.Sorted = true;
            this.lstUWP.TabIndex = 138;
            // 
            // LblLeftAppName
            // 
            this.LblLeftAppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLeftAppName.AutoEllipsis = true;
            this.LblLeftAppName.AutoSize = true;
            this.LblLeftAppName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.LblLeftAppName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblLeftAppName.Location = new System.Drawing.Point(16, 101);
            this.LblLeftAppName.Name = "LblLeftAppName";
            this.LblLeftAppName.Size = new System.Drawing.Size(36, 13);
            this.LblLeftAppName.TabIndex = 26;
            this.LblLeftAppName.Text = "Name";
            // 
            // pnlBottom
            // 
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.Controls.Add(this.btnRemoveUWP);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(371, 697);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(345, 73);
            this.pnlBottom.TabIndex = 160;
            // 
            // AppsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.PnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.PnlMiddle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AppsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PumpedApp";
            this.Shown += new System.EventHandler(this.AppsWindow_Shown);
            this.menuApps.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.PnlMiddle.ResumeLayout(false);
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.Button btnRemoveUWP;
        private System.Windows.Forms.Label lblAppsInstalledCount;
        private System.Windows.Forms.Button btnAppsMenu;
        private System.Windows.Forms.ContextMenuStrip menuApps;
        private System.Windows.Forms.ToolStripMenuItem menuAppsPopOut;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem menuAppsImport;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuAppsInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblAppsBinCount;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.Label lblAppsHeader;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Label LblLeftAppName;
        private System.Windows.Forms.ListBox lstUWPRemove;
        private System.Windows.Forms.ListBox lstUWP;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.LinkLabel lblModuleInfo;
    }
}