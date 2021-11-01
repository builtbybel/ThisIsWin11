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
            RegisterView(new SystemWindow(), btnSystem);                    // System page
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

            // Load UI
            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            this.MinimumSize = new Size(810, 755);

            // Nav icons
            btnHome.Text = "\uEA8A" + "\n\nHome";
            btnSystem.Text = "\uE770" + "\n\nSystem";
            btnApps.Text = "\uE71D" + "\n\nApps";
            btnPackages.Text = "\uE7B8" + "\n\nPackages";
            btnAutomate.Text = "\uE943" + "\n\nAutomate";
            btnExtensions.Text = "\uE10C";
            btnSettings.Text = "\uE713" + "\n\nSettings";

            btnHome.Visible =
            btnSystem.Visible =
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

        private void btnHome_MouseDown(object sender, MouseEventArgs e)
        {
            btnHome.ForeColor =
                Color.MediumVioletRed; btnSystem.ForeColor = btnApps.ForeColor = btnPackages.ForeColor = btnAutomate.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnSystem_MouseDown(object sender, MouseEventArgs e)
        {
            btnSystem.ForeColor =
                Color.MediumVioletRed; btnHome.ForeColor = btnApps.ForeColor = btnPackages.ForeColor = btnAutomate.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnApps_MouseDown(object sender, MouseEventArgs e)
        {
            btnApps.ForeColor =
                Color.MediumVioletRed; btnSystem.ForeColor = btnHome.ForeColor = btnPackages.ForeColor = btnAutomate.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnPackages_MouseDown(object sender, MouseEventArgs e)
        {
            btnPackages.ForeColor =
                Color.MediumVioletRed; btnApps.ForeColor = btnSystem.ForeColor = btnHome.ForeColor = btnAutomate.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnAutomate_MouseDown(object sender, MouseEventArgs e)
        {
            btnAutomate.ForeColor =
                Color.MediumVioletRed; btnPackages.ForeColor = btnApps.ForeColor = btnSystem.ForeColor = btnHome.ForeColor = btnExtensions.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnExtensions_MouseDown(object sender, MouseEventArgs e)
        {
            btnExtensions.ForeColor =
                Color.Black; btnAutomate.ForeColor = btnPackages.ForeColor = btnApps.ForeColor = btnSystem.ForeColor = btnHome.ForeColor = btnSettings.ForeColor =
                Color.DimGray;
        }

        private void btnSettings_MouseDown(object sender, MouseEventArgs e)
        {
            btnSettings.ForeColor =
                Color.MediumVioletRed; btnExtensions.ForeColor = btnAutomate.ForeColor = btnPackages.ForeColor = btnApps.ForeColor = btnSystem.ForeColor = btnHome.ForeColor =
                Color.DimGray;
        }
    }
}