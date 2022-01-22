
namespace ThisIsWin11
{
    partial class AutomateWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomateWindow));
            this.menuAutomateImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomateEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomateSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAutomateApplied = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomatePopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomateSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuAutomateInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstPS = new System.Windows.Forms.CheckedListBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.lblScripts = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAutomateOnTheFly = new ThisIsWin11.Controls.RoundedButton();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.btnAutomate = new ThisIsWin11.Controls.RoundedButton();
            this.btnCancel = new ThisIsWin11.Controls.RoundedButton();
            this.btnEdit = new ThisIsWin11.Controls.RoundedButton();
            this.btnAutomateMenu = new ThisIsWin11.Controls.RoundedButton();
            this.menuAutomate.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAutomateImport
            // 
            this.menuAutomateImport.Name = "menuAutomateImport";
            this.menuAutomateImport.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateImport.Text = "Import";
            this.menuAutomateImport.Click += new System.EventHandler(this.menuAutomateImport_Click);
            // 
            // menuAutomateEdit
            // 
            this.menuAutomateEdit.Name = "menuAutomateEdit";
            this.menuAutomateEdit.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateEdit.Text = "Edit ";
            this.menuAutomateEdit.Click += new System.EventHandler(this.menuAutomateEdit_Click);
            // 
            // menuAutomateSave
            // 
            this.menuAutomateSave.Name = "menuAutomateSave";
            this.menuAutomateSave.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateSave.Text = "Save current script as new preset script";
            this.menuAutomateSave.Click += new System.EventHandler(this.menuAutomateSave_Click);
            // 
            // menuAutomate
            // 
            this.menuAutomate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuAutomate.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAutomate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAutomateImport,
            this.menuAutomateEdit,
            this.menuAutomateSave,
            this.menuAutomateApplied,
            this.menuAutomatePopOut,
            this.menuAutomateSeparator,
            this.menuAutomateInfo});
            this.menuAutomate.Name = "menuMain";
            this.menuAutomate.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuAutomate.Size = new System.Drawing.Size(412, 190);
            // 
            // menuAutomateApplied
            // 
            this.menuAutomateApplied.Name = "menuAutomateApplied";
            this.menuAutomateApplied.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateApplied.Text = "Show applied";
            this.menuAutomateApplied.Click += new System.EventHandler(this.menuAutomateApplied_Click);
            // 
            // menuAutomatePopOut
            // 
            this.menuAutomatePopOut.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAutomatePopOut.Name = "menuAutomatePopOut";
            this.menuAutomatePopOut.Size = new System.Drawing.Size(411, 30);
            this.menuAutomatePopOut.Text = "Pop-out-App";
            this.menuAutomatePopOut.Click += new System.EventHandler(this.menuAutomatePopOut_Click);
            // 
            // menuAutomateSeparator
            // 
            this.menuAutomateSeparator.Name = "menuAutomateSeparator";
            this.menuAutomateSeparator.Size = new System.Drawing.Size(408, 6);
            // 
            // menuAutomateInfo
            // 
            this.menuAutomateInfo.Name = "menuAutomateInfo";
            this.menuAutomateInfo.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateInfo.Text = "Info";
            this.menuAutomateInfo.Click += new System.EventHandler(this.menuAutomateInfo_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(470, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 862);
            this.panel1.TabIndex = 146;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(60, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(345, 94);
            this.lblHeader.TabIndex = 159;
            this.lblHeader.Text = "Automate tasks with\r\nPowerUI";
            // 
            // lstPS
            // 
            this.lstPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPS.BackColor = System.Drawing.Color.White;
            this.lstPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPS.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPS.ForeColor = System.Drawing.Color.Black;
            this.lstPS.FormattingEnabled = true;
            this.lstPS.HorizontalScrollbar = true;
            this.lstPS.Location = new System.Drawing.Point(13, 153);
            this.lstPS.Name = "lstPS";
            this.lstPS.Size = new System.Drawing.Size(476, 240);
            this.lstPS.Sorted = true;
            this.lstPS.TabIndex = 157;
            this.lstPS.SelectedIndexChanged += new System.EventHandler(this.lstPS_SelectedIndexChanged);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(2, 61);
            this.progress.MarqueeAnimationSpeed = 30;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(481, 5);
            this.progress.TabIndex = 156;
            this.progress.Visible = false;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDesc.BackColor = System.Drawing.Color.White;
            this.rtbDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDesc.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbDesc.Location = new System.Drawing.Point(68, 175);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(396, 592);
            this.rtbDesc.TabIndex = 153;
            this.rtbDesc.Text = "";
            this.rtbDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbDesc_LinkClicked);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.rtbDesc);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(470, 862);
            this.pnlLeft.TabIndex = 161;
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPS.BackColor = System.Drawing.Color.LavenderBlush;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.ForeColor = System.Drawing.Color.Black;
            this.rtbPS.HideSelection = false;
            this.rtbPS.Location = new System.Drawing.Point(2, 110);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbPS.Size = new System.Drawing.Size(490, 207);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = resources.GetString("rtbPS.Text");
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.Black;
            this.lnkSubHeader.Location = new System.Drawing.Point(2, 40);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(478, 20);
            this.lnkSubHeader.TabIndex = 172;
            // 
            // lblScripts
            // 
            this.lblScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScripts.AutoEllipsis = true;
            this.lblScripts.AutoSize = true;
            this.lblScripts.BackColor = System.Drawing.Color.White;
            this.lblScripts.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScripts.ForeColor = System.Drawing.Color.Black;
            this.lblScripts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScripts.Location = new System.Drawing.Point(8, 129);
            this.lblScripts.Name = "lblScripts";
            this.lblScripts.Size = new System.Drawing.Size(174, 21);
            this.lblScripts.TabIndex = 173;
            this.lblScripts.Text = "Run PowerShell Script";
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.txtScriptName);
            this.pnlTop.Controls.Add(this.lblCode);
            this.pnlTop.Controls.Add(this.btnAutomateOnTheFly);
            this.pnlTop.Controls.Add(this.rtbPS);
            this.pnlTop.Controls.Add(this.lnkSubHeader);
            this.pnlTop.Controls.Add(this.progress);
            this.pnlTop.Location = new System.Drawing.Point(470, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(492, 380);
            this.pnlTop.TabIndex = 174;
            // 
            // txtScriptName
            // 
            this.txtScriptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtScriptName.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScriptName.ForeColor = System.Drawing.Color.Gray;
            this.txtScriptName.Location = new System.Drawing.Point(3, 10);
            this.txtScriptName.Multiline = true;
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(486, 23);
            this.txtScriptName.TabIndex = 175;
            this.txtScriptName.Text = "Script Name";
            this.txtScriptName.Click += new System.EventHandler(this.txtScriptName_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoEllipsis = true;
            this.lblCode.BackColor = System.Drawing.Color.MistyRose;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCode.Location = new System.Drawing.Point(0, 82);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(97, 21);
            this.lblCode.TabIndex = 174;
            this.lblCode.Text = "Check Code";
            // 
            // btnAutomateOnTheFly
            // 
            this.btnAutomateOnTheFly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutomateOnTheFly.AutoEllipsis = true;
            this.btnAutomateOnTheFly.BackColor = System.Drawing.Color.Magenta;
            this.btnAutomateOnTheFly.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnAutomateOnTheFly.FlatAppearance.BorderSize = 0;
            this.btnAutomateOnTheFly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomateOnTheFly.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomateOnTheFly.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutomateOnTheFly.Location = new System.Drawing.Point(0, 323);
            this.btnAutomateOnTheFly.Name = "btnAutomateOnTheFly";
            this.btnAutomateOnTheFly.Size = new System.Drawing.Size(492, 47);
            this.btnAutomateOnTheFly.TabIndex = 155;
            this.btnAutomateOnTheFly.Text = "RUN CODE ON-THE-FLY\r\n";
            this.btnAutomateOnTheFly.UseVisualStyleBackColor = false;
            this.btnAutomateOnTheFly.Click += new System.EventHandler(this.btnAutomateOnTheFly_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.lblCategories);
            this.pnlBottom.Controls.Add(this.lstCategory);
            this.pnlBottom.Controls.Add(this.btnAutomate);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.lblScripts);
            this.pnlBottom.Controls.Add(this.lstPS);
            this.pnlBottom.Location = new System.Drawing.Point(470, 380);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(492, 482);
            this.pnlBottom.TabIndex = 174;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategories.AutoEllipsis = true;
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.White;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.Black;
            this.lblCategories.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCategories.Location = new System.Drawing.Point(22, 12);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(101, 21);
            this.lblCategories.TabIndex = 175;
            this.lblCategories.Text = "Categories /";
            // 
            // lstCategory
            // 
            this.lstCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCategory.BackColor = System.Drawing.Color.White;
            this.lstCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCategory.ColumnWidth = 70;
            this.lstCategory.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategory.ForeColor = System.Drawing.Color.Black;
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 21;
            this.lstCategory.Location = new System.Drawing.Point(26, 36);
            this.lstCategory.MultiColumn = true;
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(463, 84);
            this.lstCategory.TabIndex = 174;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // btnAutomate
            // 
            this.btnAutomate.AutoEllipsis = true;
            this.btnAutomate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAutomate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAutomate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAutomate.FlatAppearance.BorderSize = 0;
            this.btnAutomate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomate.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomate.ForeColor = System.Drawing.Color.White;
            this.btnAutomate.Location = new System.Drawing.Point(0, 399);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(492, 47);
            this.btnAutomate.TabIndex = 154;
            this.btnAutomate.Text = "RUN SELECTED\r\n";
            this.btnAutomate.UseVisualStyleBackColor = false;
            this.btnAutomate.Click += new System.EventHandler(this.btnAutomate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoEllipsis = true;
            this.btnCancel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(492, 36);
            this.btnCancel.TabIndex = 160;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoEllipsis = true;
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1020, 104);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 40);
            this.btnEdit.TabIndex = 175;
            this.btnEdit.Text = "Script Editor";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAutomateMenu
            // 
            this.btnAutomateMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutomateMenu.BackColor = System.Drawing.Color.White;
            this.btnAutomateMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutomateMenu.FlatAppearance.BorderSize = 0;
            this.btnAutomateMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomateMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomateMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAutomateMenu.Location = new System.Drawing.Point(1161, 0);
            this.btnAutomateMenu.Name = "btnAutomateMenu";
            this.btnAutomateMenu.Size = new System.Drawing.Size(48, 51);
            this.btnAutomateMenu.TabIndex = 155;
            this.btnAutomateMenu.UseVisualStyleBackColor = false;
            this.btnAutomateMenu.Click += new System.EventHandler(this.btnAutomateMenu_Click);
            // 
            // AutomateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAutomateMenu);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AutomateWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerUI";
            this.Load += new System.EventHandler(this.AutomateWindow_Load);
            this.menuAutomate.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuAutomateImport;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateEdit;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateSave;
        private System.Windows.Forms.ContextMenuStrip menuAutomate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.CheckedListBox lstPS;
        private System.Windows.Forms.ProgressBar progress;
        public System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateApplied;
        private System.Windows.Forms.ToolStripMenuItem menuAutomatePopOut;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateInfo;
        private System.Windows.Forms.ToolStripSeparator menuAutomateSeparator;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.Label lblScripts;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label lblCategories;
        private Controls.RoundedButton btnCancel;
        private Controls.RoundedButton btnAutomateMenu;
        private Controls.RoundedButton btnAutomate;
        private Controls.RoundedButton btnAutomateOnTheFly;
        private Controls.RoundedButton btnEdit;
    }
}