using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class PluginsWindow : Form
    {
        private readonly PluginsBindingList<Plugin> tweaks = new PluginsBindingList<Plugin>();

        private static readonly string componentsVersion = "10";

        private void menuPluginsInfo_Click(object sender, EventArgs e) => MessageBox.Show("Plugins for TIW11\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public PluginsWindow()
        {
            InitializeComponent();
        }

        private void PluginsWindow_Shown(object sender, EventArgs e)
        {
            DataGridViewPlugins.DataSource = tweaks;

            // Populate list from data folder.
            foreach (var path in Directory.EnumerateFiles(@"data\plugins", "*.ini", SearchOption.AllDirectories)) if (path.Split('\\').Length > 2)
                {
                    var tweak = new Plugin(path);
                    tweaks.Add(tweak);
                }

            UISelection();
        }

        //some UI nicety
        private void UISelection()
        {
            btnPluginsMenu.Text = "\uE712";
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            var query = textSearch.Text.Trim().ToLower();
            DataGridViewPlugins.DataSource = query == "" ? tweaks : new BindingList<Plugin>(tweaks.Where((tweak) => tweak.Author.ToLower().Contains(query) || tweak.Name.ToLower().Contains(query) || tweak.Description.ToLower().Contains(query)).ToList());
        }

        private void DataGridViewPlugins_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewPlugins.Rows) if (((Plugin)row.DataBoundItem).Status == Plugin.PlugStatus.Enabled)
                {
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
        }

        private void DataGridViewPlugins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) tweaks[e.RowIndex].Toggle();
            DataGridViewPlugins.Refresh();
        }

        private void DataGridViewPlugins_SelectionChanged(object sender, EventArgs e) => DataGridViewPlugins.ClearSelection();

        private void textSearch_Click(object sender, EventArgs e) => textSearch.Text = "";

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/karlkoorna/tweaky/blob/master/README.md");

        private void lnkPluginsAttribution_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/karlkoorna/tweaky");

        private void lnkPluginsDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", @"data\plugins");

        private void btnPluginsMenu_Click(object sender, EventArgs e) => this.menuPlugins.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuPluginsPopOut_Click(object sender, EventArgs e)
        {
            PluginsWindow package = new PluginsWindow(); package.Show();
        }
    }
}