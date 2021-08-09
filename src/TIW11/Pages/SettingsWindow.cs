using System;
using System.Net;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class SettingsWindow : Form
    {
        private Helpers.Utils utilInfo = new Helpers.Utils();
        private string changelog = new WebClient().DownloadString(Helpers.Strings.Uri.GitVersionHint);

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
            rtbAbout.Text = mainForm.Text + "\nVersion: " + Program.GetCurrentVersionTostring() +
                       "\nBuiltbybel" +
                       "\n\nGitHub: " + Helpers.Strings.Uri.GitRepo +
                       "\nTwitter: " + Helpers.Strings.Uri.Twitter +
                       "\nDonate: " + Helpers.Strings.Uri.Donate +
                       "\n\nMIT License" +
                       "\n\n\nNew in this version:" + changelog;
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e) => utilInfo.CheckForUpdates(true);

        private void rtbAbout_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}