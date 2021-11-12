using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class PackagesWindow : Form
    {
        private MainWindow mainForm = null;

        public PackagesWindow(Form frm)
        {
            mainForm = frm as MainWindow;

            InitializeComponent();
        }

        private void PackagesWindow_Load(object sender, EventArgs e)
        {
            IntializePackages();
            UISelection();

            IsWingetInstalled();
        }

        // Some UI nicety
        private void UISelection()
        {
            btnPackagesMenu.Text = "\uE712";
            rtbPS.Text = "Automate your next installation and create your own Windows 11 essentials.\n\n" +
                         "To find more packages, visit the Microsoft community Windows Package Manager manifest repository: https://github.com/microsoft/winget-pkgs/tree/master/manifests\n" +
                         "Or just get them from here:\nhttps://winstall.app\n\n\n\n" +
                         "How to use:\n" +
                         "1. Select your packages\n" +
                         "2. Create your packages by clicking on <Create Package> button\n" +
                         "3. Install your packages with Button <Run Installer>";
        }

        private void IntializePackages()
        {
            lstPackages.Items.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(Helpers.Strings.Data.DataRootDir + "packages-11.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        lstPackages.Items.Add(line);
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreatePackage_Click(object sender, EventArgs e)
        {
            rtbPS.Clear();

            if (lstPackages.CheckedItems.Count == 0)
            {
                MessageBox.Show("Nothing selected.");
            }
            else
            {
                StringBuilder message = new StringBuilder();

                var selectedItems = new List<string>();
                for (var i = 0; i < lstPackages.Items.Count; i++)
                {
                    if (lstPackages.GetItemChecked(i))
                    {
                        selectedItems.Add("winget install --id=" + lstPackages.Items[i].ToString() + " -e");
                        message.AppendLine("- " + lstPackages.Items[i].ToString());
                    }
                }
                rtbPS.Text = string.Join(@" ; ", selectedItems);

                MessageBox.Show("The following packages has been created:\n\n" + message.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnRunPackage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbPS.Text))
            {
                MessageBox.Show("No package created.");
                return;
            }

            StringBuilder message = new StringBuilder();

            foreach (string package in lstPackages.CheckedItems)
            {
                btnRunPackage.Enabled = false;
                btnCreatePackage.Enabled = false;
                lstPackages.Enabled = false;
                progress.Visible = true;
                progress.Style = ProgressBarStyle.Marquee;
                progress.MarqueeAnimationSpeed = 30;
                rtbPS.Clear();
                message.AppendLine("- " + package);

                rtbPS.Text += Environment.NewLine + "Installing " + Environment.NewLine + message.ToString() +
                             Environment.NewLine + "You can continue working while we install...";

                await Task.Run(() => InstallPackages("winget install --id=" + package + " -e --accept-package-agreements --accept-source-agreements"));
            }

            rtbPS.Text += Environment.NewLine + Environment.NewLine + "I'm done.\nI'm open.\nFollow me on " + Helpers.Strings.Uri.GitRepo;

            progress.Visible = false;
            btnRunPackage.Enabled = true;
            btnCreatePackage.Enabled = true;
            lstPackages.Enabled = true;
        }

        private void InstallPackages(string package)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddScript(package);

                try
                {   // Invoke execution on pipeline
                    Collection<PSObject> PSOutput = powerShell.Invoke();

                    foreach (PSObject outputItem in PSOutput)
                    {
                        if (outputItem != null)
                        {
                            package = ($"{outputItem}");
                        }
                    }
                }
                catch
                { }

                // Check the other output, error streams etc.
                if (powerShell.Streams.Error.Count > 0)
                {
                }
            }
        }

        private void IsWingetInstalled()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages\\Microsoft.DesktopAppInstaller_8wekyb3d8bbwe");
            if (!Directory.Exists(path))
            {
                rtbPS.Text += "\n\n\nWe could not locate winget on your System.\nPlease install it by clicking on the button below";
                btnInstallWinget.Visible = true;
            }
            else btnInstallWinget.Visible = false;
        }

        private void btnInstallWinget_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/microsoft/winget-cli/releases/download/v1.1.12653/Microsoft.DesktopAppInstaller_8wekyb3d8bbwe.msixbundle";

            progress.Visible = true;
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    wc.DownloadFileAsync(
                        new Uri(url), Application.StartupPath + @"\data\" + "winget.msixbundle"

                    );
                }
            }
            catch { }
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            btnInstallWinget.Invoke((MethodInvoker)(() => btnInstallWinget.Text = $"{e.ProgressPercentage}%"));
        }

        public void Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo()
                {
                    FileName = @"data\winget.msixbundle",
                    UseShellExecute = true,
                };
                Process.Start(startInfo);
                btnInstallWinget.Visible = false;
                progress.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
                btnInstallWinget.Visible = false;
                progress.Visible = false;
            }
        }

        private void btnPackagesMenu_Click(object sender, EventArgs e) => this.menuPackages.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuPackagesImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;

            if (f.ShowDialog() == DialogResult.OK)

            {
                lstPackages.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lstPackages.Items.Add(line);
                    }
                }
            }
        }

        private void menuPackagesPopOut_Click(object sender, EventArgs e)
        {
            PackagesWindow package = new PackagesWindow(mainForm); package.Show();
        }

        private void menuPackagesExport_Click(object sender, EventArgs e)
        {
            if (!rtbPS.Text.Contains("winget install"))
            {
                MessageBox.Show("No package created.");
            }
            else
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "*.ps1|*.ps1";
                dlg.DefaultExt = ".ps1";
                dlg.RestoreDirectory = true;
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                try
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(dlg.FileName, rtbPS.Text, Encoding.UTF8);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void menuPackagesSelect_Click(object sender, EventArgs e)
        {
            menuPackagesSelect.Checked = !(menuPackagesSelect.Checked);
            for (int i = 0; i < lstPackages.Items.Count; i++)
            {
                if (menuPackagesSelect.Checked == true)
                    lstPackages.SetItemChecked(i, menuPackagesSelect.Checked = true);
                else if (menuPackagesSelect.Checked == false)
                    lstPackages.SetItemChecked(i, menuPackagesSelect.Checked = false);
            }
        }

        private void menuPackagesRefresh_Click(object sender, EventArgs e)
        {
            IntializePackages();
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void lblModuleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         => MessageBox.Show("Send us your video tutorial on Youtube or your specially created help page on your website about this module and we will give you credits here.", "Coming soon");
    }
}