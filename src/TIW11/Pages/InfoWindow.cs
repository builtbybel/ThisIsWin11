using System;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class InfoWindow : Form
    {
        private MainWindow mainForm = null;

        public InfoWindow(Form frm)
        {
            mainForm = frm as MainWindow;
            InitializeComponent();
        }

        private void InfoWindow_Load(object sender, EventArgs e)
        {
            richInfo.Text = "Version: " + Program.GetCurrentVersionTostring() + "\n\n" +
                           "It's all open source https://github.com/builtbybel/ThisIsWin11\n\n" +
                           "MIT License\n\n" +
                            "(C) 2021, Builtbybel";
        }

        private void richInfo_LinkClicked(object sender, LinkClickedEventArgs e) => ThisIsWin11.Helpers.Utils.LaunchUri(e.LinkText);

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.mainForm.ShowLeftPanel = true;
            this.Hide();
        }
    }
}