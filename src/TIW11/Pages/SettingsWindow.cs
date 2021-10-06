using System;
using System.Net;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class SettingsWindow : Form
    {
        private Helpers.Utils utilInfo = new Helpers.Utils();

        private MainWindow mainForm = null;

        public SettingsWindow(Form frm)
        {
            mainForm = frm as MainWindow;

            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            UISelection();
        }

        private void UISelection()
        {
            lblInstalledVersion.Text = "Installed Version: " + Program.GetCurrentVersionTostring();

            rtbAbout.Text = mainForm.Text + "\nBuiltbybel" +
                       "\n\nGitHub: " + Helpers.Strings.Uri.GitRepo +
                       "\nTwitter: " + Helpers.Strings.Uri.Twitter +
                       "\nDonate: " + Helpers.Strings.Uri.Support +
                       "\nGive feedback: " + Helpers.Strings.Uri.Feedback +
                       "\n\nMIT License";

            try
            {
                string changelog = new WebClient().DownloadString(Helpers.Strings.Uri.GitVersionHint);
                rtbAbout.Text += "\n\n\nNew in this version:" + changelog;
            }
            catch { };
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e) => utilInfo.CheckForUpdates(true);

        private void rtbAbout_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}