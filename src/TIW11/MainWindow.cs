using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ThisIsWin11.Properties;

namespace ThisIsWin11
{
    public partial class MainWindow : Form
    {
        private Dictionary<string, Form> panelForms = new Dictionary<string, Form>();
        private Dictionary<string, Button> panelButtons = new Dictionary<string, Button>();

        private bool isGlobalNavOpen = false;

        // Read settings
        private bool darkTheme = Settings.Default.darkTheme;

        public MainWindow()
        {
            InitializeComponent();

            this.MinimumSize = new Size(810, 755);

            RegisterView(new HomeWindow(this), btnHome);                    // Home page
            RegisterView(new CustomizeWindow(), btnCustomize);              // Customize page
            RegisterView(new AppsWindow(), btnApps);                        // Apps page
            RegisterView(new PackagesWindow(), btnPackages);                // Packages page
            RegisterView(new AutomateWindow(), btnAutomate);                // Automate page
            RegisterView(new ExtensionsWindow(), btnExtensions);            // Extensions page
            RegisterView(new SettingsWindow(this), btnSettings);            // Settings page

            UISelection();
        }

        // Load Home page
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            string key = panelForms.Keys.FirstOrDefault();
            if (key != null)
                ActivateView(panelForms.Keys.FirstOrDefault());
        }

        // Some UI nicety
        // Segoe Fluent Icons font along with its Unicode values, Ref. https://docs.microsoft.com/windows/apps/design/style/segoe-fluent-icons-font
        private void UISelection()
        {
            int newPnlContainerLocation = 90;

            var space = "\u0020";

            btnGlobalNav.Text = "\uE700";
            btnHome.Text = "\uE10F";
            btnCustomize.Text = "\uE771";
            btnApps.Text = "\uE71D";
            btnPackages.Text = "\uE7B8";
            btnAutomate.Text = "\uE943";
            btnExtensions.Text = "\uE10C";
            btnSettings.Text = "\uE115";

            if (!isGlobalNavOpen)
            {
                pnlNav.AutoSize = false;
                pnlContainer.SendToBack();
                pnlContainer.Location = new Point(60, 0);
                tt.SetToolTip(btnGlobalNav, "Open Navigation");

                isGlobalNavOpen = true;
            }
            else
            {
                btnHome.Text += space + space + "Home";
                btnCustomize.Text += space + space + "Customize";
                btnApps.Text += space + space + "Apps";
                btnPackages.Text += space + space + "Packages";
                btnAutomate.Text += space + space + "Automate";
                btnExtensions.Text += space + space + "Extensions";
                btnSettings.Text += space + space + "Settings";

                pnlNav.AutoSize = true;
                pnlContainer.BringToFront();
                pnlContainer.Location = new Point(newPnlContainerLocation, 0);
                tt.SetToolTip(btnGlobalNav, "Close Navigation");

                isGlobalNavOpen = false;
            }
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
            Color colorDarkBackground = darkTheme ? Settings.Default.colorDarkBackground : Settings.Default.colorLightBackground;
            Color colorDarkForeground = darkTheme ? Settings.Default.colorDarkForeground : Settings.Default.colorLightForeground;

            Form form = panelForms[viewButton];
            this.pnlContainer.Controls.Clear();
            this.pnlContainer.Controls.Add(form);
            form.Show();

            foreach (Button btn in panelButtons.Values.Where(b => b.Tag.ToString() != viewButton))
            {
                btn.BackColor = colorDarkBackground;
                btn.ForeColor = colorDarkForeground;

                if (darkTheme)
                {
                    btn.FlatAppearance.MouseOverBackColor = Color.HotPink;
                    btn.FlatAppearance.MouseDownBackColor = colorDarkBackground;
                }
                else
                {
                    btn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
                    btn.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
                }
            }

            Button button = panelButtons[viewButton];
            button.BackColor = Color.HotPink;
            button.ForeColor = form.ForeColor;

            btnGlobalNav.BackColor = colorDarkBackground;
            btnGlobalNav.ForeColor = colorDarkForeground;
            pnlNav.BackColor = colorDarkBackground;
        }

        private void btnMenu_Click(object sender, EventArgs e)

          => UISelection();
    }
}