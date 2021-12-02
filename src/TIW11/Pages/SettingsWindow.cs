using System;
using System.Diagnostics;
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

           => updateInfo.CheckForUpdates(this, true);

        private void UISelection()
        {
            var buildDateTime = Properties.Resources.BuildDate;
            lblVersionInstalled.Text = Program.GetCurrentVersionTostring();

            rtbAbout.Text = mainForm.Text + " (Spartan)" +
                           "\nBuild on " + buildDateTime + "Builtbybel" +
                           "\n\nGitHub (1.2k Stars): " + Helpers.Strings.Uri.GitRepo +
                           "\nTwitter: " + Helpers.Strings.Uri.Twitter +
                           "\nDonate: " + Helpers.Strings.Uri.Support +
                           "\nGive feedback: " + Helpers.Strings.Uri.Feedback +
                           "\n\nMIT License"+
                           "\n\nThis is not a product made by Microsoft and it's in no way related to them.";

            try
            {
                string changelog = new WebClient().DownloadString(Helpers.Strings.Uri.GitChanges);
                rtbAbout.Text += "\n\n\nLatest changes:" + changelog;
            }
            catch { };
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e) => updateInfo.CheckForUpdates(this, false);

        private void rtbAbout_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void lblVersionInstalled_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Helpers.Strings.Uri.GitLatest);
    }
}