
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
            this.btnPluginsMenu = new ThisIsWin11.Controls.RoundedButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lnkPlugsGet = new System.Windows.Forms.LinkLabel();
            this.lnkPlugsDir = new System.Windows.Forms.LinkLabel();
            this.lblPlugsAttribution = new System.Windows.Forms.Label();
            this.lnkPlugsAttribution = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.menuPlugins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPlugsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlugsPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPlugsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.textPlugsSearch = new System.Windows.Forms.TextBox();
            this.DataGridViewPlugs = new System.Windows.Forms.DataGridView();
            this.ColumnState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.menuPlugins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlugs)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPluginsMenu
            // 
            this.btnPluginsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPluginsMenu.BackColor = System.Drawing.Color.White;
            this.btnPluginsMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPluginsMenu.FlatAppearance.BorderSize = 0;
            this.btnPluginsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPluginsMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPluginsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPluginsMenu.Location = new System.Drawing.Point(1161, 0);
            this.btnPluginsMenu.Name = "btnPluginsMenu";
            this.btnPluginsMenu.Size = new System.Drawing.Size(48, 51);
            this.btnPluginsMenu.TabIndex = 157;
            this.btnPluginsMenu.UseVisualStyleBackColor = false;
            this.btnPluginsMenu.Click += new System.EventHandler(this.btnPlugsMenu_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lnkPlugsGet);
            this.pnlLeft.Controls.Add(this.lnkPlugsDir);
            this.pnlLeft.Controls.Add(this.lblPlugsAttribution);
            this.pnlLeft.Controls.Add(this.lnkPlugsAttribution);
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(507, 862);
            this.pnlLeft.TabIndex = 164;
            // 
            // lnkPlugsGet
            // 
            this.lnkPlugsGet.AutoSize = true;
            this.lnkPlugsGet.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPlugsGet.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPlugsGet.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkPlugsGet.Location = new System.Drawing.Point(70, 213);
            this.lnkPlugsGet.Name = "lnkPlugsGet";
            this.lnkPlugsGet.Size = new System.Drawing.Size(108, 17);
            this.lnkPlugsGet.TabIndex = 167;
            this.lnkPlugsGet.TabStop = true;
            this.lnkPlugsGet.Text = "Get new Plugins";
            this.lnkPlugsGet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPlugsGet_LinkClicked);
            // 
            // lnkPlugsDir
            // 
            this.lnkPlugsDir.AutoSize = true;
            this.lnkPlugsDir.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPlugsDir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPlugsDir.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkPlugsDir.Location = new System.Drawing.Point(70, 181);
            this.lnkPlugsDir.Name = "lnkPlugsDir";
            this.lnkPlugsDir.Size = new System.Drawing.Size(132, 17);
            this.lnkPlugsDir.TabIndex = 160;
            this.lnkPlugsDir.TabStop = true;
            this.lnkPlugsDir.Text = "Open Plugins folder";
            this.lnkPlugsDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPlugsDir_LinkClicked);
            // 
            // lblPlugsAttribution
            // 
            this.lblPlugsAttribution.AutoEllipsis = true;
            this.lblPlugsAttribution.BackColor = System.Drawing.Color.Transparent;
            this.lblPlugsAttribution.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlugsAttribution.ForeColor = System.Drawing.Color.Black;
            this.lblPlugsAttribution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlugsAttribution.Location = new System.Drawing.Point(69, 264);
            this.lblPlugsAttribution.Name = "lblPlugsAttribution";
            this.lblPlugsAttribution.Size = new System.Drawing.Size(175, 21);
            this.lblPlugsAttribution.TabIndex = 166;
            this.lblPlugsAttribution.Text = "Attribution";
            // 
            // lnkPlugsAttribution
            // 
            this.lnkPlugsAttribution.AutoSize = true;
            this.lnkPlugsAttribution.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPlugsAttribution.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPlugsAttribution.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkPlugsAttribution.Location = new System.Drawing.Point(69, 295);
            this.lnkPlugsAttribution.Name = "lnkPlugsAttribution";
            this.lnkPlugsAttribution.Size = new System.Drawing.Size(178, 17);
            this.lnkPlugsAttribution.TabIndex = 165;
            this.lnkPlugsAttribution.TabStop = true;
            this.lnkPlugsAttribution.Text = "Karlkoorna\'s Tweaky engine";
            this.lnkPlugsAttribution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPlugsAttribution_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(60, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(412, 94);
            this.lblHeader.TabIndex = 135;
            this.lblHeader.Text = "Create your own tweaks \r\nwith Extensions\r\n";
            // 
            // menuPlugins
            // 
            this.menuPlugins.BackColor = System.Drawing.Color.White;
            this.menuPlugins.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuPlugsPopOut.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // textPlugsSearch
            // 
            this.textPlugsSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textPlugsSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPlugsSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlugsSearch.ForeColor = System.Drawing.Color.Gray;
            this.textPlugsSearch.Location = new System.Drawing.Point(14, 18);
            this.textPlugsSearch.Name = "textPlugsSearch";
            this.textPlugsSearch.Size = new System.Drawing.Size(211, 23);
            this.textPlugsSearch.TabIndex = 142;
            this.textPlugsSearch.Text = "Search...";
            this.textPlugsSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textPlugsSearch.TextChanged += new System.EventHandler(this.textPlugsSearch_TextChanged);
            // 
            // DataGridViewPlugs
            // 
            this.DataGridViewPlugs.AllowUserToAddRows = false;
            this.DataGridViewPlugs.AllowUserToDeleteRows = false;
            this.DataGridViewPlugs.AllowUserToOrderColumns = true;
            this.DataGridViewPlugs.AllowUserToResizeColumns = false;
            this.DataGridViewPlugs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewPlugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewPlugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewPlugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewPlugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewPlugs.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewPlugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewPlugs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewPlugs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridViewPlugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            this.DataGridViewPlugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewPlugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPlugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnState,
            this.ColumnName,
            this.ColumnDescription,
            this.ColumnAuthor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPlugs.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewPlugs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewPlugs.EnableHeadersVisualStyles = false;
            this.DataGridViewPlugs.GridColor = System.Drawing.Color.White;
            this.DataGridViewPlugs.Location = new System.Drawing.Point(527, 113);
            this.DataGridViewPlugs.MultiSelect = false;
            this.DataGridViewPlugs.Name = "DataGridViewPlugs";
            this.DataGridViewPlugs.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPlugs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPlugs.RowHeadersVisible = false;
            this.DataGridViewPlugs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewPlugs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPlugs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewPlugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewPlugs.ShowEditingIcon = false;
            this.DataGridViewPlugs.Size = new System.Drawing.Size(671, 737);
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
            this.ColumnState.Width = 69;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 67;
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
            this.ColumnAuthor.Width = 72;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.textPlugsSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(513, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(697, 862);
            this.pnlRight.TabIndex = 165;
            // 
            // ExtensionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.btnPluginsMenu);
            this.Controls.Add(this.DataGridViewPlugs);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(24, 19);
            this.Name = "ExtensionsWindow";
            this.ShowIcon = false;
            this.Text = "ThisIsWin11 Extensions";
            this.Shown += new System.EventHandler(this.ExtensionsWindow_Shown);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.menuPlugins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlugs)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnkPlugsAttribution;
        private System.Windows.Forms.Label lblPlugsAttribution;
        private System.Windows.Forms.ContextMenuStrip menuPlugins;
        private System.Windows.Forms.ToolStripMenuItem menuPlugsPopOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuPlugsInfo;
        private System.Windows.Forms.LinkLabel lnkPlugsDir;
        private System.Windows.Forms.ToolStripMenuItem menuPlugsRefresh;
        private System.Windows.Forms.TextBox textPlugsSearch;
        private System.Windows.Forms.DataGridView DataGridViewPlugs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.LinkLabel lnkPlugsGet;
        private System.Windows.Forms.Panel pnlRight;
        private Controls.RoundedButton btnPluginsMenu;
    }
}