
namespace ThisIsWin11
{
    partial class HomeWindow
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
            this.btnConfigurator = new ThisIsWin11.Controls.RoundedButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCustomizer = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCustomButton = new ThisIsWin11.Controls.RoundedButton();
            this.menuGetStarted = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuGetStartedInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new ThisIsWin11.Controls.RoundedButton();
            this.btnBack = new ThisIsWin11.Controls.RoundedButton();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new ThisIsWin11.Controls.RoundedButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.menuGetStarted.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfigurator
            // 
            this.btnConfigurator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfigurator.AutoEllipsis = true;
            this.btnConfigurator.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurator.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnConfigurator.FlatAppearance.BorderSize = 0;
            this.btnConfigurator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigurator.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurator.ForeColor = System.Drawing.Color.Black;
            this.btnConfigurator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfigurator.Location = new System.Drawing.Point(292, 554);
            this.btnConfigurator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfigurator.Name = "btnConfigurator";
            this.btnConfigurator.Size = new System.Drawing.Size(207, 40);
            this.btnConfigurator.TabIndex = 137;
            this.btnConfigurator.Text = "Configure settings";
            this.btnConfigurator.UseVisualStyleBackColor = false;
            this.btnConfigurator.Visible = false;
            this.btnConfigurator.Click += new System.EventHandler(this.btnConfigurator_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(60, 126);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(577, 47);
            this.lblHeader.TabIndex = 134;
            this.lblHeader.Text = "Hi";
            // 
            // btnCustomizer
            // 
            this.btnCustomizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomizer.AutoEllipsis = true;
            this.btnCustomizer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomizer.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnCustomizer.FlatAppearance.BorderSize = 3;
            this.btnCustomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizer.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizer.ForeColor = System.Drawing.Color.White;
            this.btnCustomizer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCustomizer.Location = new System.Drawing.Point(68, 554);
            this.btnCustomizer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomizer.Name = "btnCustomizer";
            this.btnCustomizer.Size = new System.Drawing.Size(207, 40);
            this.btnCustomizer.TabIndex = 138;
            this.btnCustomizer.Text = "Customizations available";
            this.btnCustomizer.UseVisualStyleBackColor = false;
            this.btnCustomizer.Visible = false;
            this.btnCustomizer.Click += new System.EventHandler(this.btnCustomizer_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.btnConfigurator);
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Controls.Add(this.linkLabel1);
            this.pnlLeft.Controls.Add(this.lblDesc);
            this.pnlLeft.Controls.Add(this.btnCustomButton);
            this.pnlLeft.Controls.Add(this.btnCustomizer);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(670, 862);
            this.pnlLeft.TabIndex = 164;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(13, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(519, 18);
            this.linkLabel1.TabIndex = 24;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoEllipsis = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesc.Location = new System.Drawing.Point(68, 206);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(575, 326);
            this.lblDesc.TabIndex = 137;
            this.lblDesc.Text = "cheat sheet";
            // 
            // btnCustomButton
            // 
            this.btnCustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomButton.AutoEllipsis = true;
            this.btnCustomButton.BackColor = System.Drawing.Color.Magenta;
            this.btnCustomButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnCustomButton.FlatAppearance.BorderSize = 0;
            this.btnCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomButton.Location = new System.Drawing.Point(68, 554);
            this.btnCustomButton.Name = "btnCustomButton";
            this.btnCustomButton.Size = new System.Drawing.Size(207, 40);
            this.btnCustomButton.TabIndex = 156;
            this.btnCustomButton.Text = "TWEET ABOUT THIS APP";
            this.btnCustomButton.UseVisualStyleBackColor = false;
            this.btnCustomButton.Click += new System.EventHandler(this.btnCustomButton_Click);
            // 
            // menuGetStarted
            // 
            this.menuGetStarted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuGetStarted.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGetStarted.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGetStartedInfo});
            this.menuGetStarted.Name = "menuMain";
            this.menuGetStarted.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuGetStarted.Size = new System.Drawing.Size(118, 34);
            // 
            // menuGetStartedInfo
            // 
            this.menuGetStartedInfo.Name = "menuGetStartedInfo";
            this.menuGetStartedInfo.Size = new System.Drawing.Size(117, 30);
            this.menuGetStartedInfo.Text = "Info";
            // 
            // tt
            // 
            this.tt.AutomaticDelay = 0;
            this.tt.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tt.ForeColor = System.Drawing.Color.White;
            this.tt.IsBalloon = true;
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt.ToolTipTitle = "Get started with Tips in Windows 11";
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ForeColor = System.Drawing.Color.Gray;
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.DimGray;
            this.lnkSubHeader.Location = new System.Drawing.Point(6, 0);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(531, 18);
            this.lnkSubHeader.TabIndex = 24;
            this.lnkSubHeader.TabStop = true;
            this.lnkSubHeader.Text = "OS";
            this.lnkSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.cbTable);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 799);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 63);
            this.panel1.TabIndex = 157;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(499, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 32);
            this.btnNext.TabIndex = 135;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(464, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 32);
            this.btnBack.TabIndex = 136;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbTable
            // 
            this.cbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTable.BackColor = System.Drawing.Color.White;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(248, 27);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 24);
            this.cbTable.TabIndex = 135;
            this.cbTable.Visible = false;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(429, 19);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 32);
            this.btnRefresh.TabIndex = 128;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.lnkSubHeader);
            this.pnlRight.Controls.Add(this.pbView);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(670, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(540, 862);
            this.pnlRight.TabIndex = 163;
            // 
            // pbView
            // 
            this.pbView.BackColor = System.Drawing.Color.Transparent;
            this.pbView.ErrorImage = null;
            this.pbView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbView.InitialImage = null;
            this.pbView.Location = new System.Drawing.Point(0, 110);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(540, 683);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbView.TabIndex = 127;
            this.pbView.TabStop = false;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomeWindow";
            this.ShowIcon = false;
            this.Text = "GetStarted";
            this.Shown += new System.EventHandler(this.HomeWindow_Shown);
            this.pnlLeft.ResumeLayout(false);
            this.menuGetStarted.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCustomizer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip menuGetStarted;
        private System.Windows.Forms.ToolStripMenuItem menuGetStartedInfo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.Panel panel1;
        private ThisIsWin11.Controls.RoundedButton btnNext;
        private ThisIsWin11.Controls.RoundedButton btnBack;
        private System.Windows.Forms.ComboBox cbTable;
        private ThisIsWin11.Controls.RoundedButton btnRefresh;
        private System.Windows.Forms.Panel pnlRight;
        public System.Windows.Forms.PictureBox pbView;
        private ThisIsWin11.Controls.RoundedButton btnConfigurator;
        private ThisIsWin11.Controls.RoundedButton btnCustomButton;
    }
}