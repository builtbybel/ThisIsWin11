
namespace ThisIsWin11
{
    partial class ExtensionsWindow
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
            this.DataGridViewPlugs = new System.Windows.Forms.DataGridView();
            this.ColumnState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPlugsSearch = new System.Windows.Forms.TextBox();
            this.btnPluginsMenu = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lnkPlugsDir = new System.Windows.Forms.LinkLabel();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkPlugsAttribution = new System.Windows.Forms.LinkLabel();
            this.lblPlugsAttribution = new System.Windows.Forms.Label();
            this.menuPlugins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPlugsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlugsPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPlugsInfo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlugs)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.menuPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewPlugs
            // 
            this.DataGridViewPlugs.AllowUserToAddRows = false;
            this.DataGridViewPlugs.AllowUserToDeleteRows = false;
            this.DataGridViewPlugs.AllowUserToOrderColumns = true;
            this.DataGridViewPlugs.AllowUserToResizeColumns = false;
            this.DataGridViewPlugs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewPlugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewPlugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewPlugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewPlugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewPlugs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewPlugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewPlugs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewPlugs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridViewPlugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            this.DataGridViewPlugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewPlugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPlugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DataGridViewPlugs.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewPlugs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewPlugs.EnableHeadersVisualStyles = false;
            this.DataGridViewPlugs.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewPlugs.Location = new System.Drawing.Point(24, 166);
            this.DataGridViewPlugs.MultiSelect = false;
            this.DataGridViewPlugs.Name = "DataGridViewPlugs";
            this.DataGridViewPlugs.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPlugs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPlugs.RowHeadersVisible = false;
            this.DataGridViewPlugs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewPlugs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPlugs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewPlugs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewPlugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewPlugs.ShowEditingIcon = false;
            this.DataGridViewPlugs.Size = new System.Drawing.Size(1051, 502);
            this.DataGridViewPlugs.TabIndex = 141;
            this.DataGridViewPlugs.TabStop = false;
            this.DataGridViewPlugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPlugs_CellContentClick);
            this.DataGridViewPlugs.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridViewPlugins_RowPrePaint);
            this.DataGridViewPlugs.SelectionChanged += new System.EventHandler(this.DataGridViewPlugs_SelectionChanged);
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
            // textPlugsSearch
            // 
            this.textPlugsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPlugsSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlugsSearch.Location = new System.Drawing.Point(864, 125);
            this.textPlugsSearch.Name = "textPlugsSearch";
            this.textPlugsSearch.Size = new System.Drawing.Size(211, 23);
            this.textPlugsSearch.TabIndex = 142;
            this.textPlugsSearch.Text = "Search...";
            this.textPlugsSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textPlugsSearch.TextChanged += new System.EventHandler(this.textPlugsSearch_TextChanged);
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
            this.btnPluginsMenu.Click += new System.EventHandler(this.btnPlugsMenu_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.lnkPlugsDir);
            this.pnlTop.Controls.Add(this.lnkSubHeader);
            this.pnlTop.Controls.Add(this.lblSubHeader);
            this.pnlTop.Controls.Add(this.btnPluginsMenu);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1088, 119);
            this.pnlTop.TabIndex = 164;
            // 
            // lnkPlugsDir
            // 
            this.lnkPlugsDir.AutoSize = true;
            this.lnkPlugsDir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPlugsDir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPlugsDir.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkPlugsDir.Location = new System.Drawing.Point(319, 94);
            this.lnkPlugsDir.Name = "lnkPlugsDir";
            this.lnkPlugsDir.Size = new System.Drawing.Size(128, 17);
            this.lnkPlugsDir.TabIndex = 160;
            this.lnkPlugsDir.TabStop = true;
            this.lnkPlugsDir.Text = "Open Plugins folder";
            this.lnkPlugsDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPlugsDir_LinkClicked);
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.AutoSize = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Location = new System.Drawing.Point(27, 94);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(272, 17);
            this.lnkSubHeader.TabIndex = 159;
            this.lnkSubHeader.TabStop = true;
            this.lnkSubHeader.Text = "More information about the Plugins engine";
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubHeader.Location = new System.Drawing.Point(27, 61);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(439, 20);
            this.lblSubHeader.TabIndex = 158;
            this.lblSubHeader.Text = "Create your own tweaks and extend the capabilities of ThisIsWin11.";
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
            this.lblHeader.Size = new System.Drawing.Size(129, 32);
            this.lblHeader.TabIndex = 135;
            this.lblHeader.Text = "Extensions";
            // 
            // lnkPlugsAttribution
            // 
            this.lnkPlugsAttribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkPlugsAttribution.AutoSize = true;
            this.lnkPlugsAttribution.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPlugsAttribution.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPlugsAttribution.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkPlugsAttribution.Location = new System.Drawing.Point(26, 702);
            this.lnkPlugsAttribution.Name = "lnkPlugsAttribution";
            this.lnkPlugsAttribution.Size = new System.Drawing.Size(175, 17);
            this.lnkPlugsAttribution.TabIndex = 165;
            this.lnkPlugsAttribution.TabStop = true;
            this.lnkPlugsAttribution.Text = "Karlkoorna\'s Tweaky engine";
            this.lnkPlugsAttribution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPlugsAttribution_LinkClicked);
            // 
            // lblPlugsAttribution
            // 
            this.lblPlugsAttribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlugsAttribution.AutoEllipsis = true;
            this.lblPlugsAttribution.BackColor = System.Drawing.Color.Transparent;
            this.lblPlugsAttribution.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlugsAttribution.ForeColor = System.Drawing.Color.Black;
            this.lblPlugsAttribution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlugsAttribution.Location = new System.Drawing.Point(26, 671);
            this.lblPlugsAttribution.Name = "lblPlugsAttribution";
            this.lblPlugsAttribution.Size = new System.Drawing.Size(91, 21);
            this.lblPlugsAttribution.TabIndex = 166;
            this.lblPlugsAttribution.Text = "Attribution";
            // 
            // menuPlugins
            // 
            this.menuPlugins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuPlugins.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlugsRefresh,
            this.menuPlugsPopOut,
            this.toolStripSeparator1,
            this.menuPlugsInfo});
            this.menuPlugins.Name = "menuMain";
            this.menuPlugins.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPlugins.Size = new System.Drawing.Size(195, 100);
            // 
            // menuPlugsRefresh
            // 
            this.menuPlugsRefresh.Name = "menuPlugsRefresh";
            this.menuPlugsRefresh.Size = new System.Drawing.Size(194, 30);
            this.menuPlugsRefresh.Text = "Refresh";
            this.menuPlugsRefresh.Click += new System.EventHandler(this.menuPlugsRefresh_Click);
            // 
            // menuPlugsPopOut
            // 
            this.menuPlugsPopOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPlugsPopOut.Name = "menuPlugsPopOut";
            this.menuPlugsPopOut.Size = new System.Drawing.Size(194, 30);
            this.menuPlugsPopOut.Text = "Pop-out-App";
            this.menuPlugsPopOut.Click += new System.EventHandler(this.menuPlugsPopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // menuPlugsInfo
            // 
            this.menuPlugsInfo.Name = "menuPlugsInfo";
            this.menuPlugsInfo.Size = new System.Drawing.Size(194, 30);
            this.menuPlugsInfo.Text = "Info";
            this.menuPlugsInfo.Click += new System.EventHandler(this.menuPluginsInfo_Click);
            // 
            // ExtensionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.lblPlugsAttribution);
            this.Controls.Add(this.lnkPlugsAttribution);
            this.Controls.Add(this.textPlugsSearch);
            this.Controls.Add(this.DataGridViewPlugs);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(24, 19);
            this.Name = "ExtensionsWindow";
            this.ShowIcon = false;
            this.Text = "ThisIsWin11 Extensions";
            this.Shown += new System.EventHandler(this.ExtensionsWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlugs)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.menuPlugins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridViewPlugs;
        private System.Windows.Forms.TextBox textPlugsSearch;
        private System.Windows.Forms.Button btnPluginsMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.LinkLabel lnkPlugsAttribution;
        private System.Windows.Forms.Label lblPlugsAttribution;
        private System.Windows.Forms.ContextMenuStrip menuPlugins;
        private System.Windows.Forms.ToolStripMenuItem menuPlugsPopOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuPlugsInfo;
        private System.Windows.Forms.LinkLabel lnkPlugsDir;
        private System.Windows.Forms.ToolStripMenuItem menuPlugsRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
    }
}