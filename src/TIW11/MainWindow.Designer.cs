
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblFeature = new System.Windows.Forms.Label();
            this.btnRecheck = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Button();
            this.richDesc = new System.Windows.Forms.RichTextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnPresenter = new System.Windows.Forms.CheckBox();
            this.btnShareScreen = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.assetOpenGitHub = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetOpenGitHub)).BeginInit();
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
            this.pnlLeft.Size = new System.Drawing.Size(404, 770);
            this.pnlLeft.TabIndex = 130;
            // 
            // lblFeature
            // 
            this.lblFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeature.AutoEllipsis = true;
            this.lblFeature.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFeature.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFeature.Location = new System.Drawing.Point(12, 21);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(338, 32);
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
            this.btnRecheck.Location = new System.Drawing.Point(351, 0);
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
            this.richDesc.Size = new System.Drawing.Size(383, 609);
            this.richDesc.TabIndex = 133;
            this.richDesc.Text = "";
            this.richDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richDesc_LinkClicked);
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
            this.btnPrev.Size = new System.Drawing.Size(343, 32);
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
            this.btnNext.Size = new System.Drawing.Size(343, 32);
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
            this.pnlMiddle.Controls.Add(this.btnPrev);
            this.pnlMiddle.Controls.Add(this.btnPresenter);
            this.pnlMiddle.Controls.Add(this.btnShareScreen);
            this.pnlMiddle.Controls.Add(this.btnNext);
            this.pnlMiddle.Controls.Add(this.lblHeader);
            this.pnlMiddle.Controls.Add(this.lnkSubHeader);
            this.pnlMiddle.Location = new System.Drawing.Point(401, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(381, 770);
            this.pnlMiddle.TabIndex = 134;
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
            this.btnPresenter.Size = new System.Drawing.Size(343, 32);
            this.btnPresenter.TabIndex = 130;
            this.btnPresenter.Text = "Show the Magic";
            this.btnPresenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPresenter.UseVisualStyleBackColor = false;
            this.btnPresenter.CheckedChanged += new System.EventHandler(this.btnPresenter_CheckedChanged);
            // 
            // btnShareScreen
            // 
            this.btnShareScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShareScreen.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShareScreen.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnShareScreen.FlatAppearance.BorderSize = 0;
            this.btnShareScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShareScreen.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.btnShareScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShareScreen.Location = new System.Drawing.Point(18, 288);
            this.btnShareScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShareScreen.Name = "btnShareScreen";
            this.btnShareScreen.Size = new System.Drawing.Size(343, 32);
            this.btnShareScreen.TabIndex = 129;
            this.btnShareScreen.Text = "Capture and Share on Twitter";
            this.btnShareScreen.UseVisualStyleBackColor = false;
            this.btnShareScreen.Click += new System.EventHandler(this.btnShareScreen_Click);
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
            this.lblHeader.Size = new System.Drawing.Size(349, 32);
            this.lblHeader.TabIndex = 25;
            this.lblHeader.Text = "What\'s new in Windows 11";
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.DeepPink;
            this.lnkSubHeader.Location = new System.Drawing.Point(13, 68);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(348, 18);
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
            this.pnlRight.Controls.Add(this.pbView);
            this.pnlRight.Controls.Add(this.assetOpenGitHub);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(771, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(395, 770);
            this.pnlRight.TabIndex = 135;
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
            // assetOpenGitHub
            // 
            this.assetOpenGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetOpenGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assetOpenGitHub.Image = ((System.Drawing.Image)(resources.GetObject("assetOpenGitHub.Image")));
            this.assetOpenGitHub.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.assetOpenGitHub.Location = new System.Drawing.Point(359, 10);
            this.assetOpenGitHub.Name = "assetOpenGitHub";
            this.assetOpenGitHub.Size = new System.Drawing.Size(24, 24);
            this.assetOpenGitHub.TabIndex = 129;
            this.assetOpenGitHub.TabStop = false;
            this.assetOpenGitHub.Click += new System.EventHandler(this.assetOpenGitHub_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.assetOpenGitHub)).EndInit();
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
        private System.Windows.Forms.Button btnShareScreen;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.PictureBox assetOpenGitHub;
    }
}

