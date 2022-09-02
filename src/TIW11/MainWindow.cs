using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ThisIsWin11
{
    public partial class MainWindow : Form
    {
        private Dictionary<string, Form> panelForms = new Dictionary<string, Form>();
        private Dictionary<string, Button> panelButtons = new Dictionary<string, Button>();

        private bool isGlobalNavOpen = false;

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        public MainWindow()
        {
            InitializeComponent();

            int lightmode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1");
            if (lightmode != 1)
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }

            this.MinimumSize = new Size(810, 755);

            RegisterView(new HomeWindow(this), btnHome);                    // Get Started
            RegisterView(new CustomizeWindow(), btnCustomize);              // OpenTweaks
            RegisterView(new AppsWindow(), btnApps);                        // PumpedApp
            RegisterView(new PackagesWindow(), btnPackages);                // Packages page
            RegisterView(new AutomateWindow(), btnAutomate);                // PowerUI
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
                // btnExtensions.Text += space + space + "Extensions";
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
            Color colorBackground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundColorNav : ThemeHelper.LightBackgroundColorNav;
            Color colorForeground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColorNav : ThemeHelper.LightForgroundColorNav;
            Color colorMouseOver = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkMouseOverBackColorNav : ThemeHelper.LightMouseOverBackColorNav;

            Form form = panelForms[viewButton];
            this.pnlContainer.Controls.Clear();
            this.pnlContainer.Controls.Add(form);
            form.Show();

            foreach (Button btn in panelButtons.Values.Where(b => b.Tag.ToString() != viewButton))
            {
                btn.BackColor = colorBackground;
                btn.ForeColor = colorForeground;

                if (!ThemeHelper.AppsUseLightTheme())
                {
                    btn.FlatAppearance.MouseOverBackColor = colorMouseOver;
                    btn.FlatAppearance.MouseDownBackColor = colorBackground;
                }
                else
                {
                    btn.FlatAppearance.MouseOverBackColor =
                    btn.FlatAppearance.MouseDownBackColor = colorMouseOver;
                }
            }

            Button button = panelButtons[viewButton];
            button.BackColor = colorBackground;
            button.ForeColor = Color.MediumVioletRed;

            btnGlobalNav.BackColor = colorBackground;
            btnGlobalNav.ForeColor = colorForeground;
            pnlNav.BackColor = colorBackground;
        }

        private void btnMenu_Click(object sender, EventArgs e)

          => UISelection();
    }
}
