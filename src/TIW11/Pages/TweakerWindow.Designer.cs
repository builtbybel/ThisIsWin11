
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
            this.lstPS = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.richDesc = new System.Windows.Forms.RichTextBox();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lstPS.Location = new System.Drawing.Point(27, 135);
            this.lstPS.Name = "lstPS";
            this.lstPS.Size = new System.Drawing.Size(353, 286);
            this.lstPS.Sorted = true;
            this.lstPS.TabIndex = 138;
            this.lstPS.ThreeDCheckBoxes = true;
            this.lstPS.SelectedIndexChanged += new System.EventHandler(this.lstPS_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(16, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 32);
            this.btnBack.TabIndex = 139;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // richDesc
            // 
            this.richDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richDesc.Location = new System.Drawing.Point(27, 442);
            this.richDesc.Name = "richDesc";
            this.richDesc.ReadOnly = true;
            this.richDesc.Size = new System.Drawing.Size(353, 206);
            this.richDesc.TabIndex = 140;
            this.richDesc.Text = "";
            this.richDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richDesc_LinkClicked);
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
            this.lblSubHeader.Size = new System.Drawing.Size(310, 32);
            this.lblSubHeader.TabIndex = 141;
            this.lblSubHeader.Text = "Community customizations";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.Gainsboro;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(104, 680);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(213, 30);
            this.btnApply.TabIndex = 142;
            this.btnApply.Text = "Apply selected";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(27, 680);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(50, 30);
            this.btnImport.TabIndex = 143;
            this.btnImport.Text = "+";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // TweakerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 761);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.richDesc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstPS);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TweakerWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThisIsWin11";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TweakerWindow_FormClosing);
            this.Shown += new System.EventHandler(this.TweakerWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstPS;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.RichTextBox richDesc;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnImport;
    }
}