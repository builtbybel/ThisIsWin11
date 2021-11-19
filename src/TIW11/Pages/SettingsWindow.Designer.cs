
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
            this.lblInstalledVersion = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // rtbAbout
            // 
            this.rtbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAbout.BackColor = System.Drawing.Color.White;
            this.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbout.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAbout.Location = new System.Drawing.Point(30, 277);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ReadOnly = true;
            this.rtbAbout.Size = new System.Drawing.Size(1051, 481);
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
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(24, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(103, 32);
            this.lblHeader.TabIndex = 135;
            this.lblHeader.Text = "Settings";
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCheckForUpdates.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckForUpdates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckForUpdates.ForeColor = System.Drawing.Color.White;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(30, 156);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(213, 30);
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
            this.lblSettingsUpdates.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsUpdates.ForeColor = System.Drawing.Color.Black;
            this.lblSettingsUpdates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsUpdates.Location = new System.Drawing.Point(24, 76);
            this.lblSettingsUpdates.Name = "lblSettingsUpdates";
            this.lblSettingsUpdates.Size = new System.Drawing.Size(105, 32);
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
            this.lblSettingsAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsAbout.ForeColor = System.Drawing.Color.Black;
            this.lblSettingsAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsAbout.Location = new System.Drawing.Point(24, 220);
            this.lblSettingsAbout.Name = "lblSettingsAbout";
            this.lblSettingsAbout.Size = new System.Drawing.Size(68, 32);
            this.lblSettingsAbout.TabIndex = 157;
            this.lblSettingsAbout.Text = "Infos";
            // 
            // lblInstalledVersion
            // 
            this.lblInstalledVersion.AutoEllipsis = true;
            this.lblInstalledVersion.AutoSize = true;
            this.lblInstalledVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstalledVersion.Location = new System.Drawing.Point(27, 125);
            this.lblInstalledVersion.Name = "lblInstalledVersion";
            this.lblInstalledVersion.Size = new System.Drawing.Size(106, 17);
            this.lblInstalledVersion.TabIndex = 158;
            this.lblInstalledVersion.Text = "Installed Version:";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(30, 192);
            this.progress.MarqueeAnimationSpeed = 30;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(213, 5);
            this.progress.TabIndex = 163;
            this.progress.Visible = false;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblInstalledVersion);
            this.Controls.Add(this.lblSettingsAbout);
            this.Controls.Add(this.lblSettingsUpdates);
            this.Controls.Add(this.btnCheckForUpdates);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.rtbAbout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThisIsWin11 Settings";
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
        private System.Windows.Forms.Label lblInstalledVersion;
        public System.Windows.Forms.Button btnCheckForUpdates;
        public System.Windows.Forms.ProgressBar progress;
    }
}