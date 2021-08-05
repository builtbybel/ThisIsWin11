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
            UISelection();

            RegisterView(new HomeWindow(this), btnHome);                    //home page
            RegisterView(new SystemWindow(), btnSystem);                    //system page
            RegisterView(new AppsWindow(), btnApps);                        //apps page
            RegisterView(new PackagesWindow(this), btnPackages);            //packages page
            RegisterView(new AutomateWindow(), btnAutomate);                //automate page
            RegisterView(new SettingsWindow(this), btnSettings);            //settings page
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string key = panelForms.Keys.FirstOrDefault();
            if (key != null)
                ActivateView(key);
        }

        //some UI nicety
        private void UISelection()
        {
            this.MinimumSize = new Size(810, 755);

            //nav icons
            btnHome.Text = "\xEA8A" + "\n\nHome";
            btnSystem.Text = "\xE770" + "\n\nSystem";
            btnApps.Text = "\xE71D" + "\n\nApps";
            btnPackages.Text = "\xE7B8" + "\n\nPackages";
            btnAutomate.Text = "\xE771" + "\n\nAutomate";
            btnSettings.Text = "\xE713" + "\n\nSettings";
            btnMore.Text = "\uE10C";
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

        private void menuMainComponents_Click(object sender, EventArgs e)
        {
            ComponentsWindow formComponents= new ComponentsWindow();
            formComponents.TopLevel = false;
            formComponents.AutoScroll = true;
            formComponents.FormBorderStyle = FormBorderStyle.None;
            formComponents.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            formComponents.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Clear();
            this.pnlContainer.Controls.Add(formComponents);
            formComponents.Show();
        }

        private void btnMore_Click(object sender, EventArgs e) => this.menuMain.Show(Cursor.Position.X, Cursor.Position.Y);
    }
}