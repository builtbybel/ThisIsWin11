using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class SettingsWindow : Form
    {
        private Helpers.Utils updateInfo = new Helpers.Utils();
        public bool buttonInstallUpdate = false;

        private MainWindow mainForm = null;

        public SettingsWindow(Form frm)
        {
            mainForm = frm as MainWindow;

            InitializeComponent();
            RegisterTheme();
        }

        private void RegisterTheme()
        {
            FlatStyle buttonStyle = !ThemeHelper.AppsUseLightTheme() ? FlatStyle.Flat : FlatStyle.Standard;
            Color colorBackground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundColor : ThemeHelper.LightBackgroundColor;
            Color colorBackgroundButtonContrast = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundContrast : ThemeHelper.LightBackgroundButtonContrast;

            Color colorForeground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForgroundColor;

            this.BackColor =
            btnSettingsMenu.BackColor =
            lblHeader.BackColor =
            lblSettingsUpdates.BackColor =
            lblAssembly.BackColor =
            lblSettingsApp.BackColor =
            lblSettingsAbout.BackColor =
            lblSettingsSubWith.BackColor =
            lblHeartFillEmoji.BackColor =
            lblSettingsSubDev.BackColor =
            lblSettingsAppMain.BackColor =
            lblSettingsMode.BackColor =
            rtbSettingsAbout.BackColor =
                colorBackground;

            this.ForeColor =
            btnSettingsMenu.ForeColor =
            lblHeader.ForeColor =
            lblSettingsUpdates.ForeColor =
            lblAssembly.LinkColor =
            lblSettingsApp.ForeColor =
            lblSettingsAppMain.ForeColor =
            rtbSettingsAbout.ForeColor =
             lblSettingsMode.ForeColor =
                colorForeground;

            btnAppMediaGitHubIssues.BackColor = colorBackgroundButtonContrast;

            btnAppMediaGitHubIssues.FlatStyle = buttonStyle;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)

            => UISelection();

        private void SettingsWindow_Shown(object sender, EventArgs e)

           => updateInfo.CheckForUpdates(this, true);

        private void UISelection()
        {
            var isDarkTheme = ThemeHelper.AppsUseLightTheme() ? lblTheme.Text = "Light" : lblTheme.Text = "Dark";
            var buildDateTime = Properties.Resources.buildDate;
            lblAssembly.Text = Program.GetCurrentVersionTostring();

            btnSettingsMenu.Text = "\uE712";
            lblHeartFillEmoji.Text = "\uEB52";
            lblSettingsAppMain.Text = "(Ganymede release)" +
                           "\nBuild on " + buildDateTime;
            rtbSettingsAbout.Text = "MIT License" +
                           "\n\nThis is not a app made by Microsoft and it's in no way related to them.";

            try
            {
                string changelog = new WebClient().DownloadString(Helpers.Strings.Uri.URL_GITCHANGELOG);
                rtbSettingsAbout.Text += "\n\n\nSee what's new:" + changelog;
            }
            catch { };
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            buttonInstallUpdate = true;
            updateInfo.CheckForUpdates(this, false);
        }

        private void rtbAbout_LinkClicked(object sender, LinkClickedEventArgs e)
            => Helpers.Utils.LaunchUri(e.LinkText);

        private void lblAssembly_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(Helpers.Strings.Uri.URL_GITCHANGELOG);

        private void lblAppMediaGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(Helpers.Strings.Uri.URL_GITREPO);

        private void lblAppMediaTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(Helpers.Strings.Uri.URL_TWITTER);

        private void lblAppMediaPayPal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(Helpers.Strings.Uri.URL_DONATE);

        private void btnAppMediaGitHubIssues_Click(object sender, EventArgs e)
            => Process.Start(Helpers.Strings.Uri.URL_FEEDBACK);

        private void btnSettingsMenu_Click(object sender, EventArgs e)
            => this.menuSettings.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuCLI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To run each module in a seperate instance/app use the following arguments:" +
                 "\n\t/getstarted" +
                 "\n\t/opentweaks" +
                 "\n\t/pumpedapp" +
                 "\n\t/packages" +
                 "\n\t/powerui", "Command-line switches");
        }

        private void menuFeedbackHub_Click(object sender, EventArgs e)
        {
            bool feedbackHub = Directory.Exists(Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Packages\\Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe"));

            if (!feedbackHub) MessageBox.Show("FeedbackHub is not installed on this system :(\nYou can get it on the Microsoft Store.", "We are sorry...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Process.Start(@"shell:appsfolder\Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe!App");
            }
        }

        private void lblTheme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

            => Process.Start("ms-settings:colors");
    }
}