
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
            this.lblFeature = new System.Windows.Forms.Label();
            this.btnRecheck = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Button();
            this.richDesc = new System.Windows.Forms.RichTextBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnConfigurator = new System.Windows.Forms.Button();
            this.btnPresenter = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionCaptureToShare = new System.Windows.Forms.ToolStripMenuItem();
            this.infoApp = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoSize = true;
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Controls.Add(this.lblFeature);
            this.pnlLeft.Controls.Add(this.btnRecheck);
            this.pnlLeft.Controls.Add(this.lblMainMenu);
            this.pnlLeft.Controls.Add(this.richDesc);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(411, 770);
            this.pnlLeft.TabIndex = 130;
            // 
            // lblFeature
            // 
            this.lblFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeature.AutoEllipsis = true;
            this.lblFeature.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFeature.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFeature.Location = new System.Drawing.Point(13, 19);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(290, 32);
            this.lblFeature.TabIndex = 134;
            this.lblFeature.Text = "Welcome";
            // 
            // btnRecheck
            // 
            this.btnRecheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecheck.AutoSize = true;
            this.btnRecheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecheck.FlatAppearance.BorderSize = 0;
            this.btnRecheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRecheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecheck.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecheck.ForeColor = System.Drawing.Color.Black;
            this.btnRecheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRecheck.Location = new System.Drawing.Point(350, 0);
            this.btnRecheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecheck.Name = "btnRecheck";
            this.btnRecheck.Size = new System.Drawing.Size(48, 51);
            this.btnRecheck.TabIndex = 128;
            this.tt.SetToolTip(this.btnRecheck, "Goto Welcome page");
            this.btnRecheck.UseVisualStyleBackColor = true;
            this.btnRecheck.Click += new System.EventHandler(this.btnRecheck_Click);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainMenu.FlatAppearance.BorderSize = 0;
            this.lblMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.lblMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMainMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.Black;
            this.lblMainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMainMenu.Location = new System.Drawing.Point(0, 2);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(48, 51);
            this.lblMainMenu.TabIndex = 113;
            this.lblMainMenu.UseVisualStyleBackColor = false;
            this.lblMainMenu.Visible = false;
            // 
            // richDesc
            // 
            this.richDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richDesc.Location = new System.Drawing.Point(18, 138);
            this.richDesc.Name = "richDesc";
            this.richDesc.ReadOnly = true;
            this.richDesc.Size = new System.Drawing.Size(366, 609);
            this.richDesc.TabIndex = 133;
            this.richDesc.Text = "";
            this.richDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richDesc_LinkClicked);
            // 
            // cbTable
            // 
            this.cbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(262, 735);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 23);
            this.cbTable.TabIndex = 135;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(18, 142);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(333, 32);
            this.btnPrev.TabIndex = 136;
            this.btnPrev.Text = "< Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(18, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(333, 32);
            this.btnNext.TabIndex = 135;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMiddle.AutoScroll = true;
            this.pnlMiddle.BackColor = System.Drawing.Color.White;
            this.pnlMiddle.Controls.Add(this.btnConfigurator);
            this.pnlMiddle.Controls.Add(this.btnPrev);
            this.pnlMiddle.Controls.Add(this.btnPresenter);
            this.pnlMiddle.Controls.Add(this.btnNext);
            this.pnlMiddle.Controls.Add(this.lblHeader);
            this.pnlMiddle.Controls.Add(this.lnkSubHeader);
            this.pnlMiddle.Location = new System.Drawing.Point(401, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(371, 770);
            this.pnlMiddle.TabIndex = 134;
            // 
            // btnConfigurator
            // 
            this.btnConfigurator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigurator.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurator.Enabled = false;
            this.btnConfigurator.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurator.FlatAppearance.BorderSize = 0;
            this.btnConfigurator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurator.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnConfigurator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfigurator.Location = new System.Drawing.Point(18, 289);
            this.btnConfigurator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfigurator.Name = "btnConfigurator";
            this.btnConfigurator.Size = new System.Drawing.Size(333, 32);
            this.btnConfigurator.TabIndex = 137;
            this.btnConfigurator.Text = "Configure this page";
            this.btnConfigurator.UseVisualStyleBackColor = false;
            // 
            // btnPresenter
            // 
            this.btnPresenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPresenter.BackColor = System.Drawing.Color.HotPink;
            this.btnPresenter.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPresenter.FlatAppearance.BorderSize = 0;
            this.btnPresenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.HotPink;
            this.btnPresenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresenter.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnPresenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPresenter.Location = new System.Drawing.Point(18, 182);
            this.btnPresenter.Name = "btnPresenter";
            this.btnPresenter.Size = new System.Drawing.Size(333, 32);
            this.btnPresenter.TabIndex = 130;
            this.btnPresenter.Text = "Show the magic";
            this.btnPresenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPresenter.UseVisualStyleBackColor = false;
            this.btnPresenter.CheckedChanged += new System.EventHandler(this.btnPresenter_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(12, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(339, 32);
            this.lblHeader.TabIndex = 25;
            this.lblHeader.Text = "What\'s new in Windows 11";
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.DeepPink;
            this.lnkSubHeader.Location = new System.Drawing.Point(13, 68);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(338, 18);
            this.lnkSubHeader.TabIndex = 24;
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.btnSettings);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.cbTable);
            this.pnlRight.Controls.Add(this.pbView);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(771, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(395, 770);
            this.pnlRight.TabIndex = 135;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(344, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(48, 51);
            this.btnSettings.TabIndex = 136;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 135;
            this.label1.Text = "Preview";
            // 
            // pbView
            // 
            this.pbView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbView.Location = new System.Drawing.Point(0, 116);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(395, 654);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbView.TabIndex = 127;
            this.pbView.TabStop = false;
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionCaptureToShare,
            this.infoApp});
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMain.Size = new System.Drawing.Size(331, 64);
            // 
            // optionCaptureToShare
            // 
            this.optionCaptureToShare.Name = "optionCaptureToShare";
            this.optionCaptureToShare.Size = new System.Drawing.Size(330, 30);
            this.optionCaptureToShare.Text = "Capture and Share on Twitter";
            this.optionCaptureToShare.Click += new System.EventHandler(this.optionCaptureToShare_Click);
            // 
            // infoApp
            // 
            this.infoApp.Name = "infoApp";
            this.infoApp.Size = new System.Drawing.Size(330, 30);
            this.infoApp.Text = "About this App";
            this.infoApp.Click += new System.EventHandler(this.infoApp_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 770);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlLeft);
            this.MinimumSize = new System.Drawing.Size(814, 735);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11 ";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnRecheck;
        private System.Windows.Forms.Button lblMainMenu;
        private System.Windows.Forms.RichTextBox richDesc;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.CheckBox btnPresenter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigurator;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem infoApp;
        private System.Windows.Forms.ToolStripMenuItem optionCaptureToShare;
    }
}

