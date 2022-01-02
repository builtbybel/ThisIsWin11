using System;
using System.Diagnostics;
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
        }

        private void SettingsWindow_Load(object sender, EventArgs e)

            => UISelection();

        private void SettingsWindow_Shown(object sender, EventArgs e)

           => updateInfo.CheckForUpdates(this, true);

        private void UISelection()
        {
            var buildDateTime = Properties.Resources.BuildDate;
            lblAssembly.Text = Program.GetCurrentVersionTostring();

            lblHeartFillEmoji.Text = "\uEB52";
            lblAppMain.Text = "(Spartan release)" +
                           "\nBuild on " + buildDateTime;
            rtbAbout.Text = "MIT License" +
                           "\n\nThis is not a product made by Microsoft and it's in no way related to them.";

            try
            {
                string changelog = new WebClient().DownloadString(Helpers.Strings.Uri.URL_GITCHANGELOG);
                rtbAbout.Text += "\n\n\nSee what's new:" + changelog;
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

        private void btnCLISwitch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To run each module in a seperate instance/app use the following arguments:" +
                             "\n\t/getstarted" +
                             "\n\t/opentweaks" +
                             "\n\t/pumpedapp" +
                             "\n\t/packages" +
                             "\n\t/powerui", "Command-line switches");
        }
    }
}