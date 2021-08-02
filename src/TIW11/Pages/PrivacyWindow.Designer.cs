
namespace ThisIsWin11
{
    partial class PrivacyWindow
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
            this.btnPrivacyMenu = new System.Windows.Forms.Button();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnPrivacyAnalyse = new System.Windows.Forms.Button();
            this.menuPrivacy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPrivacyUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivacyExportLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivacySelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivacyNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrivacyVersioning = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tvwAssessments = new System.Windows.Forms.TreeView();
            this.btnPrivacyFix = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.menuPrivacy.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrivacyMenu
            // 
            this.btnPrivacyMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrivacyMenu.BackColor = System.Drawing.Color.White;
            this.btnPrivacyMenu.FlatAppearance.BorderSize = 0;
            this.btnPrivacyMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPrivacyMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacyMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacyMenu.Location = new System.Drawing.Point(667, 0);
            this.btnPrivacyMenu.Name = "btnPrivacyMenu";
            this.btnPrivacyMenu.Size = new System.Drawing.Size(48, 51);
            this.btnPrivacyMenu.TabIndex = 162;
            this.btnPrivacyMenu.UseVisualStyleBackColor = false;
            this.btnPrivacyMenu.Click += new System.EventHandler(this.btnPrivacyMenu_Click);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubHeader.Location = new System.Drawing.Point(24, 19);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(183, 32);
            this.lblSubHeader.TabIndex = 161;
            this.lblSubHeader.Text = "Analyse privacy";
            // 
            // btnPrivacyAnalyse
            // 
            this.btnPrivacyAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrivacyAnalyse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrivacyAnalyse.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnPrivacyAnalyse.FlatAppearance.BorderSize = 0;
            this.btnPrivacyAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacyAnalyse.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacyAnalyse.ForeColor = System.Drawing.Color.Black;
            this.btnPrivacyAnalyse.Location = new System.Drawing.Point(24, 715);
            this.btnPrivacyAnalyse.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrivacyAnalyse.Name = "btnPrivacyAnalyse";
            this.btnPrivacyAnalyse.Size = new System.Drawing.Size(213, 30);
            this.btnPrivacyAnalyse.TabIndex = 159;
            this.btnPrivacyAnalyse.Text = "Check";
            this.btnPrivacyAnalyse.UseVisualStyleBackColor = false;
            this.btnPrivacyAnalyse.Click += new System.EventHandler(this.btnPrivacyAnalyse_Click);
            // 
            // menuPrivacy
            // 
            this.menuPrivacy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuPrivacy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrivacy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrivacyUndo,
            this.menuPrivacyExportLog,
            this.menuPrivacySelect,
            this.menuPrivacyNewWindow,
            this.toolStripSeparator1,
            this.menuPrivacyVersioning});
            this.menuPrivacy.Name = "menuMain";
            this.menuPrivacy.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPrivacy.Size = new System.Drawing.Size(389, 160);
            // 
            // menuPrivacyUndo
            // 
            this.menuPrivacyUndo.Name = "menuPrivacyUndo";
            this.menuPrivacyUndo.Size = new System.Drawing.Size(388, 30);
            this.menuPrivacyUndo.Text = "Restore default Windows 11 settings";
            this.menuPrivacyUndo.Click += new System.EventHandler(this.menuPrivacyUndo_Click);
            // 
            // menuPrivacyExportLog
            // 
            this.menuPrivacyExportLog.Name = "menuPrivacyExportLog";
            this.menuPrivacyExportLog.Size = new System.Drawing.Size(388, 30);
            this.menuPrivacyExportLog.Text = "Export log";
            this.menuPrivacyExportLog.Click += new System.EventHandler(this.menuPrivacyExportLog_Click);
            // 
            // menuPrivacySelect
            // 
            this.menuPrivacySelect.Name = "menuPrivacySelect";
            this.menuPrivacySelect.Size = new System.Drawing.Size(388, 30);
            this.menuPrivacySelect.Text = "Select all";
            this.menuPrivacySelect.Click += new System.EventHandler(this.menuPrivacySelect_Click);
            // 
            // menuPrivacyNewWindow
            // 
            this.menuPrivacyNewWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrivacyNewWindow.Name = "menuPrivacyNewWindow";
            this.menuPrivacyNewWindow.Size = new System.Drawing.Size(388, 30);
            this.menuPrivacyNewWindow.Text = "Open in new window";
            this.menuPrivacyNewWindow.Click += new System.EventHandler(this.menuPrivacyNewWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(385, 6);
            // 
            // menuPrivacyVersioning
            // 
            this.menuPrivacyVersioning.Name = "menuPrivacyVersioning";
            this.menuPrivacyVersioning.Size = new System.Drawing.Size(388, 30);
            this.menuPrivacyVersioning.Text = "Info";
            this.menuPrivacyVersioning.Click += new System.EventHandler(this.menuPrivacyInfo_Click);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(24, 78);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(669, 5);
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
            this.tvwAssessments.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwAssessments.Location = new System.Drawing.Point(24, 99);
            this.tvwAssessments.Name = "tvwAssessments";
            this.tvwAssessments.ShowLines = false;
            this.tvwAssessments.ShowNodeToolTips = true;
            this.tvwAssessments.ShowPlusMinus = false;
            this.tvwAssessments.Size = new System.Drawing.Size(691, 576);
            this.tvwAssessments.TabIndex = 168;
            this.tvwAssessments.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwAssessments_AfterCheck);
            // 
            // btnPrivacyFix
            // 
            this.btnPrivacyFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrivacyFix.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrivacyFix.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnPrivacyFix.FlatAppearance.BorderSize = 0;
            this.btnPrivacyFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacyFix.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacyFix.ForeColor = System.Drawing.Color.Black;
            this.btnPrivacyFix.Location = new System.Drawing.Point(250, 715);
            this.btnPrivacyFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrivacyFix.Name = "btnPrivacyFix";
            this.btnPrivacyFix.Size = new System.Drawing.Size(213, 30);
            this.btnPrivacyFix.TabIndex = 167;
            this.btnPrivacyFix.Text = "Fix issues";
            this.btnPrivacyFix.UseVisualStyleBackColor = false;
            this.btnPrivacyFix.Click += new System.EventHandler(this.btnPrivacyFix_Click);
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
            this.pnlRight.TabIndex = 170;
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
            // PrivacyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.btnPrivacyFix);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tvwAssessments);
            this.Controls.Add(this.btnPrivacyMenu);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.btnPrivacyAnalyse);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PrivacyWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucent11";
            this.Shown += new System.EventHandler(this.PrivacyWindow_Shown);
            this.menuPrivacy.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrivacyMenu;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnPrivacyAnalyse;
        private System.Windows.Forms.ContextMenuStrip menuPrivacy;
        private System.Windows.Forms.ToolStripMenuItem menuPrivacyNewWindow;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TreeView tvwAssessments;
        private System.Windows.Forms.Button btnPrivacyFix;
        private System.Windows.Forms.ToolStripMenuItem menuPrivacyExportLog;
        private System.Windows.Forms.ToolStripMenuItem menuPrivacySelect;
        private System.Windows.Forms.ToolStripMenuItem menuPrivacyVersioning;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblPreview;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.ToolStripMenuItem menuPrivacyUndo;
    }
}