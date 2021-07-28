
namespace ThisIsWin11
{
    partial class TweakerWindow
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
            this.menuTweaksImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTweaksEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTweaksSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTweaker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuTweaksApplied = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTweakerNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstPS = new System.Windows.Forms.CheckedListBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnTweakerMenu = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.menuTweaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTweaksImport
            // 
            this.menuTweaksImport.Name = "menuTweaksImport";
            this.menuTweaksImport.Size = new System.Drawing.Size(411, 30);
            this.menuTweaksImport.Text = "Import";
            this.menuTweaksImport.Click += new System.EventHandler(this.menuTweaksImport_Click);
            // 
            // menuTweaksEdit
            // 
            this.menuTweaksEdit.Name = "menuTweaksEdit";
            this.menuTweaksEdit.Size = new System.Drawing.Size(411, 30);
            this.menuTweaksEdit.Text = "Edit ";
            this.menuTweaksEdit.Click += new System.EventHandler(this.menuTweaksEdit_Click);
            // 
            // menuTweaksSave
            // 
            this.menuTweaksSave.Name = "menuTweaksSave";
            this.menuTweaksSave.Size = new System.Drawing.Size(411, 30);
            this.menuTweaksSave.Text = "Save current script as new preset script";
            this.menuTweaksSave.Click += new System.EventHandler(this.menuTweaksSave_Click);
            // 
            // menuTweaker
            // 
            this.menuTweaker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTweaker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTweaksImport,
            this.menuTweaksEdit,
            this.menuTweaksSave,
            this.menuTweaksApplied,
            this.menuTweakerNewWindow});
            this.menuTweaker.Name = "menuMain";
            this.menuTweaker.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuTweaker.Size = new System.Drawing.Size(412, 154);
            // 
            // menuTweaksApplied
            // 
            this.menuTweaksApplied.Name = "menuTweaksApplied";
            this.menuTweaksApplied.Size = new System.Drawing.Size(411, 30);
            this.menuTweaksApplied.Text = "Show applied";
            this.menuTweaksApplied.Click += new System.EventHandler(this.menuTweaksApplied_Click);
            // 
            // menuTweakerNewWindow
            // 
            this.menuTweakerNewWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTweakerNewWindow.Name = "menuTweakerNewWindow";
            this.menuTweakerNewWindow.Size = new System.Drawing.Size(411, 30);
            this.menuTweakerNewWindow.Text = "Open in new window";
            this.menuTweakerNewWindow.Click += new System.EventHandler(this.menuTweakerNewWindow_Click);
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
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(78, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 30);
            this.btnCancel.TabIndex = 160;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.lblSubHeader.Size = new System.Drawing.Size(163, 32);
            this.lblSubHeader.TabIndex = 159;
            this.lblSubHeader.Text = "Apply Tweaks";
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
            this.btnBack.TabIndex = 158;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstPS
            // 
            this.lstPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPS.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPS.ForeColor = System.Drawing.Color.Black;
            this.lstPS.FormattingEnabled = true;
            this.lstPS.Location = new System.Drawing.Point(27, 132);
            this.lstPS.Name = "lstPS";
            this.lstPS.Size = new System.Drawing.Size(373, 308);
            this.lstPS.Sorted = true;
            this.lstPS.TabIndex = 157;
            this.lstPS.ThreeDCheckBoxes = true;
            this.lstPS.SelectedIndexChanged += new System.EventHandler(this.lstPS_SelectedIndexChanged);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progress.Location = new System.Drawing.Point(27, 746);
            this.progress.MarqueeAnimationSpeed = 30;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(213, 5);
            this.progress.TabIndex = 156;
            this.progress.Visible = false;
            // 
            // btnTweakerMenu
            // 
            this.btnTweakerMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTweakerMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTweakerMenu.FlatAppearance.BorderSize = 0;
            this.btnTweakerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTweakerMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTweakerMenu.Location = new System.Drawing.Point(353, 0);
            this.btnTweakerMenu.Name = "btnTweakerMenu";
            this.btnTweakerMenu.Size = new System.Drawing.Size(48, 51);
            this.btnTweakerMenu.TabIndex = 155;
            this.btnTweakerMenu.UseVisualStyleBackColor = false;
            this.btnTweakerMenu.Click += new System.EventHandler(this.btnTweakerMenu_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.BackColor = System.Drawing.Color.Gainsboro;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(27, 697);
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
            this.rtbDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.Location = new System.Drawing.Point(27, 486);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(374, 180);
            this.rtbDesc.TabIndex = 153;
            this.rtbDesc.Text = "";
            this.rtbDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbDesc_LinkClicked);
            // 
            // TweakerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 770);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstPS);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnTweakerMenu);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TweakerWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TweakerWindow_FormClosing);
            this.Load += new System.EventHandler(this.TweakerWindow_Load);
            this.menuTweaker.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuTweaksImport;
        private System.Windows.Forms.ToolStripMenuItem menuTweaksEdit;
        private System.Windows.Forms.ToolStripMenuItem menuTweaksSave;
        private System.Windows.Forms.ContextMenuStrip menuTweaker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox lstPS;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnTweakerMenu;
        private System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.ToolStripMenuItem menuTweaksApplied;
        private System.Windows.Forms.ToolStripMenuItem menuTweakerNewWindow;
    }
}