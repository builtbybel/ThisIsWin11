
namespace ThisIsWin11
{
    partial class AutomateWindow
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
            this.menuAutomateImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomateEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomateSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAutomateApplied = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomatePopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomateSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuAutomateInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstPS = new System.Windows.Forms.CheckedListBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnAutomateMenu = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblModuleInfo = new System.Windows.Forms.LinkLabel();
            this.btnAutomateOnTheFly = new System.Windows.Forms.Button();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.menuAutomate.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAutomateImport
            // 
            this.menuAutomateImport.Name = "menuAutomateImport";
            this.menuAutomateImport.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateImport.Text = "Import";
            this.menuAutomateImport.Click += new System.EventHandler(this.menuAutomateImport_Click);
            // 
            // menuAutomateEdit
            // 
            this.menuAutomateEdit.Name = "menuAutomateEdit";
            this.menuAutomateEdit.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateEdit.Text = "Edit ";
            this.menuAutomateEdit.Click += new System.EventHandler(this.menuAutomateEdit_Click);
            // 
            // menuAutomateSave
            // 
            this.menuAutomateSave.Name = "menuAutomateSave";
            this.menuAutomateSave.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateSave.Text = "Save current script as new preset script";
            this.menuAutomateSave.Click += new System.EventHandler(this.menuAutomateSave_Click);
            // 
            // menuAutomate
            // 
            this.menuAutomate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuAutomate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAutomate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAutomateImport,
            this.menuAutomateEdit,
            this.menuAutomateSave,
            this.menuAutomateApplied,
            this.menuAutomatePopOut,
            this.menuAutomateSeparator,
            this.menuAutomateInfo});
            this.menuAutomate.Name = "menuMain";
            this.menuAutomate.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuAutomate.Size = new System.Drawing.Size(412, 190);
            // 
            // menuAutomateApplied
            // 
            this.menuAutomateApplied.Name = "menuAutomateApplied";
            this.menuAutomateApplied.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateApplied.Text = "Show applied";
            this.menuAutomateApplied.Click += new System.EventHandler(this.menuAutomateApplied_Click);
            // 
            // menuAutomatePopOut
            // 
            this.menuAutomatePopOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAutomatePopOut.Name = "menuAutomatePopOut";
            this.menuAutomatePopOut.Size = new System.Drawing.Size(411, 30);
            this.menuAutomatePopOut.Text = "Pop-out-App";
            this.menuAutomatePopOut.Click += new System.EventHandler(this.menuAutomatePopOut_Click);
            // 
            // menuAutomateSeparator
            // 
            this.menuAutomateSeparator.Name = "menuAutomateSeparator";
            this.menuAutomateSeparator.Size = new System.Drawing.Size(408, 6);
            // 
            // menuAutomateInfo
            // 
            this.menuAutomateInfo.Name = "menuAutomateInfo";
            this.menuAutomateInfo.Size = new System.Drawing.Size(411, 30);
            this.menuAutomateInfo.Text = "Info";
            this.menuAutomateInfo.Click += new System.EventHandler(this.menuAutomateInfo_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 770);
            this.panel1.TabIndex = 146;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(251, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 30);
            this.btnCancel.TabIndex = 160;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(24, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(186, 32);
            this.lblHeader.TabIndex = 159;
            this.lblHeader.Text = "Automate tasks";
            // 
            // lstPS
            // 
            this.lstPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPS.BackColor = System.Drawing.Color.White;
            this.lstPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPS.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPS.ForeColor = System.Drawing.Color.Black;
            this.lstPS.FormattingEnabled = true;
            this.lstPS.Location = new System.Drawing.Point(24, 94);
            this.lstPS.Name = "lstPS";
            this.lstPS.Size = new System.Drawing.Size(685, 352);
            this.lstPS.Sorted = true;
            this.lstPS.TabIndex = 157;
            this.lstPS.ThreeDCheckBoxes = true;
            this.lstPS.SelectedIndexChanged += new System.EventHandler(this.lstPS_SelectedIndexChanged);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(30, 78);
            this.progress.MarqueeAnimationSpeed = 30;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(663, 5);
            this.progress.TabIndex = 156;
            this.progress.Visible = false;
            // 
            // btnAutomateMenu
            // 
            this.btnAutomateMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutomateMenu.BackColor = System.Drawing.Color.White;
            this.btnAutomateMenu.FlatAppearance.BorderSize = 0;
            this.btnAutomateMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomateMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomateMenu.Location = new System.Drawing.Point(667, 0);
            this.btnAutomateMenu.Name = "btnAutomateMenu";
            this.btnAutomateMenu.Size = new System.Drawing.Size(48, 51);
            this.btnAutomateMenu.TabIndex = 155;
            this.btnAutomateMenu.UseVisualStyleBackColor = false;
            this.btnAutomateMenu.Click += new System.EventHandler(this.btnAutomateMenu_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.BackColor = System.Drawing.Color.Gainsboro;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(24, 24);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(213, 30);
            this.btnApply.TabIndex = 154;
            this.btnApply.Text = "Apply selected";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rtbDesc
            // 
            this.rtbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDesc.BackColor = System.Drawing.Color.White;
            this.rtbDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.Location = new System.Drawing.Point(24, 500);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(686, 180);
            this.rtbDesc.TabIndex = 153;
            this.rtbDesc.Text = "";
            this.rtbDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbDesc_LinkClicked);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.lblModuleInfo);
            this.pnlRight.Controls.Add(this.btnAutomateOnTheFly);
            this.pnlRight.Controls.Add(this.lblModuleName);
            this.pnlRight.Controls.Add(this.rtbPS);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(716, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(371, 770);
            this.pnlRight.TabIndex = 161;
            // 
            // lblModuleInfo
            // 
            this.lblModuleInfo.AutoEllipsis = true;
            this.lblModuleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblModuleInfo.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblModuleInfo.Location = new System.Drawing.Point(24, 59);
            this.lblModuleInfo.Name = "lblModuleInfo";
            this.lblModuleInfo.Size = new System.Drawing.Size(320, 17);
            this.lblModuleInfo.TabIndex = 160;
            this.lblModuleInfo.TabStop = true;
            this.lblModuleInfo.Text = "Learn more about PowerUI";
            this.lblModuleInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblModuleInfo_LinkClicked_1);
            // 
            // btnAutomateOnTheFly
            // 
            this.btnAutomateOnTheFly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutomateOnTheFly.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAutomateOnTheFly.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAutomateOnTheFly.FlatAppearance.BorderSize = 0;
            this.btnAutomateOnTheFly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomateOnTheFly.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomateOnTheFly.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutomateOnTheFly.Location = new System.Drawing.Point(27, 721);
            this.btnAutomateOnTheFly.Name = "btnAutomateOnTheFly";
            this.btnAutomateOnTheFly.Size = new System.Drawing.Size(213, 30);
            this.btnAutomateOnTheFly.TabIndex = 155;
            this.btnAutomateOnTheFly.Text = "Run this code on-the-fly";
            this.btnAutomateOnTheFly.UseVisualStyleBackColor = false;
            this.btnAutomateOnTheFly.Visible = false;
            this.btnAutomateOnTheFly.Click += new System.EventHandler(this.btnAutomateOnTheFly_Click);
            // 
            // lblModuleName
            // 
            this.lblModuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModuleName.AutoEllipsis = true;
            this.lblModuleName.BackColor = System.Drawing.Color.Transparent;
            this.lblModuleName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.ForeColor = System.Drawing.Color.Black;
            this.lblModuleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModuleName.Location = new System.Drawing.Point(21, 21);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(323, 32);
            this.lblModuleName.TabIndex = 135;
            this.lblModuleName.Text = "PowerUI";
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.Location = new System.Drawing.Point(27, 110);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.Size = new System.Drawing.Size(343, 580);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Location = new System.Drawing.Point(28, 57);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(660, 18);
            this.lnkSubHeader.TabIndex = 172;
            // 
            // pnlBottom
            // 
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 697);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(716, 73);
            this.pnlBottom.TabIndex = 173;
            // 
            // AutomateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lnkSubHeader);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lstPS);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnAutomateMenu);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AutomateWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerUI";
            this.Load += new System.EventHandler(this.AutomateWindow_Load);
            this.menuAutomate.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuAutomateImport;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateEdit;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateSave;
        private System.Windows.Forms.ContextMenuStrip menuAutomate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.CheckedListBox lstPS;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnAutomateMenu;
        private System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateApplied;
        private System.Windows.Forms.ToolStripMenuItem menuAutomatePopOut;
        private System.Windows.Forms.ToolStripMenuItem menuAutomateInfo;
        private System.Windows.Forms.ToolStripSeparator menuAutomateSeparator;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblModuleName;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.Button btnAutomateOnTheFly;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.LinkLabel lblModuleInfo;
        private System.Windows.Forms.Panel pnlBottom;
    }
}