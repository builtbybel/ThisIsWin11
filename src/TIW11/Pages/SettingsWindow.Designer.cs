
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
            this.lblHeartFillEmoji = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCLISwitch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.rtbAbout.Location = new System.Drawing.Point(507, 400);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ReadOnly = true;
            this.rtbAbout.Size = new System.Drawing.Size(697, 422);
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
            this.btnCheckForUpdates.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckForUpdates.FlatAppearance.BorderSize = 2;
            this.btnCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckForUpdates.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckForUpdates.ForeColor = System.Drawing.Color.White;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(65, 186);
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
            this.lblSettingsUpdates.Location = new System.Drawing.Point(60, 100);
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
            this.lblSettingsAbout.Font = new System.Drawing.Font("Segoe UI Variable Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettingsAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsAbout.Location = new System.Drawing.Point(501, 100);
            this.lblSettingsAbout.Name = "lblSettingsAbout";
            this.lblSettingsAbout.Size = new System.Drawing.Size(163, 36);
            this.lblSettingsAbout.TabIndex = 157;
            this.lblSettingsAbout.Text = "ThisIsWin11";
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
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblAppMediaGitHub.Text = "GitHub (1.5k Starred)";
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
            this.lblAppMain.Location = new System.Drawing.Point(503, 186);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(505, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 173;
            this.label1.Text = "with";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(567, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 174;
            this.label2.Text = "Builtbybel";
            // 
            // btnCLISwitch
            // 
            this.btnCLISwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCLISwitch.AutoEllipsis = true;
            this.btnCLISwitch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCLISwitch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCLISwitch.FlatAppearance.BorderSize = 0;
            this.btnCLISwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLISwitch.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLISwitch.ForeColor = System.Drawing.Color.Black;
            this.btnCLISwitch.Location = new System.Drawing.Point(505, 823);
            this.btnCLISwitch.Name = "btnCLISwitch";
            this.btnCLISwitch.Size = new System.Drawing.Size(140, 27);
            this.btnCLISwitch.TabIndex = 175;
            this.btnCLISwitch.Text = "Command-line options";
            this.btnCLISwitch.UseVisualStyleBackColor = false;
            this.btnCLISwitch.Click += new System.EventHandler(this.btnCLISwitch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(505, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 17);
            this.label3.TabIndex = 176;
            this.label3.Text = "OS created by Microsoft and fixed by the community.";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCLISwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeartFillEmoji);
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
        private System.Windows.Forms.Label lblHeartFillEmoji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCLISwitch;
        private System.Windows.Forms.Label label3;
    }
}