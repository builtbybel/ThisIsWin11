
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrivacyAnalyse = new System.Windows.Forms.Button();
            this.menuPrivacy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPrivacyExportLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivacySelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivacyNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrivacyVersioning = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tvwAssessments = new System.Windows.Forms.TreeView();
            this.btnPrivacyFix = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrivacy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrivacyMenu
            // 
            this.btnPrivacyMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrivacyMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrivacyMenu.FlatAppearance.BorderSize = 0;
            this.btnPrivacyMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPrivacyMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacyMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacyMenu.Location = new System.Drawing.Point(353, 0);
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
            this.lblSubHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubHeader.Location = new System.Drawing.Point(72, 21);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(183, 32);
            this.lblSubHeader.TabIndex = 161;
            this.lblSubHeader.Text = "Analyse privacy";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(16, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 32);
            this.btnBack.TabIndex = 160;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrivacyAnalyse
            // 
            this.btnPrivacyAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrivacyAnalyse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrivacyAnalyse.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrivacyAnalyse.FlatAppearance.BorderSize = 0;
            this.btnPrivacyAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacyAnalyse.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacyAnalyse.ForeColor = System.Drawing.Color.Black;
            this.btnPrivacyAnalyse.Location = new System.Drawing.Point(22, 719);
            this.btnPrivacyAnalyse.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrivacyAnalyse.Name = "btnPrivacyAnalyse";
            this.btnPrivacyAnalyse.Size = new System.Drawing.Size(168, 30);
            this.btnPrivacyAnalyse.TabIndex = 159;
            this.btnPrivacyAnalyse.Text = "Check";
            this.btnPrivacyAnalyse.UseVisualStyleBackColor = false;
            this.btnPrivacyAnalyse.Click += new System.EventHandler(this.btnPrivacyAnalyse_Click);
            // 
            // menuPrivacy
            // 
            this.menuPrivacy.BackColor = System.Drawing.Color.Gainsboro;
            this.menuPrivacy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrivacy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrivacyExportLog,
            this.menuPrivacySelect,
            this.menuPrivacyNewWindow,
            this.toolStripSeparator1,
            this.menuPrivacyVersioning});
            this.menuPrivacy.Name = "menuMain";
            this.menuPrivacy.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPrivacy.Size = new System.Drawing.Size(263, 152);
            // 
            // menuPrivacyExportLog
            // 
            this.menuPrivacyExportLog.Name = "menuPrivacyExportLog";
            this.menuPrivacyExportLog.Size = new System.Drawing.Size(262, 30);
            this.menuPrivacyExportLog.Text = "Export log";
            this.menuPrivacyExportLog.Click += new System.EventHandler(this.menuPrivacyExportLog_Click);
            // 
            // menuPrivacySelect
            // 
            this.menuPrivacySelect.Name = "menuPrivacySelect";
            this.menuPrivacySelect.Size = new System.Drawing.Size(262, 30);
            this.menuPrivacySelect.Text = "Select all";
            this.menuPrivacySelect.Click += new System.EventHandler(this.menuPrivacySelect_Click);
            // 
            // menuPrivacyNewWindow
            // 
            this.menuPrivacyNewWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrivacyNewWindow.Name = "menuPrivacyNewWindow";
            this.menuPrivacyNewWindow.Size = new System.Drawing.Size(262, 30);
            this.menuPrivacyNewWindow.Text = "Open in new window";
            this.menuPrivacyNewWindow.Click += new System.EventHandler(this.menuPrivacyNewWindow_Click);
            // 
            // menuPrivacyVersioning
            // 
            this.menuPrivacyVersioning.Name = "menuPrivacyVersioning";
            this.menuPrivacyVersioning.Size = new System.Drawing.Size(262, 30);
            this.menuPrivacyVersioning.Text = "Info";
            this.menuPrivacyVersioning.Click += new System.EventHandler(this.menuPrivacyInfo_Click);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(32, 93);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(346, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // tvwAssessments
            // 
            this.tvwAssessments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwAssessments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tvwAssessments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwAssessments.CheckBoxes = true;
            this.tvwAssessments.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwAssessments.Location = new System.Drawing.Point(27, 132);
            this.tvwAssessments.Name = "tvwAssessments";
            this.tvwAssessments.ShowLines = false;
            this.tvwAssessments.ShowNodeToolTips = true;
            this.tvwAssessments.ShowPlusMinus = false;
            this.tvwAssessments.Size = new System.Drawing.Size(372, 565);
            this.tvwAssessments.TabIndex = 168;
            this.tvwAssessments.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwAssessments_AfterCheck);
            // 
            // btnPrivacyFix
            // 
            this.btnPrivacyFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrivacyFix.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrivacyFix.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrivacyFix.FlatAppearance.BorderSize = 0;
            this.btnPrivacyFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacyFix.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacyFix.ForeColor = System.Drawing.Color.Black;
            this.btnPrivacyFix.Location = new System.Drawing.Point(210, 719);
            this.btnPrivacyFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrivacyFix.Name = "btnPrivacyFix";
            this.btnPrivacyFix.Size = new System.Drawing.Size(168, 30);
            this.btnPrivacyFix.TabIndex = 167;
            this.btnPrivacyFix.Text = "Fix issues";
            this.btnPrivacyFix.UseVisualStyleBackColor = false;
            this.btnPrivacyFix.Click += new System.EventHandler(this.btnPrivacyFix_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // PrivacyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 770);
            this.Controls.Add(this.btnPrivacyFix);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tvwAssessments);
            this.Controls.Add(this.btnPrivacyMenu);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrivacyAnalyse);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PrivacyWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11";
            this.Load += new System.EventHandler(this.PrivacyWindow_Load);
            this.menuPrivacy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrivacyMenu;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnBack;
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
    }
}