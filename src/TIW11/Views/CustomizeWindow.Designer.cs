
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
            this.btnCustomizeMenu = new ThisIsWin11.Controls.RoundedButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCustomizeCheck = new ThisIsWin11.Controls.RoundedButton();
            this.menuCustomize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCustomizeImportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomizeExportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomizeExportLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomizeExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomizePopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCustomizeVersioning = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tvwAssessments = new System.Windows.Forms.TreeView();
            this.btnCustomizeFix = new ThisIsWin11.Controls.RoundedButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnCustomizeImport = new ThisIsWin11.Controls.RoundedButton();
            this.btnCustomizeExportNShare = new ThisIsWin11.Controls.RoundedButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnCustomizeUndo = new ThisIsWin11.Controls.RoundedButton();
            this.menuCustomize.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomizeMenu
            // 
            this.btnCustomizeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomizeMenu.BackColor = System.Drawing.Color.White;
            this.btnCustomizeMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomizeMenu.FlatAppearance.BorderSize = 0;
            this.btnCustomizeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizeMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomizeMenu.Location = new System.Drawing.Point(627, 0);
            this.btnCustomizeMenu.Name = "btnCustomizeMenu";
            this.btnCustomizeMenu.Size = new System.Drawing.Size(48, 51);
            this.btnCustomizeMenu.TabIndex = 162;
            this.btnCustomizeMenu.UseVisualStyleBackColor = false;
            this.btnCustomizeMenu.Click += new System.EventHandler(this.btnCustomizeMenu_Click);
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
            // btnCustomizeCheck
            // 
            this.btnCustomizeCheck.AutoEllipsis = true;
            this.btnCustomizeCheck.BackColor = System.Drawing.Color.Magenta;
            this.btnCustomizeCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCustomizeCheck.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnCustomizeCheck.FlatAppearance.BorderSize = 0;
            this.btnCustomizeCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizeCheck.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeCheck.ForeColor = System.Drawing.Color.White;
            this.btnCustomizeCheck.Location = new System.Drawing.Point(0, 815);
            this.btnCustomizeCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomizeCheck.Name = "btnCustomizeCheck";
            this.btnCustomizeCheck.Size = new System.Drawing.Size(532, 47);
            this.btnCustomizeCheck.TabIndex = 159;
            this.btnCustomizeCheck.Text = "CHECK";
            this.btnCustomizeCheck.UseVisualStyleBackColor = false;
            this.btnCustomizeCheck.Click += new System.EventHandler(this.btnCustomizeCheck_Click);
            // 
            // menuCustomize
            // 
            this.menuCustomize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuCustomize.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCustomize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCustomizeImportProfile,
            this.menuCustomizeExportProfile,
            this.menuCustomizeExportLog,
            this.menuCustomizeExpand,
            this.menuCustomizePopOut,
            this.toolStripSeparator1,
            this.menuCustomizeVersioning});
            this.menuCustomize.Name = "menuMain";
            this.menuCustomize.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuCustomize.Size = new System.Drawing.Size(201, 190);
            // 
            // menuCustomizeImportProfile
            // 
            this.menuCustomizeImportProfile.Name = "menuCustomizeImportProfile";
            this.menuCustomizeImportProfile.Size = new System.Drawing.Size(200, 30);
            this.menuCustomizeImportProfile.Text = "Import profile";
            this.menuCustomizeImportProfile.Click += new System.EventHandler(this.menuCustomizeImportProfile_Click);
            // 
            // menuCustomizeExportProfile
            // 
            this.menuCustomizeExportProfile.Name = "menuCustomizeExportProfile";
            this.menuCustomizeExportProfile.Size = new System.Drawing.Size(200, 30);
            this.menuCustomizeExportProfile.Text = "Export profile";
            this.menuCustomizeExportProfile.Click += new System.EventHandler(this.menuCustomizeExportProfile_Click);
            // 
            // menuCustomizeExportLog
            // 
            this.menuCustomizeExportLog.Name = "menuCustomizeExportLog";
            this.menuCustomizeExportLog.Size = new System.Drawing.Size(200, 30);
            this.menuCustomizeExportLog.Text = "Export log";
            this.menuCustomizeExportLog.Click += new System.EventHandler(this.menuCustomizeExportLog_Click);
            // 
            // menuCustomizeExpand
            // 
            this.menuCustomizeExpand.Name = "menuCustomizeExpand";
            this.menuCustomizeExpand.Size = new System.Drawing.Size(200, 30);
            this.menuCustomizeExpand.Text = "Expand all";
            this.menuCustomizeExpand.Click += new System.EventHandler(this.menuCustomizeExpand_Click);
            // 
            // menuCustomizePopOut
            // 
            this.menuCustomizePopOut.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCustomizePopOut.Name = "menuCustomizePopOut";
            this.menuCustomizePopOut.Size = new System.Drawing.Size(200, 30);
            this.menuCustomizePopOut.Text = "Pop-out-App";
            this.menuCustomizePopOut.Click += new System.EventHandler(this.menuCustomizePopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // menuCustomizeVersioning
            // 
            this.menuCustomizeVersioning.Name = "menuCustomizeVersioning";
            this.menuCustomizeVersioning.Size = new System.Drawing.Size(200, 30);
            this.menuCustomizeVersioning.Text = "Info";
            this.menuCustomizeVersioning.Click += new System.EventHandler(this.menuCustomizeInfo_Click);
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
            this.tvwAssessments.HotTracking = true;
            this.tvwAssessments.ItemHeight = 30;
            this.tvwAssessments.LineColor = System.Drawing.Color.HotPink;
            this.tvwAssessments.Location = new System.Drawing.Point(3, 82);
            this.tvwAssessments.Name = "tvwAssessments";
            this.tvwAssessments.ShowLines = false;
            this.tvwAssessments.ShowNodeToolTips = true;
            this.tvwAssessments.ShowRootLines = false;
            this.tvwAssessments.Size = new System.Drawing.Size(672, 691);
            this.tvwAssessments.TabIndex = 168;
            this.tvwAssessments.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwAssessments_AfterCheck);
            // 
            // btnCustomizeFix
            // 
            this.btnCustomizeFix.AutoEllipsis = true;
            this.btnCustomizeFix.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomizeFix.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCustomizeFix.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomizeFix.FlatAppearance.BorderSize = 0;
            this.btnCustomizeFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizeFix.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeFix.ForeColor = System.Drawing.Color.White;
            this.btnCustomizeFix.Location = new System.Drawing.Point(0, 815);
            this.btnCustomizeFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomizeFix.Name = "btnCustomizeFix";
            this.btnCustomizeFix.Size = new System.Drawing.Size(678, 47);
            this.btnCustomizeFix.TabIndex = 167;
            this.btnCustomizeFix.Text = "FIX ISSUES";
            this.btnCustomizeFix.UseVisualStyleBackColor = false;
            this.btnCustomizeFix.Click += new System.EventHandler(this.btnCustomizeFix_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.rtbPS);
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Controls.Add(this.btnCustomizeCheck);
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
            this.rtbPS.Size = new System.Drawing.Size(464, 598);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
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
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt.ToolTipTitle = "OpenTweaks";
            this.tt.UseAnimation = false;
            // 
            // btnCustomizeImport
            // 
            this.btnCustomizeImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomizeImport.BackColor = System.Drawing.Color.White;
            this.btnCustomizeImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomizeImport.FlatAppearance.BorderSize = 0;
            this.btnCustomizeImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizeImport.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomizeImport.Location = new System.Drawing.Point(519, 0);
            this.btnCustomizeImport.Name = "btnCustomizeImport";
            this.btnCustomizeImport.Size = new System.Drawing.Size(48, 51);
            this.btnCustomizeImport.TabIndex = 172;
            this.tt.SetToolTip(this.btnCustomizeImport, "Import profile");
            this.btnCustomizeImport.UseVisualStyleBackColor = false;
            this.btnCustomizeImport.Click += new System.EventHandler(this.btnCustomizeImport_Click);
            // 
            // btnCustomizeExportNShare
            // 
            this.btnCustomizeExportNShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomizeExportNShare.BackColor = System.Drawing.Color.White;
            this.btnCustomizeExportNShare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomizeExportNShare.FlatAppearance.BorderSize = 0;
            this.btnCustomizeExportNShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizeExportNShare.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeExportNShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomizeExportNShare.Location = new System.Drawing.Point(573, 0);
            this.btnCustomizeExportNShare.Name = "btnCustomizeExportNShare";
            this.btnCustomizeExportNShare.Size = new System.Drawing.Size(48, 51);
            this.btnCustomizeExportNShare.TabIndex = 173;
            this.tt.SetToolTip(this.btnCustomizeExportNShare, "Export and share your configuration");
            this.btnCustomizeExportNShare.UseVisualStyleBackColor = false;
            this.btnCustomizeExportNShare.Click += new System.EventHandler(this.btnCustomizeExportNShare_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.btnCustomizeUndo);
            this.pnlRight.Controls.Add(this.btnCustomizeExportNShare);
            this.pnlRight.Controls.Add(this.btnCustomizeImport);
            this.pnlRight.Controls.Add(this.btnCustomizeMenu);
            this.pnlRight.Controls.Add(this.progress);
            this.pnlRight.Controls.Add(this.lnkSubHeader);
            this.pnlRight.Controls.Add(this.btnCustomizeFix);
            this.pnlRight.Controls.Add(this.tvwAssessments);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(532, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(678, 862);
            this.pnlRight.TabIndex = 172;
            // 
            // btnCustomizeUndo
            // 
            this.btnCustomizeUndo.AutoEllipsis = true;
            this.btnCustomizeUndo.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCustomizeUndo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCustomizeUndo.FlatAppearance.BorderSize = 0;
            this.btnCustomizeUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizeUndo.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeUndo.ForeColor = System.Drawing.Color.Black;
            this.btnCustomizeUndo.Location = new System.Drawing.Point(0, 779);
            this.btnCustomizeUndo.Name = "btnCustomizeUndo";
            this.btnCustomizeUndo.Size = new System.Drawing.Size(678, 36);
            this.btnCustomizeUndo.TabIndex = 174;
            this.btnCustomizeUndo.Text = "RESTORE DEFAULTS";
            this.btnCustomizeUndo.UseVisualStyleBackColor = false;
            this.btnCustomizeUndo.Click += new System.EventHandler(this.btnCustomizeUndo_Click);
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
            this.menuCustomize.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ContextMenuStrip menuCustomize;
        private System.Windows.Forms.ToolStripMenuItem menuCustomizePopOut;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.ToolStripMenuItem menuCustomizeExportLog;
        private System.Windows.Forms.ToolStripMenuItem menuCustomizeExpand;
        private System.Windows.Forms.ToolStripMenuItem menuCustomizeVersioning;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.ToolStripMenuItem menuCustomizeExportProfile;
        private System.Windows.Forms.ToolStripMenuItem menuCustomizeImportProfile;
        private System.Windows.Forms.ToolTip tt;
        public System.Windows.Forms.TreeView tvwAssessments;
        private System.Windows.Forms.Panel pnlRight;
        private Controls.RoundedButton btnCustomizeUndo;
        private Controls.RoundedButton btnCustomizeMenu;
        private Controls.RoundedButton btnCustomizeCheck;
        private Controls.RoundedButton btnCustomizeFix;
        private Controls.RoundedButton btnCustomizeImport;
        private Controls.RoundedButton btnCustomizeExportNShare;
    }
}