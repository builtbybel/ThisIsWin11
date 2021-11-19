using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class AppsWindow : Form
    {
        private List<string> removeUWPList = new List<string>();
        private List<string> removeUWPFailedList = new List<string>();
        private List<string> removeUWPSystem = new List<string>();

        private readonly PowerShell powerShell = PowerShell.Create();

        private static readonly string componentsVersion = "50";

        private void menuAppsInfo_Click(object sender, EventArgs e) => MessageBox.Show("PumpedApp\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public AppsWindow()
        {
            InitializeComponent();
        }

        private void AppsWindow_Shown(object sender, EventArgs e)
        {
            InitializeUWPSystem();   // Systemapps from resource file
            InitializeUWP();         // Now the normal apps
            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            btnAppsMenu.Text = "\uE712";
            rtbPS.Text = "I am just a Recycle Bin.\n\n" +
                         "Throw everything you don't need into the bin and press <Empty Recycle Bin> button to remove it permanently.\n\n" +
                         "You can also import a custom bloatware list, e.g. you can find a list of pre-installed Windows 11 apps in the data root of this app.\n\n" +
                         "Use the import function in the upper left menu and select file \"apps11\".";
        }

        private void InitializeUWP()
        {
            lstUWP.Items.Clear();
            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString();
                // Show ONLY NON-SYSTEM apps by comparing found apps with systemapps.txt
                if (removeUWPSystem != null) if ((removeUWPSystem.Any(current.Contains)) && !checkAppsSystem.Checked) continue;

                if (lstUWP.Items.Contains(Regex.Replace(current, "(@{Name=)|(})", ""))) continue;
                lstUWP.Items.Add(Regex.Replace(current, "(@{Name=)|(})", ""));
            }

            // Compare left and rights apps list and remove differences
            string compare = lstUWP.Items.ToString();
            foreach (string item in lstUWPRemove.Items) if (item.Any(compare.Contains)) lstUWP.Items.Remove(item);

            RefreshUWP();
        }

        private void InitializeUWPSystem()
        {
            StreamReader Database = null;

            try
            {
                Helpers.Utils.CreateDataDir();
                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemapps11.txt");
            }
            catch (FileNotFoundException) // Create file if it doesnt exisits
            {
                StreamWriter sw = File.CreateText(Helpers.Strings.Data.DataRootDir + "systemapps11.txt");
                sw.Write(Resources.systemapps);    // Populate it with built in preset
                sw.Close();

                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemapps11.txt");
            }
            finally
            {
                if (Database.Peek() > 0) // Exists and not empty
                {
                    string buff;
                    while ((buff = Database.ReadLine()) != null)
                    {
                        removeUWPSystem.Add(buff);
                    }
                };
                Database.Close();
            }
        }

        private void RefreshUWP()
        {
            int installed = lstUWP.Items.Count;
            int remove = lstUWPRemove.Items.Count;
            lblAppsInstalledCount.Text = "Apps" + " (" + installed.ToString() + ")";
            lblAppsBinCount.Text = "Recycle Bin" + " (" + remove.ToString() + ")";

            if (lstUWPRemove.Items.Count == 0)
            {
                rtbPS.Visible = true;
                lstUWPRemove.Visible = false;
            }
            else
            {
                lstUWPRemove.Visible = true;
                rtbPS.Visible = false;
            }

            if (installed == 0)
                btnAddAll.Enabled =
                btnAdd.Enabled =
                false;
            else
                btnAddAll.Enabled =
                btnAdd.Enabled =
                true;

            if (remove == 0)
                btnRemoveAll.Enabled =
                btnRemove.Enabled =
                btnRemoveUWP.Enabled =
                false;
            else
                btnRemoveAll.Enabled =
                btnRemove.Enabled =
                btnRemoveUWP.Enabled =
                true;
        }

        private void menuAppsRefresh_Click(object sender, EventArgs e)
        {
            lstUWP.Items.Clear();
            lstUWPRemove.Items.Clear();

            InitializeUWPSystem();
            InitializeUWP();
        }

        private void RemoveUWP(string app)
        {
            bool error = false;

            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript("Get-AppxPackage " + app + " | Remove-AppxPackage");

                script.Invoke();
                error = script.HadErrors;
            }

            if (error)
            {
                removeUWPFailedList.Add(app);
            }
            else
            {
                removeUWPList.Add(app);
            }

            return;
        }

        private async void btnRemoveUWP_Click(object sender, EventArgs e)
        {
            string selectedApps = string.Empty;
            string successList = string.Empty;
            string failedList = string.Empty;

            foreach (string app in lstUWPRemove.Items)
            {
                selectedApps += app + Environment.NewLine;
            }
            if (MessageBox.Show("Do you want to empty the Recycle Bin and delete all the apps in it?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                removeUWPList.Clear();
                removeUWPFailedList.Clear();
                rtbPS.Visible = true;
                rtbPS.Clear();
                lstUWPRemove.Visible = false;
                btnRemoveUWP.Enabled = false;

                foreach (string app in lstUWPRemove.Items)
                {
                    rtbPS.Text += Environment.NewLine + "Uninstalling " + app.ToString();

                    await Task.Run(() => RemoveUWP(app));
                }

                foreach (var str in removeUWPList)
                {
                    successList += "-" + str + Environment.NewLine;
                }
                foreach (var str in removeUWPFailedList)
                {
                    failedList += "-" + str + Environment.NewLine;
                }

                // Summary removal process
                string message = string.Format("Summary:\n{0} app(s) has been selected for removal.\n{1} app(s) has been removed.",
                    removeUWPList.Count + removeUWPFailedList.Count, removeUWPList.Count) + Environment.NewLine + Environment.NewLine;

                if (removeUWPList.Count != 0)
                {
                    message += "The folowing app(s) have been removed successfully:" + Environment.NewLine + successList + Environment.NewLine;
                }

                if (removeUWPFailedList.Count != 0)
                {
                    message += "The following app(s) could not be removed: " + Environment.NewLine + failedList;
                    message += Environment.NewLine + "Note, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc." +
                                                     "as these apps are needed for the Windows 11 Experience and for other programs. If you try, you’ll see an error message saying the removal failed.\n\n" +
                                                     "Please check also the automation module to see if you can find a community debloating task. These are often more aggressive.";
                }

                menuAppsRefresh.PerformClick();

                btnRemoveUWP.Enabled = true;
                rtbPS.Text = message + Environment.NewLine;
                rtbPS.Text += Environment.NewLine + lstUWP.Items.Count + " apps are left.\n";
            }
        }

        private void menuAppsRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove all pre-installed apps for the logged in user, except the Microsoft Store. Do you wish to continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using (PowerShell script = PowerShell.Create())
                {
                    this.Enabled = false;
                    script.AddScript("Get-appxprovisionedpackage –online | where-object {$_.packagename –notlike “*store*”} | Remove-AppxProvisionedPackage –online");
                    script.AddScript("Get-AppxPackage | where-object {$_.name –notlike “*store*”} | Remove-AppxPackage");

                    try
                    {
                        script.Invoke();
                        this.Enabled = true;
                        RefreshUWP();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void checkAppsSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAppsSystem.Checked) MessageBox.Show("Be picky about which System applications to uninstall.\n\n" +
                "You can uninstall most of the built-in apps, even ones that don't normally offer an \"Uninstall\" option.\n\n" +
                "Note, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc." +
                "as these apps are needed for the Windows 11 \"Experience\" and for other programs. If you try, you’ll see an error message saying the removal failed.", this.Text, MessageBoxButtons.OK);

            InitializeUWPSystem();
            InitializeUWP();
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstUWP.Items)
            {
                lstUWPRemove.Items.Add(item);
            }
            lstUWP.Items.Clear();
            RefreshUWP();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstUWP.Items.Count != 0)
            {
                if (lstUWP.SelectedItem == null) lstUWP.SelectedIndex = 0;
                while (lstUWP.SelectedItem != null)
                {
                    lstUWPRemove.Items.Add(lstUWP.SelectedItem);
                    lstUWP.Items.Remove(lstUWP.SelectedItem);
                }
                RefreshUWP();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstUWPRemove.Items)
            {
                lstUWP.Items.Add(item);
                // lstUWP.Items.Remove(item);
            }
            lstUWPRemove.Items.Clear();
            RefreshUWP();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstUWPRemove.Items.Count != 0)
            {
                if (lstUWPRemove.SelectedItem == null) lstUWPRemove.SelectedIndex = 0;
                while (lstUWPRemove.SelectedItem != null)
                {
                    lstUWP.Items.Add(lstUWPRemove.SelectedItem);
                    lstUWPRemove.Items.Remove(lstUWPRemove.SelectedItem);
                }
                RefreshUWP();
            }
        }

        private void menuAppsImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;

            if (f.ShowDialog() == DialogResult.OK)

            {
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    lstUWPRemove.Items.Clear();

                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lstUWPRemove.Items.Add(line);
                        RefreshUWP();

                        // Compare imported list with installed apps and add differences ONLY
                        string compare = lstUWP.Items.ToString();
                        foreach (string item in lstUWPRemove.Items) if (item.Any(compare.Contains)) lstUWP.Items.Remove(item);
                    }

                    RefreshUWP();

                    MessageBox.Show("We've snyced your import list with the apps in Recycle Bin.\n" +
                        "Please note, that some of these apps may not be installed on your system.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuAppsExport_Click(object sender, EventArgs e)
        {
            if (lstUWPRemove.Items.Count == 0)
            {
                MessageBox.Show("No apps in Recycle Bin found.");
                return;
            }

            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "my-bloatware-list";
            s.Filter = "Text File | *.txt";

            if (s.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(s.OpenFile());
                for (int i = 0; i < lstUWPRemove.Items.Count; i++)
                {
                    writer.WriteLine(lstUWPRemove.Items[i].ToString());
                }

                writer.Dispose();
                writer.Close();
            }
        }

        private void menuAppsPopOut_Click(object sender, EventArgs e)
        {
            AppsWindow apps = new AppsWindow(); apps.Show();
        }

        private void btnAppsMenu_Click(object sender, EventArgs e) => this.menuApps.Show(Cursor.Position.X, Cursor.Position.Y);

        private void lblModuleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         => MessageBox.Show("Send us your video tutorial on Youtube or your specially created help page on your website about this module and we will give you credits here.", "Coming soon");
        
    }
}