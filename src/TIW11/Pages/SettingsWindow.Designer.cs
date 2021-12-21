
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
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCheckForUpdates = new System.Windows.Forms.Button();
            this.lblSettingsUpdates = new System.Windows.Forms.Label();
            this.lblSettingsAbout = new System.Windows.Forms.Label();
            this.lblAssemblyInfo = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblAssembly = new System.Windows.Forms.LinkLabel();
            this.lblAppMediaGitHub = new System.Windows.Forms.LinkLabel();
            this.lblAppMain = new System.Windows.Forms.Label();
            this.lblAppMediaTwitter = new System.Windows.Forms.LinkLabel();
            this.lblAppMediaPayPal = new System.Windows.Forms.LinkLabel();
            this.btnAppMediaGitHubIssues = new System.Windows.Forms.Button();
            this.btnGoBackToPast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAbout
            // 
            this.rtbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAbout.BackColor = System.Drawing.Color.White;
            this.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbout.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAbout.ForeColor = System.Drawing.Color.Black;
            this.rtbAbout.Location = new System.Drawing.Point(507, 383);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ReadOnly = true;
            this.rtbAbout.Size = new System.Drawing.Size(691, 432);
            this.rtbAbout.TabIndex = 0;
            this.rtbAbout.Text = "";
            this.rtbAbout.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbAbout_LinkClicked);
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
            this.lblHeader.Location = new System.Drawing.Point(62, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(137, 43);
            this.lblHeader.TabIndex = 135;
            this.lblHeader.Text = "Settings";
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.AutoSize = true;
            this.btnCheckForUpdates.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckForUpdates.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckForUpdates.FlatAppearance.BorderSize = 2;
            this.btnCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckForUpdates.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckForUpdates.ForeColor = System.Drawing.Color.White;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(70, 186);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(213, 34);
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
            this.lblSettingsUpdates.Location = new System.Drawing.Point(64, 100);
            this.lblSettingsUpdates.Name = "lblSettingsUpdates";
            this.lblSettingsUpdates.Size = new System.Drawing.Size(116, 36);
            this.lblSettingsUpdates.TabIndex = 156;
            this.lblSettingsUpdates.Text = "Updates";
            // 
            // lblSettingsAbout
            // 
            this.lblSettingsAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSettingsAbout.AutoEllipsis = true;
            this.lblSettingsAbout.AutoSize = true;
            this.lblSettingsAbout.BackColor = System.Drawing.Color.White;
            this.lblSettingsAbout.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettingsAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsAbout.Location = new System.Drawing.Point(501, 100);
            this.lblSettingsAbout.Name = "lblSettingsAbout";
            this.lblSettingsAbout.Size = new System.Drawing.Size(196, 36);
            this.lblSettingsAbout.TabIndex = 157;
            this.lblSettingsAbout.Text = "About this app";
            // 
            // lblAssemblyInfo
            // 
            this.lblAssemblyInfo.AutoEllipsis = true;
            this.lblAssemblyInfo.AutoSize = true;
            this.lblAssemblyInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAssemblyInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyInfo.Location = new System.Drawing.Point(67, 151);
            this.lblAssemblyInfo.Name = "lblAssemblyInfo";
            this.lblAssemblyInfo.Size = new System.Drawing.Size(77, 17);
            this.lblAssemblyInfo.TabIndex = 158;
            this.lblAssemblyInfo.Text = "App Version:";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(70, 228);
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
            this.lblAssembly.Location = new System.Drawing.Point(150, 151);
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
            this.lblAppMediaGitHub.Location = new System.Drawing.Point(503, 228);
            this.lblAppMediaGitHub.Name = "lblAppMediaGitHub";
            this.lblAppMediaGitHub.Size = new System.Drawing.Size(336, 22);
            this.lblAppMediaGitHub.TabIndex = 166;
            this.lblAppMediaGitHub.TabStop = true;
            this.lblAppMediaGitHub.Text = "GitHub (1.4k Starred)";
            this.lblAppMediaGitHub.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAppMediaGitHub_LinkClicked);
            // 
            // lblAppMain
            // 
            this.lblAppMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppMain.AutoEllipsis = true;
            this.lblAppMain.AutoSize = true;
            this.lblAppMain.BackColor = System.Drawing.Color.White;
            this.lblAppMain.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppMain.ForeColor = System.Drawing.Color.Black;
            this.lblAppMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAppMain.Location = new System.Drawing.Point(501, 150);
            this.lblAppMain.Name = "lblAppMain";
            this.lblAppMain.Size = new System.Drawing.Size(66, 20);
            this.lblAppMain.TabIndex = 167;
            this.lblAppMain.Text = "App Info";
            // 
            // lblAppMediaTwitter
            // 
            this.lblAppMediaTwitter.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaTwitter.AutoEllipsis = true;
            this.lblAppMediaTwitter.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppMediaTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAppMediaTwitter.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppMediaTwitter.Location = new System.Drawing.Point(503, 259);
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
            this.lblAppMediaPayPal.Location = new System.Drawing.Point(503, 291);
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
            this.btnAppMediaGitHubIssues.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMediaGitHubIssues.Location = new System.Drawing.Point(503, 330);
            this.btnAppMediaGitHubIssues.Name = "btnAppMediaGitHubIssues";
            this.btnAppMediaGitHubIssues.Size = new System.Drawing.Size(119, 32);
            this.btnAppMediaGitHubIssues.TabIndex = 171;
            this.btnAppMediaGitHubIssues.Text = "Send feedback";
            this.btnAppMediaGitHubIssues.UseVisualStyleBackColor = true;
            this.btnAppMediaGitHubIssues.Click += new System.EventHandler(this.btnAppMediaGitHubIssues_Click);
            // 
            // btnGoBackToPast
            // 
            this.btnGoBackToPast.AutoSize = true;
            this.btnGoBackToPast.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBackToPast.Location = new System.Drawing.Point(70, 249);
            this.btnGoBackToPast.Name = "btnGoBackToPast";
            this.btnGoBackToPast.Size = new System.Drawing.Size(143, 32);
            this.btnGoBackToPast.TabIndex = 173;
            this.btnGoBackToPast.Text = "Roll back to old UI";
            this.btnGoBackToPast.UseVisualStyleBackColor = true;
            this.btnGoBackToPast.Click += new System.EventHandler(this.btnGoBackToPast_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.btnGoBackToPast);
            this.Controls.Add(this.btnAppMediaGitHubIssues);
            this.Controls.Add(this.lblAppMediaPayPal);
            this.Controls.Add(this.lblAppMediaTwitter);
            this.Controls.Add(this.lblAppMain);
            this.Controls.Add(this.lblAppMediaGitHub);
            this.Controls.Add(this.lblAssembly);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblAssemblyInfo);
            this.Controls.Add(this.lblSettingsAbout);
            this.Controls.Add(this.lblSettingsUpdates);
            this.Controls.Add(this.btnCheckForUpdates);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.rtbAbout);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.Shown += new System.EventHandler(this.SettingsWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAbout;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSettingsUpdates;
        private System.Windows.Forms.Label lblSettingsAbout;
        public System.Windows.Forms.Button btnCheckForUpdates;
        public System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lblAssemblyInfo;
        public System.Windows.Forms.LinkLabel lblAssembly;
        private System.Windows.Forms.LinkLabel lblAppMediaGitHub;
        private System.Windows.Forms.Label lblAppMain;
        private System.Windows.Forms.LinkLabel lblAppMediaTwitter;
        private System.Windows.Forms.LinkLabel lblAppMediaPayPal;
        private System.Windows.Forms.Button btnAppMediaGitHubIssues;
        private System.Windows.Forms.Button btnGoBackToPast;
    }
}