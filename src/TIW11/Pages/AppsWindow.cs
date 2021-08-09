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

        private static readonly string componentsVersion = "30";

        private void menuAppsInfo_Click(object sender, EventArgs e) => MessageBox.Show("Kickassbloat\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public AppsWindow()
        {
            InitializeComponent();
        }

        private void AppsWindow_Shown(object sender, EventArgs e)
        {
            InitializeUWPSystem();   //systemapps from resource file
            InitializeUWP();         //now the normal apps
            UISelection();
        }

        //some UI nicety
        private void UISelection()
        {
            btnAppsMenu.Text = "\uE712";
            rtbPS.Text = "I am just a Recycle Bin.\n\n" +
                         "Throw everything you don't need into the bin and press <Empty Recycle Bin> button to remove it permanently.\n\n" +
                         "You can also import a custom bloatware list, e.g. you can find a list of pre-installed Windows 11 apps in the data root of this app.\n\n" +
                         "Use the import function in the upper left menu and select file \"bloatwareapps-11\".";
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

            //compare left and rights apps list and remove differences
            string compare = lstUWP.Items.ToString();
            foreach (string item in lstUWPRemove.Items) if (item.Any(compare.Contains)) lstUWP.Items.Remove(item);

            RefreshUWP();
        }

        private void InitializeUWPSystem()
        {
            StreamReader Database = null;

            try
            {
                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemapps.txt");
            }
            catch (FileNotFoundException) //create file if it doesnt exisits
            {
                StreamWriter sw = File.CreateText(Helpers.Strings.Data.DataRootDir + "systemapps.txt");
                sw.Write(Resources.systemapps);    //populate it with built in preset
                sw.Close();

                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemapps.txt");
            }
            finally
            {
                if (Database.Peek() > 0) //exists and not empty
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
            if (MessageBox.Show("Do you want to empty the Recylce Bin and delete all the apps in it?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                //RefreshUWP();

                foreach (var str in removeUWPList)
                {
                    successList += "-" + str + Environment.NewLine;
                }
                foreach (var str in removeUWPFailedList)
                {
                    failedList += "-" + str + Environment.NewLine;
                }

                //summary removal process
                string message = string.Format("Summary:\n{0} app(s) has been selected for removal.\n{1} app(s) has been removed.",
                    removeUWPList.Count + removeUWPFailedList.Count, removeUWPList.Count) + Environment.NewLine + Environment.NewLine;

                if (removeUWPList.Count != 0)
                {
                    message += "The folowing app(s) have been removed successfully:" + Environment.NewLine + successList;
                    message += Environment.NewLine + "A Community syncing function is in the works. This will automatically flag and remove the really unnecessary apps for you.\n" +
                                "This way we make sure you don't uninstall an important app. If you accidentally uninstall an important app, you can always reinstall all the apps pre-installed by Windows 11 in ThisIsWin11 automation module." +
                                Environment.NewLine + Environment.NewLine + lstUWP.Items.Count + " apps are left.\n";
                }

                if (removeUWPFailedList.Count != 0)
                {
                    message += "The following app(s) could not be removed: " + Environment.NewLine + failedList;
                    message += Environment.NewLine + "Note, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc." +
                                                     "as these apps are needed for the Windows 11 Experience and for other programs. If you try, you’ll see an error message saying the removal failed.\n\n" +
                                                     "Please also check ThisIsWin11 automation module to see if you can find a community debloating task. These are often more aggressive.";
                }

                btnRemoveUWP.Enabled = true;
                rtbPS.Text = message;
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
            lstUWP.Items.Clear();
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

                        //compare imported list with installed apps and add differences ONLY
                        string compare = lstUWP.Items.ToString();
                        foreach (string item in lstUWP.Items) if (item.Any(compare.Contains)) lstUWPRemove.Items.Remove(item);
                    }
                    MessageBox.Show("We've compared your import list and added ONLY differences to Recycle bin.\n" +
                                    "Please note that these apps are NOT installed on your system.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuAppsPopOut_Click(object sender, EventArgs e)
        {
            AppsWindow apps = new AppsWindow(); apps.Show();
        }

        private void btnAppsMenu_Click(object sender, EventArgs e) => this.menuApps.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuAppsSync_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available in this release.");
        }
    }
}