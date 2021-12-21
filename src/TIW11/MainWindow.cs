using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class MainWindow : Form
    {
        private Dictionary<string, Form> panelForms = new Dictionary<string, Form>();
        private Dictionary<string, Button> panelButtons = new Dictionary<string, Button>();

        public MainWindow()
        {
            InitializeComponent();

            RegisterView(new HomeWindow(this), btnHome);                    // Home page
            RegisterView(new CustomizeWindow(), btnCustomize);              // Customize page
            RegisterView(new AppsWindow(), btnApps);                        // Apps page
            RegisterView(new PackagesWindow(this), btnPackages);            // Packages page
            RegisterView(new AutomateWindow(), btnAutomate);                // Automate page
            RegisterView(new ExtensionsWindow(), btnExtensions);            // Extensions page
            RegisterView(new SettingsWindow(this), btnSettings);            // Settings page
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            // Load Home page
            string key = panelForms.Keys.FirstOrDefault();
            if (key != null)
                ActivateView(key);

            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            this.MinimumSize = new Size(810, 755);

            // Nav icons
            btnHome.Text = "\uE80F";
            btnSettings.Text = "\uE713";

            btnHome.Visible =
            btnCustomize.Visible =
            btnApps.Visible =
            btnPackages.Visible =
            btnAutomate.Visible =
            btnExtensions.Visible =
            btnSettings.Visible
            = true;
        }

        public void RegisterView(Form form, Button button)
        {
            form.TopLevel = false;
            form.Parent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            panelForms.Add(form.Name, form);
            button.Tag = form.Name;
            button.Click += SwitchView;
            panelButtons.Add(form.Name, button);
        }

        private void SwitchView(object sender, EventArgs e)
        {
            string viewButton = ((Control)sender).Tag.ToString();

            ActivateView(viewButton);
        }

        public void ActivateView(string viewButton)
        {
            Form form = panelForms[viewButton];
            this.pnlContainer.Controls.Clear();
            this.pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void btnCustomize_MouseDown(object sender, MouseEventArgs e)
        {
            btnCustomize.ForeColor =
                Color.MediumVioletRed; btnHome.ForeColor = btnApps.ForeColor = btnPackages.ForeColor = btnAutomate.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnApps_MouseDown(object sender, MouseEventArgs e)
        {
            btnApps.ForeColor =
                Color.MediumVioletRed; btnCustomize.ForeColor = btnHome.ForeColor = btnPackages.ForeColor = btnAutomate.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnPackages_MouseDown(object sender, MouseEventArgs e)
        {
            btnPackages.ForeColor =
                Color.MediumVioletRed; btnApps.ForeColor = btnCustomize.ForeColor = btnHome.ForeColor = btnAutomate.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnAutomate_MouseDown(object sender, MouseEventArgs e)
        {
            btnAutomate.ForeColor =
                Color.MediumVioletRed; btnPackages.ForeColor = btnApps.ForeColor = btnCustomize.ForeColor = btnHome.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnExtensions_MouseDown(object sender, MouseEventArgs e)
        {
            btnExtensions.ForeColor =
                Color.Black; btnAutomate.ForeColor = btnPackages.ForeColor = btnApps.ForeColor = btnCustomize.ForeColor = btnHome.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnSettings_MouseDown(object sender, MouseEventArgs e)
        {
            btnSettings.ForeColor =
                Color.MediumVioletRed; btnExtensions.ForeColor = btnAutomate.ForeColor = btnPackages.ForeColor = btnApps.ForeColor = btnCustomize.ForeColor = btnHome.ForeColor =
                Color.DimGray;
        }
    }
}