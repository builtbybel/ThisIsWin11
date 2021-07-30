
namespace ThisIsWin11
{
    partial class PackagesWindow
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
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstPackages = new System.Windows.Forms.CheckedListBox();
            this.btnCreatePackage = new System.Windows.Forms.Button();
            this.BtnRunPackage = new System.Windows.Forms.Button();
            this.btnPackagesMenu = new System.Windows.Forms.Button();
            this.menuPackages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPackagesImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInstallWinget = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.menuPackages.SuspendLayout();
            this.SuspendLayout();
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
            this.lblSubHeader.Size = new System.Drawing.Size(188, 32);
            this.lblSubHeader.TabIndex = 139;
            this.lblSubHeader.Text = "Install packages";
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
            this.btnBack.TabIndex = 138;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstPackages
            // 
            this.lstPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPackages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPackages.CheckOnClick = true;
            this.lstPackages.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPackages.FormattingEnabled = true;
            this.lstPackages.Location = new System.Drawing.Point(27, 132);
            this.lstPackages.Name = "lstPackages";
            this.lstPackages.Size = new System.Drawing.Size(373, 528);
            this.lstPackages.Sorted = true;
            this.lstPackages.TabIndex = 140;
            this.lstPackages.ThreeDCheckBoxes = true;
            // 
            // btnCreatePackage
            // 
            this.btnCreatePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreatePackage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreatePackage.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreatePackage.FlatAppearance.BorderSize = 0;
            this.btnCreatePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePackage.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePackage.ForeColor = System.Drawing.Color.Black;
            this.btnCreatePackage.Location = new System.Drawing.Point(27, 689);
            this.btnCreatePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePackage.Name = "btnCreatePackage";
            this.btnCreatePackage.Size = new System.Drawing.Size(168, 30);
            this.btnCreatePackage.TabIndex = 141;
            this.btnCreatePackage.Text = "1. Create Package";
            this.btnCreatePackage.UseVisualStyleBackColor = false;
            this.btnCreatePackage.Click += new System.EventHandler(this.btnCreatePackage_Click);
            // 
            // BtnRunPackage
            // 
            this.BtnRunPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRunPackage.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRunPackage.FlatAppearance.BorderSize = 0;
            this.BtnRunPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunPackage.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRunPackage.ForeColor = System.Drawing.Color.Black;
            this.BtnRunPackage.Location = new System.Drawing.Point(210, 689);
            this.BtnRunPackage.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRunPackage.Name = "BtnRunPackage";
            this.BtnRunPackage.Size = new System.Drawing.Size(168, 30);
            this.BtnRunPackage.TabIndex = 142;
            this.BtnRunPackage.Text = "2. Run Installer";
            this.BtnRunPackage.UseVisualStyleBackColor = false;
            this.BtnRunPackage.Click += new System.EventHandler(this.BtnRunPackage_Click);
            // 
            // btnPackagesMenu
            // 
            this.btnPackagesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPackagesMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPackagesMenu.FlatAppearance.BorderSize = 0;
            this.btnPackagesMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPackagesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackagesMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackagesMenu.Location = new System.Drawing.Point(353, 0);
            this.btnPackagesMenu.Name = "btnPackagesMenu";
            this.btnPackagesMenu.Size = new System.Drawing.Size(48, 51);
            this.btnPackagesMenu.TabIndex = 157;
            this.btnPackagesMenu.UseVisualStyleBackColor = false;
            this.btnPackagesMenu.Click += new System.EventHandler(this.btnPackagesMenu_Click);
            // 
            // menuPackages
            // 
            this.menuPackages.BackColor = System.Drawing.Color.Gainsboro;
            this.menuPackages.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPackages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPackagesImport,
            this.menuPackagesExport,
            this.menuPackagesRefresh,
            this.menuPackagesSelect,
            this.menuPackagesNewWindow});
            this.menuPackages.Name = "menuMain";
            this.menuPackages.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPackages.Size = new System.Drawing.Size(263, 176);
            // 
            // menuPackagesImport
            // 
            this.menuPackagesImport.Name = "menuPackagesImport";
            this.menuPackagesImport.Size = new System.Drawing.Size(262, 30);
            this.menuPackagesImport.Text = "Import package list";
            this.menuPackagesImport.Click += new System.EventHandler(this.menuPackagesImport_Click);
            // 
            // menuPackagesExport
            // 
            this.menuPackagesExport.Name = "menuPackagesExport";
            this.menuPackagesExport.Size = new System.Drawing.Size(262, 30);
            this.menuPackagesExport.Text = "Export to PowerShell";
            this.menuPackagesExport.Click += new System.EventHandler(this.menuPackagesExport_Click);
            // 
            // menuPackagesRefresh
            // 
            this.menuPackagesRefresh.Name = "menuPackagesRefresh";
            this.menuPackagesRefresh.Size = new System.Drawing.Size(262, 30);
            this.menuPackagesRefresh.Text = "Refresh";
            this.menuPackagesRefresh.Click += new System.EventHandler(this.menuPackagesRefresh_Click);
            // 
            // menuPackagesSelect
            // 
            this.menuPackagesSelect.Name = "menuPackagesSelect";
            this.menuPackagesSelect.Size = new System.Drawing.Size(262, 30);
            this.menuPackagesSelect.Text = "Select all";
            this.menuPackagesSelect.Click += new System.EventHandler(this.menuPackagesSelect_Click);
            // 
            // menuPackagesNewWindow
            // 
            this.menuPackagesNewWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPackagesNewWindow.Name = "menuPackagesNewWindow";
            this.menuPackagesNewWindow.Size = new System.Drawing.Size(262, 30);
            this.menuPackagesNewWindow.Text = "Open in new window";
            this.menuPackagesNewWindow.Click += new System.EventHandler(this.menuPackagesNewWindow_Click);
            // 
            // btnInstallWinget
            // 
            this.btnInstallWinget.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInstallWinget.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInstallWinget.FlatAppearance.BorderSize = 0;
            this.btnInstallWinget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallWinget.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallWinget.ForeColor = System.Drawing.Color.White;
            this.btnInstallWinget.Location = new System.Drawing.Point(78, 70);
            this.btnInstallWinget.Name = "btnInstallWinget";
            this.btnInstallWinget.Size = new System.Drawing.Size(237, 30);
            this.btnInstallWinget.TabIndex = 161;
            this.btnInstallWinget.Text = "Install Windows Package Manager";
            this.btnInstallWinget.UseVisualStyleBackColor = false;
            this.btnInstallWinget.Visible = false;
            this.btnInstallWinget.Click += new System.EventHandler(this.btnInstallWinget_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(78, 106);
            this.progress.MarqueeAnimationSpeed = 30;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(237, 5);
            this.progress.TabIndex = 162;
            this.progress.Visible = false;
            // 
            // PackagesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 770);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnInstallWinget);
            this.Controls.Add(this.btnPackagesMenu);
            this.Controls.Add(this.BtnRunPackage);
            this.Controls.Add(this.btnCreatePackage);
            this.Controls.Add(this.lstPackages);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PackagesWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11";
            this.Load += new System.EventHandler(this.PackagesWindow_Load);
            this.menuPackages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox lstPackages;
        private System.Windows.Forms.Button btnCreatePackage;
        private System.Windows.Forms.Button BtnRunPackage;
        private System.Windows.Forms.Button btnPackagesMenu;
        private System.Windows.Forms.ContextMenuStrip menuPackages;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesImport;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesNewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesExport;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesSelect;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesRefresh;
        private System.Windows.Forms.Button btnInstallWinget;
        private System.Windows.Forms.ProgressBar progress;
    }
}