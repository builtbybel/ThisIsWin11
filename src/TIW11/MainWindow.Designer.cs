
namespace ThisIsWin11
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnExtensions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAutomate = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnApps = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuMainComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Controls.Add(this.btnExtensions);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.btnAutomate);
            this.pnlLeft.Controls.Add(this.btnPackages);
            this.pnlLeft.Controls.Add(this.btnApps);
            this.pnlLeft.Controls.Add(this.btnSystem);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(78, 770);
            this.pnlLeft.TabIndex = 130;
            // 
            // btnExtensions
            // 
            this.btnExtensions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtensions.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtensions.FlatAppearance.BorderSize = 0;
            this.btnExtensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtensions.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtensions.ForeColor = System.Drawing.Color.DimGray;
            this.btnExtensions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtensions.Location = new System.Drawing.Point(3, 370);
            this.btnExtensions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExtensions.Name = "btnExtensions";
            this.btnExtensions.Size = new System.Drawing.Size(72, 61);
            this.btnExtensions.TabIndex = 145;
            this.btnExtensions.Text = "...";
            this.btnExtensions.UseVisualStyleBackColor = false;
            this.btnExtensions.Visible = false;
            this.btnExtensions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnExtensions_MouseDown);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(3, 25);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 61);
            this.btnHome.TabIndex = 144;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Visible = false;
            this.btnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseDown);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.DimGray;
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(3, 686);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(72, 72);
            this.btnSettings.TabIndex = 143;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Visible = false;
            this.btnSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseDown);
            // 
            // btnAutomate
            // 
            this.btnAutomate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutomate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutomate.FlatAppearance.BorderSize = 0;
            this.btnAutomate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomate.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomate.ForeColor = System.Drawing.Color.DimGray;
            this.btnAutomate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAutomate.Location = new System.Drawing.Point(3, 301);
            this.btnAutomate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(72, 61);
            this.btnAutomate.TabIndex = 142;
            this.btnAutomate.Text = "Automate";
            this.btnAutomate.UseVisualStyleBackColor = false;
            this.btnAutomate.Visible = false;
            this.btnAutomate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAutomate_MouseDown);
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPackages.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.Color.DimGray;
            this.btnPackages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPackages.Location = new System.Drawing.Point(3, 232);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(72, 61);
            this.btnPackages.TabIndex = 141;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Visible = false;
            this.btnPackages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPackages_MouseDown);
            // 
            // btnApps
            // 
            this.btnApps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnApps.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnApps.FlatAppearance.BorderSize = 0;
            this.btnApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApps.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApps.ForeColor = System.Drawing.Color.DimGray;
            this.btnApps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApps.Location = new System.Drawing.Point(3, 163);
            this.btnApps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(72, 61);
            this.btnApps.TabIndex = 140;
            this.btnApps.Text = "Apps";
            this.btnApps.UseVisualStyleBackColor = false;
            this.btnApps.Visible = false;
            this.btnApps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnApps_MouseDown);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSystem.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.ForeColor = System.Drawing.Color.DimGray;
            this.btnSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSystem.Location = new System.Drawing.Point(3, 94);
            this.btnSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(72, 61);
            this.btnSystem.TabIndex = 139;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Visible = false;
            this.btnSystem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSystem_MouseDown);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(78, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1088, 770);
            this.pnlContainer.TabIndex = 136;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainComponents});
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMain.Size = new System.Drawing.Size(174, 34);
            // 
            // menuMainComponents
            // 
            this.menuMainComponents.Name = "menuMainComponents";
            this.menuMainComponents.Size = new System.Drawing.Size(173, 30);
            this.menuMainComponents.Text = "Extensions";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 770);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlLeft);
            this.MinimumSize = new System.Drawing.Size(1182, 809);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.pnlLeft.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Button btnSystem;
        public System.Windows.Forms.Button btnAutomate;
        public System.Windows.Forms.Button btnPackages;
        public System.Windows.Forms.Button btnApps;
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Button btnExtensions;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainComponents;
    }
}

