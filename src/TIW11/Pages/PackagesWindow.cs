using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void PackagesWindow_Shown(object sender, EventArgs e)
        {
            UISelection();
            IntializePackages(tvwPackages);
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

        private void IntializePackages(TreeView treeview)
        {
            treeview.Nodes.Clear();
            treeview.BeginUpdate();

            try
            {
                string fileName = new DirectoryInfo(@"data\")
             .EnumerateFiles("packages*.xml").FirstOrDefault()?.FullName;

                XElement doc = XElement.Load(fileName);

                TreeNode moduleNode;
                TreeNode categoriesNode;
                foreach (XElement module in doc.Descendants("Module"))
                {
                    moduleNode = tvwPackages.Nodes.Add(module.Attribute("name").Value + " (v1.1.12653)");
                    foreach (XElement categories in module.Descendants("Category"))
                    {
                        categoriesNode =
                            moduleNode.Nodes.Add(categories.Attribute("name").Value);
                        foreach (XElement category in categories.Descendants("App"))
                        {
                            categoriesNode.Nodes.Add(category.Attribute("name").Value);
                        }
                    }
                }

                // Some tvw nicety
                treeview.Nodes[0].Expand();
                treeview.Nodes[0].EnsureVisible();
                treeview.Nodes[0].ForeColor = Color.DeepPink;
                treeview.Nodes[0].NodeFont = new Font(treeview.Font, FontStyle.Bold);

                treeview.EndUpdate();
            }
            catch
            { MessageBox.Show("Packages database could not be found.\nPlease make sure that a \"packages*.xml\" file is available in the data directory of this app.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private IEnumerable<TreeNode> CollectPackages(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                yield return node;

                foreach (var child in CollectPackages(node.Nodes))
                    yield return child;
            }
        }

        private void btnCreatePackage_Click(object sender, EventArgs e)
        {
            rtbPS.Clear();

            if (tvwPackages.Nodes.Count == 0)
            {
                MessageBox.Show("Nothing selected.");
            }
            else
            {
                StringBuilder message = new StringBuilder();

                var selectedItems = new List<string>();

                foreach (var node in CollectPackages(tvwPackages.Nodes))

                {
                    if (node.Checked)

                    {
                        selectedItems.Add("winget install --id=" + node.Text + " -e");
                        message.AppendLine("- " + node.Text);
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

            foreach (var node in CollectPackages(tvwPackages.Nodes))
            {
                if (node.Checked)
                {
                    btnRunPackage.Enabled = false;
                    btnCreatePackage.Enabled = false;
                    tvwPackages.Enabled = false;
                    progress.Visible = true;
                    progress.Style = ProgressBarStyle.Marquee;
                    progress.MarqueeAnimationSpeed = 30;
                    rtbPS.Clear();
                    message.AppendLine("- " + node.Text);

                    rtbPS.Text += Environment.NewLine + "Installing " + Environment.NewLine + message.ToString() +
                                 Environment.NewLine + "You can continue working while we install.\n\n" +
                                                       "Have you experienced that Windows 11 blocks Edge browser competitors from opening links.\n" +
                                                       "https://www.theverge.com/2021/11/15/22782802/microsoft-block-edgedeflector-windows-11\n" +
                                                       "We have prepared a script for bypassing this in the ThisIsWin11 automation module.";

                    await Task.Run(() => InstallPackages("winget install --id=" + node.Text + " -e --accept-package-agreements --accept-source-agreements"));
                }
            }

            rtbPS.Text += Environment.NewLine + Environment.NewLine + "I'm done.\nI'm open.\nFollow me on " + Helpers.Strings.Uri.GitRepo;

            progress.Visible = false;
            btnRunPackage.Enabled = true;
            btnCreatePackage.Enabled = true;
            tvwPackages.Enabled = true;
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

            if (f.ShowDialog() == DialogResult.OK)

            {
                tvwPackages.Nodes.Clear();

                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    try
                    {
                        File.Copy(f.FileName, Helpers.Strings.Data.DataRootDir + @"\" + Path.GetFileName(f.FileName));
                        MessageBox.Show("A restart is required for the changes to take effect.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message, this.Text); }
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

        private void menuPackagesRefresh_Click(object sender, EventArgs e)
        {
            IntializePackages(tvwPackages);
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void lblModuleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         => MessageBox.Show("Send us your video tutorial on Youtube or your specially created help page on your website about this module and we will give you credits here.", "Coming soon");

        private void menuPackagesExpand_Click(object sender, EventArgs e)
        {
            menuPackagesExpand.Checked = !(menuPackagesExpand.Checked);

            tvwPackages.BeginUpdate();
            if (menuPackagesExpand.Checked == true)
            {
                tvwPackages.Nodes[0].ExpandAll();
                tvwPackages.Nodes[0].EnsureVisible();
            }
            else if (menuPackagesExpand.Checked == false)
                tvwPackages.Nodes[0].Collapse();

            tvwPackages.EndUpdate();
        }
    }
}