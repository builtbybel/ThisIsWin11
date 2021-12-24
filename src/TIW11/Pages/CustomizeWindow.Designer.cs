
namespace ThisIsWin11
{
    partial class CustomizeWindow
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
            this.btnSystemMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSystemCheck = new System.Windows.Forms.Button();
            this.menuSystem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSystemImportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemExportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemExportLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSystemVersioning = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tvwAssessments = new System.Windows.Forms.TreeView();
            this.btnSystemFix = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.btnSystemUndo = new System.Windows.Forms.Button();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlRight = new System.Windows.Forms.Panel();
            this.menuSystem.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSystemMenu
            // 
            this.btnSystemMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemMenu.BackColor = System.Drawing.Color.White;
            this.btnSystemMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSystemMenu.FlatAppearance.BorderSize = 0;
            this.btnSystemMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSystemMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemMenu.Location = new System.Drawing.Point(627, -1);
            this.btnSystemMenu.Name = "btnSystemMenu";
            this.btnSystemMenu.Size = new System.Drawing.Size(48, 51);
            this.btnSystemMenu.TabIndex = 162;
            this.btnSystemMenu.UseVisualStyleBackColor = false;
            this.btnSystemMenu.Click += new System.EventHandler(this.btnSystemMenu_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(60, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(390, 94);
            this.lblHeader.TabIndex = 161;
            this.lblHeader.Text = "Customize Windows 11 \r\nwith OpenTweaks";
            // 
            // btnSystemCheck
            // 
            this.btnSystemCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSystemCheck.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSystemCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSystemCheck.FlatAppearance.BorderSize = 2;
            this.btnSystemCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemCheck.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemCheck.ForeColor = System.Drawing.Color.White;
            this.btnSystemCheck.Location = new System.Drawing.Point(68, 788);
            this.btnSystemCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnSystemCheck.Name = "btnSystemCheck";
            this.btnSystemCheck.Size = new System.Drawing.Size(213, 32);
            this.btnSystemCheck.TabIndex = 159;
            this.btnSystemCheck.Text = "Check";
            this.btnSystemCheck.UseVisualStyleBackColor = false;
            this.btnSystemCheck.Click += new System.EventHandler(this.btnSystemCheck_Click);
            // 
            // menuSystem
            // 
            this.menuSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuSystem.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystemImportProfile,
            this.menuSystemExportProfile,
            this.menuSystemExportLog,
            this.menuSystemSelect,
            this.menuSystemPopOut,
            this.toolStripSeparator1,
            this.menuSystemVersioning});
            this.menuSystem.Name = "menuMain";
            this.menuSystem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuSystem.Size = new System.Drawing.Size(201, 190);
            // 
            // menuSystemImportProfile
            // 
            this.menuSystemImportProfile.Name = "menuSystemImportProfile";
            this.menuSystemImportProfile.Size = new System.Drawing.Size(200, 30);
            this.menuSystemImportProfile.Text = "Import profile";
            this.menuSystemImportProfile.Click += new System.EventHandler(this.menuSystemImportProfile_Click);
            // 
            // menuSystemExportProfile
            // 
            this.menuSystemExportProfile.Name = "menuSystemExportProfile";
            this.menuSystemExportProfile.Size = new System.Drawing.Size(200, 30);
            this.menuSystemExportProfile.Text = "Export profile";
            this.menuSystemExportProfile.Click += new System.EventHandler(this.menuSystemExportProfile_Click);
            // 
            // menuSystemExportLog
            // 
            this.menuSystemExportLog.Name = "menuSystemExportLog";
            this.menuSystemExportLog.Size = new System.Drawing.Size(200, 30);
            this.menuSystemExportLog.Text = "Export log";
            this.menuSystemExportLog.Click += new System.EventHandler(this.menuSystemExportLog_Click);
            // 
            // menuSystemSelect
            // 
            this.menuSystemSelect.Name = "menuSystemSelect";
            this.menuSystemSelect.Size = new System.Drawing.Size(200, 30);
            this.menuSystemSelect.Text = "Select all";
            this.menuSystemSelect.Click += new System.EventHandler(this.menuSystemSelect_Click);
            // 
            // menuSystemPopOut
            // 
            this.menuSystemPopOut.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSystemPopOut.Name = "menuSystemPopOut";
            this.menuSystemPopOut.Size = new System.Drawing.Size(200, 30);
            this.menuSystemPopOut.Text = "Pop-out-App";
            this.menuSystemPopOut.Click += new System.EventHandler(this.menuSystemPopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // menuSystemVersioning
            // 
            this.menuSystemVersioning.Name = "menuSystemVersioning";
            this.menuSystemVersioning.Size = new System.Drawing.Size(200, 30);
            this.menuSystemVersioning.Text = "Info";
            this.menuSystemVersioning.Click += new System.EventHandler(this.menuSystemInfo_Click);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(0, 56);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(666, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // tvwAssessments
            // 
            this.tvwAssessments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwAssessments.BackColor = System.Drawing.Color.White;
            this.tvwAssessments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwAssessments.CheckBoxes = true;
            this.tvwAssessments.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwAssessments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvwAssessments.HideSelection = false;
            this.tvwAssessments.HotTracking = true;
            this.tvwAssessments.ItemHeight = 30;
            this.tvwAssessments.Location = new System.Drawing.Point(3, 82);
            this.tvwAssessments.Name = "tvwAssessments";
            this.tvwAssessments.ShowLines = false;
            this.tvwAssessments.ShowNodeToolTips = true;
            this.tvwAssessments.Size = new System.Drawing.Size(672, 768);
            this.tvwAssessments.TabIndex = 168;
            this.tvwAssessments.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwAssessments_AfterCheck);
            // 
            // btnSystemFix
            // 
            this.btnSystemFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSystemFix.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSystemFix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSystemFix.FlatAppearance.BorderSize = 2;
            this.btnSystemFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemFix.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemFix.ForeColor = System.Drawing.Color.White;
            this.btnSystemFix.Location = new System.Drawing.Point(305, 788);
            this.btnSystemFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnSystemFix.Name = "btnSystemFix";
            this.btnSystemFix.Size = new System.Drawing.Size(213, 32);
            this.btnSystemFix.TabIndex = 167;
            this.btnSystemFix.Text = "Fix issues";
            this.btnSystemFix.UseVisualStyleBackColor = false;
            this.btnSystemFix.Click += new System.EventHandler(this.btnSystemFix_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.rtbPS);
            this.pnlLeft.Controls.Add(this.btnSystemUndo);
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Controls.Add(this.btnSystemCheck);
            this.pnlLeft.Controls.Add(this.btnSystemFix);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(532, 862);
            this.pnlLeft.TabIndex = 170;
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbPS.BackColor = System.Drawing.Color.White;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbPS.HideSelection = false;
            this.rtbPS.Location = new System.Drawing.Point(68, 175);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.ReadOnly = true;
            this.rtbPS.Size = new System.Drawing.Size(454, 594);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // btnSystemUndo
            // 
            this.btnSystemUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemUndo.BackColor = System.Drawing.Color.White;
            this.btnSystemUndo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSystemUndo.FlatAppearance.BorderSize = 0;
            this.btnSystemUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnSystemUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemUndo.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemUndo.ForeColor = System.Drawing.Color.Black;
            this.btnSystemUndo.Location = new System.Drawing.Point(481, 0);
            this.btnSystemUndo.Name = "btnSystemUndo";
            this.btnSystemUndo.Size = new System.Drawing.Size(48, 51);
            this.btnSystemUndo.TabIndex = 174;
            this.tt.SetToolTip(this.btnSystemUndo, "Restore default Windows 11 settings");
            this.btnSystemUndo.UseVisualStyleBackColor = false;
            this.btnSystemUndo.Click += new System.EventHandler(this.btnSystemUndo_Click);
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
            this.lnkSubHeader.Location = new System.Drawing.Point(0, 34);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(587, 20);
            this.lnkSubHeader.TabIndex = 171;
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // tt
            // 
            this.tt.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tt.ForeColor = System.Drawing.Color.White;
            this.tt.IsBalloon = true;
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tt.ToolTipTitle = "OpenTweaks";
            this.tt.UseAnimation = false;
            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.btnSystemMenu);
            this.pnlRight.Controls.Add(this.progress);
            this.pnlRight.Controls.Add(this.lnkSubHeader);
            this.pnlRight.Controls.Add(this.tvwAssessments);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(532, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(678, 862);
            this.pnlRight.TabIndex = 172;
            // 
            // CustomizeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomizeWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenTweaks";
            this.Shown += new System.EventHandler(this.CustomizeWindow_Shown);
            this.menuSystem.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSystemMenu;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSystemCheck;
        private System.Windows.Forms.ContextMenuStrip menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuSystemPopOut;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnSystemFix;
        private System.Windows.Forms.ToolStripMenuItem menuSystemExportLog;
        private System.Windows.Forms.ToolStripMenuItem menuSystemSelect;
        private System.Windows.Forms.ToolStripMenuItem menuSystemVersioning;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.ToolStripMenuItem menuSystemExportProfile;
        private System.Windows.Forms.ToolStripMenuItem menuSystemImportProfile;
        private System.Windows.Forms.Button btnSystemUndo;
        private System.Windows.Forms.ToolTip tt;
        public System.Windows.Forms.TreeView tvwAssessments;
        private System.Windows.Forms.Panel pnlRight;
    }
}