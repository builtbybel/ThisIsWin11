﻿
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnGlobalNav = new System.Windows.Forms.Button();
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
            this.pnlNav.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSize = true;
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Controls.Add(this.btnGlobalNav);
            this.pnlNav.Controls.Add(this.btnExtensions);
            this.pnlNav.Controls.Add(this.btnHome);
            this.pnlNav.Controls.Add(this.btnSettings);
            this.pnlNav.Controls.Add(this.btnAutomate);
            this.pnlNav.Controls.Add(this.btnPackages);
            this.pnlNav.Controls.Add(this.btnApps);
            this.pnlNav.Controls.Add(this.btnCustomize);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pnlNav.Size = new System.Drawing.Size(48, 1055);
            this.pnlNav.TabIndex = 130;
            // 
            // btnGlobalNav
            // 
            this.btnGlobalNav.BackColor = System.Drawing.Color.White;
            this.btnGlobalNav.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGlobalNav.FlatAppearance.BorderSize = 0;
            this.btnGlobalNav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGlobalNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlobalNav.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlobalNav.ForeColor = System.Drawing.Color.DimGray;
            this.btnGlobalNav.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGlobalNav.Location = new System.Drawing.Point(10, 8);
            this.btnGlobalNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGlobalNav.Name = "btnGlobalNav";
            this.btnGlobalNav.Size = new System.Drawing.Size(34, 40);
            this.btnGlobalNav.TabIndex = 146;
            this.btnGlobalNav.TabStop = false;
            this.btnGlobalNav.Text = "...";
            this.btnGlobalNav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.btnGlobalNav, "Open Navigation");
            this.btnGlobalNav.UseVisualStyleBackColor = false;
            this.btnGlobalNav.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExtensions
            // 
            this.btnExtensions.AutoSize = true;
            this.btnExtensions.BackColor = System.Drawing.Color.White;
            this.btnExtensions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExtensions.FlatAppearance.BorderSize = 0;
            this.btnExtensions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtensions.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtensions.ForeColor = System.Drawing.Color.DimGray;
            this.btnExtensions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtensions.Location = new System.Drawing.Point(10, 302);
            this.btnExtensions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExtensions.Name = "btnExtensions";
            this.btnExtensions.Size = new System.Drawing.Size(34, 40);
            this.btnExtensions.TabIndex = 145;
            this.btnExtensions.TabStop = false;
            this.btnExtensions.Text = "5";
            this.btnExtensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.btnExtensions, "Create tweaks");
            this.btnExtensions.UseVisualStyleBackColor = false;
            this.btnExtensions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnExtensions_MouseDown);
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(10, 56);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 40);
            this.btnHome.TabIndex = 144;
            this.btnHome.Text = "0";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.btnHome, "Home");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseDown);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.AutoSize = true;
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.DimGray;
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(10, 998);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(34, 40);
            this.btnSettings.TabIndex = 143;
            this.btnSettings.Text = "..";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseDown);
            // 
            // btnAutomate
            // 
            this.btnAutomate.AutoSize = true;
            this.btnAutomate.BackColor = System.Drawing.Color.White;
            this.btnAutomate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutomate.FlatAppearance.BorderSize = 0;
            this.btnAutomate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutomate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomate.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomate.ForeColor = System.Drawing.Color.DimGray;
            this.btnAutomate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAutomate.Location = new System.Drawing.Point(10, 252);
            this.btnAutomate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(34, 40);
            this.btnAutomate.TabIndex = 142;
            this.btnAutomate.TabStop = false;
            this.btnAutomate.Text = "4";
            this.btnAutomate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.btnAutomate, "Automate tasks");
            this.btnAutomate.UseVisualStyleBackColor = false;
            this.btnAutomate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAutomate_MouseDown);
            // 
            // btnPackages
            // 
            this.btnPackages.AutoSize = true;
            this.btnPackages.BackColor = System.Drawing.Color.White;
            this.btnPackages.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.Color.DimGray;
            this.btnPackages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPackages.Location = new System.Drawing.Point(10, 202);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(34, 40);
            this.btnPackages.TabIndex = 141;
            this.btnPackages.TabStop = false;
            this.btnPackages.Text = "3";
            this.btnPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.btnPackages, "Install packages");
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPackages_MouseDown);
            // 
            // btnApps
            // 
            this.btnApps.AutoSize = true;
            this.btnApps.BackColor = System.Drawing.Color.White;
            this.btnApps.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApps.FlatAppearance.BorderSize = 0;
            this.btnApps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApps.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApps.ForeColor = System.Drawing.Color.DimGray;
            this.btnApps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApps.Location = new System.Drawing.Point(10, 152);
            this.btnApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(34, 40);
            this.btnApps.TabIndex = 140;
            this.btnApps.TabStop = false;
            this.btnApps.Text = "2";
            this.btnApps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.btnApps, "Debloat Windows 11");
            this.btnApps.UseVisualStyleBackColor = false;
            this.btnApps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnApps_MouseDown);
            // 
            // btnCustomize
            // 
            this.btnCustomize.AutoSize = true;
            this.btnCustomize.BackColor = System.Drawing.Color.White;
            this.btnCustomize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomize.FlatAppearance.BorderSize = 0;
            this.btnCustomize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomize.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomize.ForeColor = System.Drawing.Color.DimGray;
            this.btnCustomize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCustomize.Location = new System.Drawing.Point(10, 102);
            this.btnCustomize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(34, 40);
            this.btnCustomize.TabIndex = 139;
            this.btnCustomize.TabStop = false;
            this.btnCustomize.Text = "1";
            this.btnCustomize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.btnCustomize, "Customize Windows 11");
            this.btnCustomize.UseVisualStyleBackColor = false;
            this.btnCustomize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCustomize_MouseDown);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(48, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1500, 1055);
            this.pnlContainer.TabIndex = 136;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainComponents});
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMain.Size = new System.Drawing.Size(201, 40);
            // 
            // menuMainComponents
            // 
            this.menuMainComponents.Name = "menuMainComponents";
            this.menuMainComponents.Size = new System.Drawing.Size(200, 36);
            this.menuMainComponents.Text = "Extensions";
            // 
            // tt
            // 
            this.tt.AutomaticDelay = 0;
            this.tt.AutoPopDelay = 0;
            this.tt.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tt.ForeColor = System.Drawing.Color.White;
            this.tt.InitialDelay = 0;
            this.tt.ReshowDelay = 0;
            this.tt.UseAnimation = false;
            this.tt.UseFading = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1548, 1055);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNav);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1473, 999);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "ThisIsWin11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlNav;
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
        public System.Windows.Forms.Button btnGlobalNav;
    }
}

