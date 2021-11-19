using System;
using System.Net;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class SettingsWindow : Form
    {
        private Helpers.Utils updateInfo = new Helpers.Utils();

        private MainWindow mainForm = null;

        public SettingsWindow(Form frm)
        {
            mainForm = frm as MainWindow;

            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)

            => UISelection();

        private void SettingsWindow_Shown(object sender, EventArgs e)

           => updateInfo.CheckForUpdates(this, true, true);

        private void UISelection()
        {
            var buildDateTime = Properties.Resources.BuildDate;
            lblInstalledVersion.Text = "Installed Version: " + Program.GetCurrentVersionTostring();

            rtbAbout.Text = mainForm.Text + " (Spartan)" +
                           "\nBuild on " + buildDateTime + "Builtbybel" +
                           "\n\nGitHub: " + Helpers.Strings.Uri.GitRepo +
                           "\nTwitter: " + Helpers.Strings.Uri.Twitter +
                           "\nDonate: " + Helpers.Strings.Uri.Support +
                           "\nGive feedback: " + Helpers.Strings.Uri.Feedback +
                           "\n\nMIT License";

            try
            {
                string changelog = new WebClient().DownloadString(Helpers.Strings.Uri.GitVersionHint);
                rtbAbout.Text += "\n\n\nLatest changes:" + changelog;
            }
            catch { };
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e) => updateInfo.CheckForUpdates(this, true);

        private void rtbAbout_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}