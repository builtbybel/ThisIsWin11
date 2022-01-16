using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class ExtensionsWindow : Form
    {
        private readonly PluginsBindingList<Plugin> tweaks = new PluginsBindingList<Plugin>();

        private static readonly string componentsVersion = "17 (experimental)";

        private void menuPluginsInfo_Click(object sender, EventArgs e) => MessageBox.Show("Extensions for TIW11\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public ExtensionsWindow()
        {
            InitializeComponent();
            RegisterTheme();
        }

        private void ExtensionsWindow_Shown(object sender, EventArgs e)
        {
            UISelection();
            IntializePlugs();
        }

        // Some UI nicety
        private void UISelection()
        {
            btnPluginsMenu.Text = "\uE712";
        }

        private void RegisterTheme()
        {
            Color colorBackground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundColor : ThemeHelper.LightBackgroundColor;
            Color colorForeground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForgroundColor;

            this.BackColor =
            pnlLeft.BackColor =
            pnlRight.BackColor =
            btnPluginsMenu.BackColor =
            lblHeader.BackColor =
            lblPlugsAttribution.BackColor =
            textPlugsSearch.BackColor =
            DataGridViewPlugs.ColumnHeadersDefaultCellStyle.BackColor =
            DataGridViewPlugs.BackgroundColor =
            DataGridViewPlugs.RowsDefaultCellStyle.BackColor =
            DataGridViewPlugs.GridColor =
             colorBackground;

            btnPluginsMenu.ForeColor =
            lblHeader.ForeColor =
            lblPlugsAttribution.ForeColor =
            textPlugsSearch.ForeColor =
            DataGridViewPlugs.ForeColor =
                colorForeground;
        }

        private void IntializePlugs()
        {
            DataGridViewPlugs.DataSource = tweaks;

            try
            {
                // Populate list from data\plugins folder
                foreach (var path in Directory.EnumerateFiles(@"data\plugins", "*.ini", SearchOption.AllDirectories)) if (path.Split('\\').Length > 2)
                    {
                        var tweak = new Plugin(path);
                        tweaks.Add(tweak);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textPlugsSearch_TextChanged(object sender, EventArgs e)
        {
            var query = textPlugsSearch.Text.Trim().ToLower();
            DataGridViewPlugs.DataSource = query == "" ? tweaks : new BindingList<Plugin>(tweaks.Where((tweak) => tweak.Author.ToLower().Contains(query) || tweak.Name.ToLower().Contains(query) || tweak.Description.ToLower().Contains(query)).ToList());
        }

        private void DataGridViewPlugins_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewPlugs.Rows) if (((Plugin)row.DataBoundItem).Status == Plugin.PlugStatus.Enabled)
                {
                    if (!ThemeHelper.AppsUseLightTheme())
                        row.DefaultCellStyle.BackColor = Color.MediumVioletRed;
                    else row.DefaultCellStyle.BackColor = Color.LavenderBlush;
                }
                else  
                { 
                    if (!ThemeHelper.AppsUseLightTheme())
                        row.DefaultCellStyle.BackColor = Color.FromArgb(32, 33, 36);
                    else row.DefaultCellStyle.BackColor = ThemeHelper.LightBackgroundColor;
                }
        }

        private void DataGridViewPlugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) tweaks[e.RowIndex].Toggle();
            DataGridViewPlugs.Refresh();
        }

        private void DataGridViewPlugs_SelectionChanged(object sender, EventArgs e) => DataGridViewPlugs.ClearSelection();

        private void textSearch_Click(object sender, EventArgs e) => textPlugsSearch.Text = "";

        private void lnkPlugsAttribution_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/karlkoorna/tweaky/blob/master/README.md");

        private void lnkPlugsDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", @"data\plugins");

        private void lnkPlugsGet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Helpers.Strings.Uri.URL_POWERUI_PLUGS);

        private void btnPlugsMenu_Click(object sender, EventArgs e) => this.menuPlugins.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuPlugsPopOut_Click(object sender, EventArgs e)
        {
            ExtensionsWindow package = new ExtensionsWindow(); package.Show();
        }

        private void menuPlugsRefresh_Click(object sender, EventArgs e)
        {
            DataGridViewPlugs.Rows.Clear();
            DataGridViewPlugs.Refresh();

            IntializePlugs();
        }
    }
}