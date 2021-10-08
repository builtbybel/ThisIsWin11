
namespace ThisIsWin11
{
    partial class PluginsWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewPlugins = new System.Windows.Forms.DataGridView();
            this.ColumnState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnPluginsMenu = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkPluginsAttribution = new System.Windows.Forms.LinkLabel();
            this.lblPluginsAttribution = new System.Windows.Forms.Label();
            this.menuPlugins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPluginsPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPluginsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkPluginsDir = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlugins)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.menuPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewPlugins
            // 
            this.DataGridViewPlugins.AllowUserToAddRows = false;
            this.DataGridViewPlugins.AllowUserToDeleteRows = false;
            this.DataGridViewPlugins.AllowUserToOrderColumns = true;
            this.DataGridViewPlugins.AllowUserToResizeColumns = false;
            this.DataGridViewPlugins.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewPlugins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewPlugins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewPlugins.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewPlugins.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewPlugins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewPlugins.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridViewPlugins.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            this.DataGridViewPlugins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPlugins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnState,
            this.ColumnName,
            this.ColumnDescription,
            this.ColumnAuthor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPlugins.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewPlugins.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewPlugins.EnableHeadersVisualStyles = false;
            this.DataGridViewPlugins.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewPlugins.Location = new System.Drawing.Point(24, 166);
            this.DataGridViewPlugins.MultiSelect = false;
            this.DataGridViewPlugins.Name = "DataGridViewPlugins";
            this.DataGridViewPlugins.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPlugins.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPlugins.RowHeadersVisible = false;
            this.DataGridViewPlugins.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewPlugins.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPlugins.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewPlugins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewPlugins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewPlugins.ShowEditingIcon = false;
            this.DataGridViewPlugins.Size = new System.Drawing.Size(1051, 502);
            this.DataGridViewPlugins.TabIndex = 141;
            this.DataGridViewPlugins.TabStop = false;
            this.DataGridViewPlugins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPlugins_CellContentClick);
            this.DataGridViewPlugins.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridViewPlugins_RowPrePaint);
            this.DataGridViewPlugins.SelectionChanged += new System.EventHandler(this.DataGridViewPlugins_SelectionChanged);
            // 
            // ColumnState
            // 
            this.ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnState.DataPropertyName = "State";
            this.ColumnState.FalseValue = "0";
            this.ColumnState.Frozen = true;
            this.ColumnState.HeaderText = "Status";
            this.ColumnState.IndeterminateValue = "2";
            this.ColumnState.MinimumWidth = 10;
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.ReadOnly = true;
            this.ColumnState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnState.ThreeState = true;
            this.ColumnState.TrueValue = "1";
            this.ColumnState.Width = 71;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 68;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescription.DataPropertyName = "Description";
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAuthor.DataPropertyName = "Author";
            this.ColumnAuthor.HeaderText = "Author";
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.ReadOnly = true;
            this.ColumnAuthor.Width = 75;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(864, 125);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(211, 23);
            this.textSearch.TabIndex = 142;
            this.textSearch.Text = "Search...";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnPluginsMenu
            // 
            this.btnPluginsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPluginsMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPluginsMenu.FlatAppearance.BorderSize = 0;
            this.btnPluginsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPluginsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPluginsMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPluginsMenu.Location = new System.Drawing.Point(1037, 0);
            this.btnPluginsMenu.Name = "btnPluginsMenu";
            this.btnPluginsMenu.Size = new System.Drawing.Size(48, 51);
            this.btnPluginsMenu.TabIndex = 157;
            this.btnPluginsMenu.UseVisualStyleBackColor = false;
            this.btnPluginsMenu.Click += new System.EventHandler(this.btnPluginsMenu_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.lnkPluginsDir);
            this.pnlTop.Controls.Add(this.lnkSubHeader);
            this.pnlTop.Controls.Add(this.lblSubHeader);
            this.pnlTop.Controls.Add(this.btnPluginsMenu);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1088, 119);
            this.pnlTop.TabIndex = 164;
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.AutoSize = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Location = new System.Drawing.Point(27, 94);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(236, 15);
            this.lnkSubHeader.TabIndex = 159;
            this.lnkSubHeader.TabStop = true;
            this.lnkSubHeader.Text = "More information about the Plugins engine";
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubHeader.Location = new System.Drawing.Point(27, 61);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(550, 17);
            this.lblSubHeader.TabIndex = 158;
            this.lblSubHeader.Text = "Create your own tweaks based on simple .INI-files and extend the capabilities of " +
    "ThisIsWin11.";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(24, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(93, 32);
            this.lblHeader.TabIndex = 135;
            this.lblHeader.Text = "Plugins";
            // 
            // lnkPluginsAttribution
            // 
            this.lnkPluginsAttribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkPluginsAttribution.AutoSize = true;
            this.lnkPluginsAttribution.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPluginsAttribution.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPluginsAttribution.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkPluginsAttribution.Location = new System.Drawing.Point(26, 702);
            this.lnkPluginsAttribution.Name = "lnkPluginsAttribution";
            this.lnkPluginsAttribution.Size = new System.Drawing.Size(153, 15);
            this.lnkPluginsAttribution.TabIndex = 165;
            this.lnkPluginsAttribution.TabStop = true;
            this.lnkPluginsAttribution.Text = "Karlkoorna\'s Tweaky engine";
            this.lnkPluginsAttribution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPluginsAttribution_LinkClicked);
            // 
            // lblPluginsAttribution
            // 
            this.lblPluginsAttribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPluginsAttribution.AutoEllipsis = true;
            this.lblPluginsAttribution.BackColor = System.Drawing.Color.Transparent;
            this.lblPluginsAttribution.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginsAttribution.ForeColor = System.Drawing.Color.Black;
            this.lblPluginsAttribution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPluginsAttribution.Location = new System.Drawing.Point(26, 671);
            this.lblPluginsAttribution.Name = "lblPluginsAttribution";
            this.lblPluginsAttribution.Size = new System.Drawing.Size(91, 21);
            this.lblPluginsAttribution.TabIndex = 166;
            this.lblPluginsAttribution.Text = "Attribution";
            // 
            // menuPlugins
            // 
            this.menuPlugins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuPlugins.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPluginsPopOut,
            this.toolStripSeparator1,
            this.menuPluginsInfo});
            this.menuPlugins.Name = "menuMain";
            this.menuPlugins.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPlugins.Size = new System.Drawing.Size(195, 70);
            // 
            // menuPluginsPopOut
            // 
            this.menuPluginsPopOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPluginsPopOut.Name = "menuPluginsPopOut";
            this.menuPluginsPopOut.Size = new System.Drawing.Size(194, 30);
            this.menuPluginsPopOut.Text = "Pop-out-App";
            this.menuPluginsPopOut.Click += new System.EventHandler(this.menuPluginsPopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // menuPluginsInfo
            // 
            this.menuPluginsInfo.Name = "menuPluginsInfo";
            this.menuPluginsInfo.Size = new System.Drawing.Size(194, 30);
            this.menuPluginsInfo.Text = "Info";
            this.menuPluginsInfo.Click += new System.EventHandler(this.menuPluginsInfo_Click);
            // 
            // lnkPluginsDir
            // 
            this.lnkPluginsDir.AutoSize = true;
            this.lnkPluginsDir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPluginsDir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPluginsDir.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkPluginsDir.Location = new System.Drawing.Point(283, 94);
            this.lnkPluginsDir.Name = "lnkPluginsDir";
            this.lnkPluginsDir.Size = new System.Drawing.Size(112, 15);
            this.lnkPluginsDir.TabIndex = 160;
            this.lnkPluginsDir.TabStop = true;
            this.lnkPluginsDir.Text = "Open Plugins folder";
            this.lnkPluginsDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPluginsDir_LinkClicked);
            // 
            // PluginsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.lblPluginsAttribution);
            this.Controls.Add(this.lnkPluginsAttribution);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.DataGridViewPlugins);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(24, 19);
            this.Name = "PluginsWindow";
            this.ShowIcon = false;
            this.Text = "ThisIsWin11";
            this.Shown += new System.EventHandler(this.PluginsWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlugins)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.menuPlugins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridViewPlugins;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnPluginsMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.LinkLabel lnkPluginsAttribution;
        private System.Windows.Forms.Label lblPluginsAttribution;
        private System.Windows.Forms.ContextMenuStrip menuPlugins;
        private System.Windows.Forms.ToolStripMenuItem menuPluginsPopOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuPluginsInfo;
        private System.Windows.Forms.LinkLabel lnkPluginsDir;
    }
}