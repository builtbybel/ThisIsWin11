using System;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class AboutWindow : Form
    {
        private MainWindow mainForm = null;

        public AboutWindow(Form frm)
        {
            mainForm = frm as MainWindow;
            InitializeComponent();

            btnBack.Text = "\uE72B";          // Back
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            richInfo.Text = this.Text + "\nVersion: " + Program.GetCurrentVersionTostring() + "\n" +
                            "Builtbybel\n\n" +
                           "GitHub: https://github.com/builtbybel/ThisIsWin11\n" +
                           "Twitter: https://twitter.com/builtbybel\n\n" +
                           "MIT License";
        }

        private void richInfo_LinkClicked(object sender, LinkClickedEventArgs e) => ThisIsWin11.Helpers.Utils.LaunchUri(e.LinkText);

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowLeftPanel = true;
            this.Hide();
        }
    }
}