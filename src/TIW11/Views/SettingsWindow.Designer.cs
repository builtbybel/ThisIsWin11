
namespace ThisIsWin11
{
    partial class SettingsWindow
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
            this.rtbSettingsAbout = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCheckForUpdates = new ThisIsWin11.Controls.RoundedButton();
            this.lblSettingsUpdates = new System.Windows.Forms.Label();
            this.lblSettingsApp = new System.Windows.Forms.Label();
            this.lblAssemblyInfo = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblAssembly = new System.Windows.Forms.LinkLabel();
            this.lblAppMediaGitHub = new System.Windows.Forms.LinkLabel();
            this.lblSettingsAppMain = new System.Windows.Forms.Label();
            this.lblAppMediaTwitter = new System.Windows.Forms.LinkLabel();
            this.lblAppMediaPayPal = new System.Windows.Forms.LinkLabel();
            this.btnAppMediaGitHubIssues = new ThisIsWin11.Controls.RoundedButton();
            this.lblHeartFillEmoji = new System.Windows.Forms.Label();
            this.lblSettingsSubWith = new System.Windows.Forms.Label();
            this.lblSettingsSubDev = new System.Windows.Forms.Label();
            this.lblSettingsAbout = new System.Windows.Forms.Label();
            this.btnSettingsMenu = new ThisIsWin11.Controls.RoundedButton();
            this.menuSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCLI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFeedbackHub = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.LinkLabel();
            this.lblSettingsMode = new System.Windows.Forms.Label();
            this.menuSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbSettingsAbout
            // 
            this.rtbSettingsAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSettingsAbout.BackColor = System.Drawing.Color.White;
            this.rtbSettingsAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSettingsAbout.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSettingsAbout.ForeColor = System.Drawing.Color.Black;
            this.rtbSettingsAbout.Location = new System.Drawing.Point(507, 400);
            this.rtbSettingsAbout.Name = "rtbSettingsAbout";
            this.rtbSettingsAbout.ReadOnly = true;
            this.rtbSettingsAbout.Size = new System.Drawing.Size(697, 450);
            this.rtbSettingsAbout.TabIndex = 0;
            this.rtbSettingsAbout.Text = "";
            this.rtbSettingsAbout.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbAbout_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(58, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(137, 43);
            this.lblHeader.TabIndex = 135;
            this.lblHeader.Text = "Settings";
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.AutoSize = true;
            this.btnCheckForUpdates.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckForUpdates.FlatAppearance.BorderSize = 0;
            this.btnCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckForUpdates.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckForUpdates.ForeColor = System.Drawing.Color.White;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(65, 186);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(213, 36);
            this.btnCheckForUpdates.TabIndex = 155;
            this.btnCheckForUpdates.Text = "Check for updates";
            this.btnCheckForUpdates.UseVisualStyleBackColor = false;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // lblSettingsUpdates
            // 
            this.lblSettingsUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsUpdates.AutoEllipsis = true;
            this.lblSettingsUpdates.AutoSize = true;
            this.lblSettingsUpdates.BackColor = System.Drawing.Color.White;
            this.lblSettingsUpdates.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettingsUpdates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsUpdates.Location = new System.Drawing.Point(60, 100);
            this.lblSettingsUpdates.Name = "lblSettingsUpdates";
            this.lblSettingsUpdates.Size = new System.Drawing.Size(116, 36);
            this.lblSettingsUpdates.TabIndex = 156;
            this.lblSettingsUpdates.Text = "Updates";
            // 
            // lblSettingsApp
            // 
            this.lblSettingsApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsApp.AutoEllipsis = true;
            this.lblSettingsApp.AutoSize = true;
            this.lblSettingsApp.BackColor = System.Drawing.Color.White;
            this.lblSettingsApp.Font = new System.Drawing.Font("Segoe UI Variable Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettingsApp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsApp.Location = new System.Drawing.Point(501, 100);
            this.lblSettingsApp.Name = "lblSettingsApp";
            this.lblSettingsApp.Size = new System.Drawing.Size(163, 36);
            this.lblSettingsApp.TabIndex = 157;
            this.lblSettingsApp.Text = "ThisIsWin11";
            // 
            // lblAssemblyInfo
            // 
            this.lblAssemblyInfo.AutoEllipsis = true;
            this.lblAssemblyInfo.AutoSize = true;
            this.lblAssemblyInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAssemblyInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyInfo.Location = new System.Drawing.Point(65, 151);
            this.lblAssemblyInfo.Name = "lblAssemblyInfo";
            this.lblAssemblyInfo.Size = new System.Drawing.Size(77, 17);
            this.lblAssemblyInfo.TabIndex = 158;
            this.lblAssemblyInfo.Text = "App Version:";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(65, 228);
            this.progress.MarqueeAnimationSpeed = 30;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(213, 5);
            this.progress.TabIndex = 163;
            this.progress.Visible = false;
            // 
            // lblAssembly
            // 
            this.lblAssembly.AutoSize = true;
            this.lblAssembly.BackColor = System.Drawing.Color.Transparent;
            this.lblAssembly.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssembly.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAssembly.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAssembly.Location = new System.Drawing.Point(148, 151);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(66, 17);
            this.lblAssembly.TabIndex = 165;
            this.lblAssembly.TabStop = true;
            this.lblAssembly.Text = "Assembly";
            this.lblAssembly.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAssembly.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAssembly_LinkClicked);
            // 
            // lblAppMediaGitHub
            // 
            this.lblAppMediaGitHub.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaGitHub.AutoEllipsis = true;
            this.lblAppMediaGitHub.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppMediaGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAppMediaGitHub.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaGitHub.Location = new System.Drawing.Point(505, 248);
            this.lblAppMediaGitHub.Name = "lblAppMediaGitHub";
            this.lblAppMediaGitHub.Size = new System.Drawing.Size(336, 22);
            this.lblAppMediaGitHub.TabIndex = 166;
            this.lblAppMediaGitHub.TabStop = true;
            this.lblAppMediaGitHub.Text = "GitHub (2.6k Starred)";
            this.lblAppMediaGitHub.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAppMediaGitHub_LinkClicked);
            // 
            // lblSettingsAppMain
            // 
            this.lblSettingsAppMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsAppMain.AutoEllipsis = true;
            this.lblSettingsAppMain.AutoSize = true;
            this.lblSettingsAppMain.BackColor = System.Drawing.Color.White;
            this.lblSettingsAppMain.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsAppMain.ForeColor = System.Drawing.Color.Black;
            this.lblSettingsAppMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsAppMain.Location = new System.Drawing.Point(503, 186);
            this.lblSettingsAppMain.Name = "lblSettingsAppMain";
            this.lblSettingsAppMain.Size = new System.Drawing.Size(66, 20);
            this.lblSettingsAppMain.TabIndex = 167;
            this.lblSettingsAppMain.Text = "App Info";
            // 
            // lblAppMediaTwitter
            // 
            this.lblAppMediaTwitter.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaTwitter.AutoEllipsis = true;
            this.lblAppMediaTwitter.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppMediaTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAppMediaTwitter.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaTwitter.Location = new System.Drawing.Point(505, 279);
            this.lblAppMediaTwitter.Name = "lblAppMediaTwitter";
            this.lblAppMediaTwitter.Size = new System.Drawing.Size(336, 22);
            this.lblAppMediaTwitter.TabIndex = 168;
            this.lblAppMediaTwitter.TabStop = true;
            this.lblAppMediaTwitter.Text = "Follow me on Twitter";
            this.lblAppMediaTwitter.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAppMediaTwitter_LinkClicked);
            // 
            // lblAppMediaPayPal
            // 
            this.lblAppMediaPayPal.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaPayPal.AutoEllipsis = true;
            this.lblAppMediaPayPal.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppMediaPayPal.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAppMediaPayPal.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaPayPal.Location = new System.Drawing.Point(505, 311);
            this.lblAppMediaPayPal.Name = "lblAppMediaPayPal";
            this.lblAppMediaPayPal.Size = new System.Drawing.Size(336, 22);
            this.lblAppMediaPayPal.TabIndex = 169;
            this.lblAppMediaPayPal.TabStop = true;
            this.lblAppMediaPayPal.Text = "Donate to Belim from @builtbybel ";
            this.lblAppMediaPayPal.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaPayPal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAppMediaPayPal_LinkClicked);
            // 
            // btnAppMediaGitHubIssues
            // 
            this.btnAppMediaGitHubIssues.AutoSize = true;
            this.btnAppMediaGitHubIssues.FlatAppearance.BorderSize = 0;
            this.btnAppMediaGitHubIssues.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMediaGitHubIssues.Location = new System.Drawing.Point(505, 350);
            this.btnAppMediaGitHubIssues.Name = "btnAppMediaGitHubIssues";
            this.btnAppMediaGitHubIssues.Size = new System.Drawing.Size(119, 32);
            this.btnAppMediaGitHubIssues.TabIndex = 171;
            this.btnAppMediaGitHubIssues.Text = "Send feedback";
            this.btnAppMediaGitHubIssues.UseVisualStyleBackColor = true;
            this.btnAppMediaGitHubIssues.Click += new System.EventHandler(this.btnAppMediaGitHubIssues_Click);
            // 
            // lblHeartFillEmoji
            // 
            this.lblHeartFillEmoji.BackColor = System.Drawing.Color.White;
            this.lblHeartFillEmoji.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeartFillEmoji.ForeColor = System.Drawing.Color.HotPink;
            this.lblHeartFillEmoji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeartFillEmoji.Location = new System.Drawing.Point(539, 157);
            this.lblHeartFillEmoji.Name = "lblHeartFillEmoji";
            this.lblHeartFillEmoji.Size = new System.Drawing.Size(32, 25);
            this.lblHeartFillEmoji.TabIndex = 172;
            // 
            // lblSettingsSubWith
            // 
            this.lblSettingsSubWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsSubWith.AutoEllipsis = true;
            this.lblSettingsSubWith.AutoSize = true;
            this.lblSettingsSubWith.BackColor = System.Drawing.Color.White;
            this.lblSettingsSubWith.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsSubWith.ForeColor = System.Drawing.Color.Gray;
            this.lblSettingsSubWith.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsSubWith.Location = new System.Drawing.Point(505, 157);
            this.lblSettingsSubWith.Name = "lblSettingsSubWith";
            this.lblSettingsSubWith.Size = new System.Drawing.Size(38, 20);
            this.lblSettingsSubWith.TabIndex = 173;
            this.lblSettingsSubWith.Text = "with";
            // 
            // lblSettingsSubDev
            // 
            this.lblSettingsSubDev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsSubDev.AutoEllipsis = true;
            this.lblSettingsSubDev.AutoSize = true;
            this.lblSettingsSubDev.BackColor = System.Drawing.Color.White;
            this.lblSettingsSubDev.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsSubDev.ForeColor = System.Drawing.Color.Gray;
            this.lblSettingsSubDev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsSubDev.Location = new System.Drawing.Point(567, 157);
            this.lblSettingsSubDev.Name = "lblSettingsSubDev";
            this.lblSettingsSubDev.Size = new System.Drawing.Size(78, 20);
            this.lblSettingsSubDev.TabIndex = 174;
            this.lblSettingsSubDev.Text = "Builtbybel";
            // 
            // lblSettingsAbout
            // 
            this.lblSettingsAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsAbout.AutoEllipsis = true;
            this.lblSettingsAbout.AutoSize = true;
            this.lblSettingsAbout.BackColor = System.Drawing.Color.White;
            this.lblSettingsAbout.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsAbout.ForeColor = System.Drawing.Color.Gray;
            this.lblSettingsAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsAbout.Location = new System.Drawing.Point(505, 136);
            this.lblSettingsAbout.Name = "lblSettingsAbout";
            this.lblSettingsAbout.Size = new System.Drawing.Size(306, 17);
            this.lblSettingsAbout.TabIndex = 176;
            this.lblSettingsAbout.Text = "OS made by Microsoft and fixed by the community.";
            // 
            // btnSettingsMenu
            // 
            this.btnSettingsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsMenu.BackColor = System.Drawing.Color.White;
            this.btnSettingsMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettingsMenu.FlatAppearance.BorderSize = 0;
            this.btnSettingsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettingsMenu.Location = new System.Drawing.Point(1161, 0);
            this.btnSettingsMenu.Name = "btnSettingsMenu";
            this.btnSettingsMenu.Size = new System.Drawing.Size(48, 51);
            this.btnSettingsMenu.TabIndex = 178;
            this.btnSettingsMenu.UseVisualStyleBackColor = false;
            this.btnSettingsMenu.Click += new System.EventHandler(this.btnSettingsMenu_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.BackColor = System.Drawing.Color.White;
            this.menuSettings.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCLI,
            this.menuFeedbackHub});
            this.menuSettings.Name = "menuMain";
            this.menuSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuSettings.Size = new System.Drawing.Size(318, 64);
            // 
            // menuCLI
            // 
            this.menuCLI.Name = "menuCLI";
            this.menuCLI.Size = new System.Drawing.Size(317, 30);
            this.menuCLI.Text = "Command-line switches";
            this.menuCLI.Click += new System.EventHandler(this.menuCLI_Click);
            // 
            // menuFeedbackHub
            // 
            this.menuFeedbackHub.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFeedbackHub.Name = "menuFeedbackHub";
            this.menuFeedbackHub.Size = new System.Drawing.Size(317, 30);
            this.menuFeedbackHub.Text = "Send Feedback to Microsoft";
            this.menuFeedbackHub.Click += new System.EventHandler(this.menuFeedbackHub_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 180;
            this.label1.Text = "App Design:";
            // 
            // lblTheme
            // 
            this.lblTheme.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblTheme.LinkColor = System.Drawing.Color.HotPink;
            this.lblTheme.Location = new System.Drawing.Point(148, 311);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(16, 17);
            this.lblTheme.TabIndex = 181;
            this.lblTheme.TabStop = true;
            this.lblTheme.Text = "#";
            this.lblTheme.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblTheme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTheme_LinkClicked);
            // 
            // lblSettingsMode
            // 
            this.lblSettingsMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsMode.AutoEllipsis = true;
            this.lblSettingsMode.AutoSize = true;
            this.lblSettingsMode.BackColor = System.Drawing.Color.White;
            this.lblSettingsMode.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettingsMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsMode.Location = new System.Drawing.Point(60, 266);
            this.lblSettingsMode.Name = "lblSettingsMode";
            this.lblSettingsMode.Size = new System.Drawing.Size(86, 36);
            this.lblSettingsMode.TabIndex = 182;
            this.lblSettingsMode.Text = "Mode";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.lblSettingsMode);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSettingsMenu);
            this.Controls.Add(this.lblSettingsAbout);
            this.Controls.Add(this.lblSettingsSubDev);
            this.Controls.Add(this.lblSettingsSubWith);
            this.Controls.Add(this.lblHeartFillEmoji);
            this.Controls.Add(this.btnAppMediaGitHubIssues);
            this.Controls.Add(this.lblAppMediaPayPal);
            this.Controls.Add(this.lblAppMediaTwitter);
            this.Controls.Add(this.lblSettingsAppMain);
            this.Controls.Add(this.lblAppMediaGitHub);
            this.Controls.Add(this.lblAssembly);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblAssemblyInfo);
            this.Controls.Add(this.lblSettingsApp);
            this.Controls.Add(this.lblSettingsUpdates);
            this.Controls.Add(this.btnCheckForUpdates);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.rtbSettingsAbout);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.Shown += new System.EventHandler(this.SettingsWindow_Shown);
            this.menuSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSettingsAbout;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSettingsUpdates;
        private System.Windows.Forms.Label lblSettingsApp;
        public System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lblAssemblyInfo;
        public System.Windows.Forms.LinkLabel lblAssembly;
        private System.Windows.Forms.LinkLabel lblAppMediaGitHub;
        private System.Windows.Forms.Label lblSettingsAppMain;
        private System.Windows.Forms.LinkLabel lblAppMediaTwitter;
        private System.Windows.Forms.LinkLabel lblAppMediaPayPal;
        private Controls.RoundedButton btnAppMediaGitHubIssues;
        private System.Windows.Forms.Label lblHeartFillEmoji;
        private System.Windows.Forms.Label lblSettingsSubWith;
        private System.Windows.Forms.Label lblSettingsSubDev;
        private System.Windows.Forms.Label lblSettingsAbout;
        private System.Windows.Forms.ContextMenuStrip menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuCLI;
        private System.Windows.Forms.ToolStripMenuItem menuFeedbackHub;
        private Controls.RoundedButton btnSettingsMenu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel lblTheme;
        private System.Windows.Forms.Label lblSettingsMode;
        public System.Windows.Forms.Button btnCheckForUpdates;
    }
}