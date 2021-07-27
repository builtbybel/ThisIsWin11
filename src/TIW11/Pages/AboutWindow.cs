﻿using System;
using System.Net;
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
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            btnBack.Text = "\uE72B";

            string changelog = new WebClient().DownloadString(Helpers.Strings.Uri.GitVersionHint);
            rtbAbout.Text = mainForm.Text + "\nVersion: " + Program.GetCurrentVersionTostring() + "\n" +
                            "Builtbybel\n\n" +
                            "GitHub: https://github.com/builtbybel/ThisIsWin11\n" +
                            "Twitter: https://twitter.com/builtbybel\n\n" +
                            "MIT License\n\n\n" +
                            "New in this version:" + changelog;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.PanelLeftShow = true;
            this.Hide();
        }

        private void rtbAbout_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}