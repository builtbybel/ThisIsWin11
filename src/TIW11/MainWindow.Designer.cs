
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExtensions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAutomate = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnApps = new System.Windows.Forms.Button();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuMainComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnExtensions);
            this.pnlBottom.Controls.Add(this.btnHome);
            this.pnlBottom.Controls.Add(this.btnSettings);
            this.pnlBottom.Controls.Add(this.btnAutomate);
            this.pnlBottom.Controls.Add(this.btnPackages);
            this.pnlBottom.Controls.Add(this.btnApps);
            this.pnlBottom.Controls.Add(this.btnCustomize);
            this.pnlBottom.Location = new System.Drawing.Point(0, 816);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlBottom.Size = new System.Drawing.Size(901, 35);
            this.pnlBottom.TabIndex = 130;
            // 
            // btnExtensions
            // 
            this.btnExtensions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExtensions.BackColor = System.Drawing.Color.White;
            this.btnExtensions.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtensions.FlatAppearance.BorderSize = 0;
            this.btnExtensions.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtensions.ForeColor = System.Drawing.Color.DimGray;
            this.btnExtensions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtensions.Location = new System.Drawing.Point(643, 1);
            this.btnExtensions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExtensions.Name = "btnExtensions";
            this.btnExtensions.Size = new System.Drawing.Size(29, 32);
            this.btnExtensions.TabIndex = 145;
            this.btnExtensions.TabStop = false;
            this.btnExtensions.Text = "5";
            this.tt.SetToolTip(this.btnExtensions, "Create tweaks");
            this.btnExtensions.UseVisualStyleBackColor = false;
            this.btnExtensions.Visible = false;
            this.btnExtensions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnExtensions_MouseDown);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(9, 3);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(29, 32);
            this.btnHome.TabIndex = 144;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.DimGray;
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(44, 3);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(29, 32);
            this.btnSettings.TabIndex = 143;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Visible = false;
            this.btnSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseDown);
            // 
            // btnAutomate
            // 
            this.btnAutomate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutomate.BackColor = System.Drawing.Color.White;
            this.btnAutomate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutomate.FlatAppearance.BorderSize = 0;
            this.btnAutomate.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomate.ForeColor = System.Drawing.Color.DimGray;
            this.btnAutomate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAutomate.Location = new System.Drawing.Point(608, 1);
            this.btnAutomate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(29, 32);
            this.btnAutomate.TabIndex = 142;
            this.btnAutomate.TabStop = false;
            this.btnAutomate.Text = "4";
            this.tt.SetToolTip(this.btnAutomate, "Automate tasks");
            this.btnAutomate.UseVisualStyleBackColor = false;
            this.btnAutomate.Visible = false;
            this.btnAutomate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAutomate_MouseDown);
            // 
            // btnPackages
            // 
            this.btnPackages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPackages.BackColor = System.Drawing.Color.White;
            this.btnPackages.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.Color.DimGray;
            this.btnPackages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPackages.Location = new System.Drawing.Point(573, 1);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(29, 32);
            this.btnPackages.TabIndex = 141;
            this.btnPackages.TabStop = false;
            this.btnPackages.Text = "3";
            this.tt.SetToolTip(this.btnPackages, "Install packages");
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Visible = false;
            this.btnPackages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPackages_MouseDown);
            // 
            // btnApps
            // 
            this.btnApps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApps.BackColor = System.Drawing.Color.White;
            this.btnApps.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnApps.FlatAppearance.BorderSize = 0;
            this.btnApps.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApps.ForeColor = System.Drawing.Color.DimGray;
            this.btnApps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApps.Location = new System.Drawing.Point(538, 1);
            this.btnApps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(29, 32);
            this.btnApps.TabIndex = 140;
            this.btnApps.TabStop = false;
            this.btnApps.Text = "2";
            this.tt.SetToolTip(this.btnApps, "Debloat Windows 11");
            this.btnApps.UseVisualStyleBackColor = false;
            this.btnApps.Visible = false;
            this.btnApps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnApps_MouseDown);
            // 
            // btnCustomize
            // 
            this.btnCustomize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomize.BackColor = System.Drawing.Color.White;
            this.btnCustomize.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomize.FlatAppearance.BorderSize = 0;
            this.btnCustomize.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomize.ForeColor = System.Drawing.Color.DimGray;
            this.btnCustomize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCustomize.Location = new System.Drawing.Point(503, 1);
            this.btnCustomize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(29, 32);
            this.btnCustomize.TabIndex = 139;
            this.btnCustomize.TabStop = false;
            this.btnCustomize.Text = "1";
            this.tt.SetToolTip(this.btnCustomize, "Customize Windows 11");
            this.btnCustomize.UseVisualStyleBackColor = false;
            this.btnCustomize.Visible = false;
            this.btnCustomize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCustomize_MouseDown);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(3, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1207, 862);
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
            // tt
            // 
            this.tt.AutomaticDelay = 0;
            this.tt.AutoPopDelay = 0;
            this.tt.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tt.ForeColor = System.Drawing.Color.White;
            this.tt.InitialDelay = 0;
            this.tt.IsBalloon = true;
            this.tt.ReshowDelay = 0;
            this.tt.ToolTipTitle = "ThisIsWin11";
            this.tt.UseAnimation = false;
            this.tt.UseFading = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1182, 809);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "ThisIsWin11";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.pnlBottom.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Button btnCustomize;
        public System.Windows.Forms.Button btnAutomate;
        public System.Windows.Forms.Button btnPackages;
        public System.Windows.Forms.Button btnApps;
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Button btnExtensions;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainComponents;
        private System.Windows.Forms.ToolTip tt;
    }
}

