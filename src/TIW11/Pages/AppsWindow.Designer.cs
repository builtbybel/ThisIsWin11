
namespace ThisIsWin11
{
    partial class AppsWindow
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
            System.Windows.Forms.ToolStripMenuItem menuAppsSync;
            this.lstUWP = new System.Windows.Forms.CheckedListBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.btnRemoveUWP = new System.Windows.Forms.Button();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAppsMenu = new System.Windows.Forms.Button();
            this.menuApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppsNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            menuAppsSync = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApps.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAppsSync
            // 
            menuAppsSync.Name = "menuAppsSync";
            menuAppsSync.Size = new System.Drawing.Size(285, 30);
            menuAppsSync.Text = "Run community syncing";
            menuAppsSync.Click += new System.EventHandler(this.menuAppsSync_Click);
            // 
            // lstUWP
            // 
            this.lstUWP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUWP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstUWP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUWP.CheckOnClick = true;
            this.lstUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUWP.FormattingEnabled = true;
            this.lstUWP.Location = new System.Drawing.Point(27, 132);
            this.lstUWP.Name = "lstUWP";
            this.lstUWP.Size = new System.Drawing.Size(373, 528);
            this.lstUWP.Sorted = true;
            this.lstUWP.TabIndex = 60;
            this.lstUWP.ThreeDCheckBoxes = true;
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAppsSystem.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.checkAppsSystem.FlatAppearance.BorderSize = 0;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkAppsSystem.Location = new System.Drawing.Point(27, 665);
            this.checkAppsSystem.Margin = new System.Windows.Forms.Padding(2);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(163, 25);
            this.checkAppsSystem.TabIndex = 103;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = false;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // btnRemoveUWP
            // 
            this.btnRemoveUWP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveUWP.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveUWP.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveUWP.FlatAppearance.BorderSize = 0;
            this.btnRemoveUWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUWP.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveUWP.Location = new System.Drawing.Point(27, 705);
            this.btnRemoveUWP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveUWP.Name = "btnRemoveUWP";
            this.btnRemoveUWP.Size = new System.Drawing.Size(213, 30);
            this.btnRemoveUWP.TabIndex = 104;
            this.btnRemoveUWP.Text = "Uninstall";
            this.btnRemoveUWP.UseVisualStyleBackColor = false;
            this.btnRemoveUWP.Click += new System.EventHandler(this.btnRemoveUWP_Click);
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
            this.lblSubHeader.Size = new System.Drawing.Size(160, 32);
            this.lblSubHeader.TabIndex = 137;
            this.lblSubHeader.Text = "Remove apps";
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
            this.btnBack.TabIndex = 136;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAppsMenu
            // 
            this.btnAppsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppsMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAppsMenu.FlatAppearance.BorderSize = 0;
            this.btnAppsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAppsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppsMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppsMenu.Location = new System.Drawing.Point(353, 0);
            this.btnAppsMenu.Name = "btnAppsMenu";
            this.btnAppsMenu.Size = new System.Drawing.Size(48, 51);
            this.btnAppsMenu.TabIndex = 156;
            this.btnAppsMenu.UseVisualStyleBackColor = false;
            this.btnAppsMenu.Click += new System.EventHandler(this.btnAppsMenu_Click);
            // 
            // menuApps
            // 
            this.menuApps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppsImport,
            menuAppsSync,
            this.menuAppsRefresh,
            this.menuAppsSelect,
            this.menuAppsRemoveAll,
            this.menuAppsNewWindow});
            this.menuApps.Name = "menuMain";
            this.menuApps.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuApps.Size = new System.Drawing.Size(286, 206);
            // 
            // menuAppsNewWindow
            // 
            this.menuAppsNewWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAppsNewWindow.Name = "menuAppsNewWindow";
            this.menuAppsNewWindow.Size = new System.Drawing.Size(285, 30);
            this.menuAppsNewWindow.Text = "Open in new window";
            this.menuAppsNewWindow.Click += new System.EventHandler(this.menuAppsNewWindow_Click);
            // 
            // menuAppsImport
            // 
            this.menuAppsImport.Name = "menuAppsImport";
            this.menuAppsImport.Size = new System.Drawing.Size(285, 30);
            this.menuAppsImport.Text = "Import bloatware list";
            this.menuAppsImport.Click += new System.EventHandler(this.menuAppsImport_Click);
            // 
            // menuAppsRefresh
            // 
            this.menuAppsRefresh.Name = "menuAppsRefresh";
            this.menuAppsRefresh.Size = new System.Drawing.Size(285, 30);
            this.menuAppsRefresh.Text = "Refresh";
            this.menuAppsRefresh.Click += new System.EventHandler(this.menuAppsRefresh_Click);
            // 
            // menuAppsSelect
            // 
            this.menuAppsSelect.Name = "menuAppsSelect";
            this.menuAppsSelect.Size = new System.Drawing.Size(285, 30);
            this.menuAppsSelect.Text = "Select all";
            this.menuAppsSelect.Click += new System.EventHandler(this.menuAppsSelect_Click);
            // 
            // menuAppsRemoveAll
            // 
            this.menuAppsRemoveAll.Name = "menuAppsRemoveAll";
            this.menuAppsRemoveAll.Size = new System.Drawing.Size(285, 30);
            this.menuAppsRemoveAll.Text = "Remove all apps";
            this.menuAppsRemoveAll.Click += new System.EventHandler(this.menuAppsRemoveAll_Click);
            // 
            // AppsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 770);
            this.Controls.Add(this.btnAppsMenu);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveUWP);
            this.Controls.Add(this.checkAppsSystem);
            this.Controls.Add(this.lstUWP);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AppsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11";
            this.Load += new System.EventHandler(this.AppsWindow_Load);
            this.menuApps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstUWP;
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.Button btnRemoveUWP;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAppsMenu;
        private System.Windows.Forms.ContextMenuStrip menuApps;
        private System.Windows.Forms.ToolStripMenuItem menuAppsNewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem menuAppsSelect;
        private System.Windows.Forms.ToolStripMenuItem menuAppsImport;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRefresh;
    }
}