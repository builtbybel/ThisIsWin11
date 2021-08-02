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

        private static readonly string componentsVersion = "22";

        private void menuAppsInfo_Click(object sender, EventArgs e) => MessageBox.Show("Kickassbloat\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public AppsWindow()
        {
            InitializeComponent();
        }

        private void AppsWindow_Shown(object sender, EventArgs e)
        {
            InitializeUWPSystem();   //systemapps from resource file
            InitializeUWP();         //now our system apps
            UISelection();
        }

        //some UI nicety
        private void UISelection()
        {
            btnAppsMenu.Text = "\uE712";

            rtbPS.Text = lstUWP.Items.Count.ToString() + " pre-installed apps have been found on your Windows 11 installation.\n\n\n" +
                                                          "It's a simple thing to remove some of these apps. Just hit the <Uninstall> button on your left." +
                                                           Environment.NewLine + Environment.NewLine +
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
        }

        private void RefreshUWP(bool unsetting)
        {
            lstUWP.Items.Clear();
            InitializeUWPSystem();
            InitializeUWP();

            try
            {
                if (unsetting)
                {
                    lstUWP.SelectedIndex = -1;
                }
            }
            catch { }
        }

        private void menuAppsRefresh_Click(object sender, EventArgs e)
        {
            RefreshUWP(true);
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

            removeUWPList.Clear();
            removeUWPFailedList.Clear();
            rtbPS.Clear();
            btnRemoveUWP.Enabled = false;

            if (lstUWP.CheckedItems.Count > 0)
            {
                foreach (string app in lstUWP.CheckedItems)
                {
                    selectedApps += app + Environment.NewLine;
                }
                if (MessageBox.Show("Do you want to remove the selected app(s)?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (string app in lstUWP.CheckedItems)
                    {
                        await Task.Run(() => RemoveUWP(app));

                        rtbPS.Text += Environment.NewLine + "Uninstalling " + app.ToString();
                    }

                    RefreshUWP(true);

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
                        message += Environment.NewLine + "A Community syncing function is in the works. This will automatically flag and remove the really unnecessary apps for you." +
                                    "This way we make sure you don't uninstall an important app. If you accidentally uninstall an important app, you can always reinstall all the apps preinstalled by Windows 11 in ThisIsWin11 Tweaker module." +
                                    Environment.NewLine + Environment.NewLine + lstUWP.Items.Count + " apps are left.";
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
            else
            {
                MessageBox.Show("No apps selected.");
            }
        }

        private void menuAppsRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove all preinstalled apps for the logged in user, except the Microsoft Store. Do you wish to continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                        RefreshUWP(false);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnAppsMenu_Click(object sender, EventArgs e) => this.menuApps.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuAppsSync_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available in this release.");
        }

        private void checkAppsSystem_CheckedChanged(object sender, EventArgs e)
        {
            RefreshUWP(false);
        }

        private void menuAppsSelect_Click(object sender, EventArgs e)
        {
            menuAppsSelect.Checked = !(menuAppsSelect.Checked);
            for (int i = 0; i < lstUWP.Items.Count; i++)
            {
                if (menuAppsSelect.Checked == true)
                    lstUWP.SetItemChecked(i, menuAppsSelect.Checked = true);
                else
                    lstUWP.SetItemChecked(i, menuAppsSelect.Checked = false);
            }
        }

        private void menuAppsImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;

            if (f.ShowDialog() == DialogResult.OK)

            {
                lstUWP.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lstUWP.Items.Add(line);
                    }
                }
            }
        }

        private void menuAppsNewWindow_Click(object sender, EventArgs e)
        {
            AppsWindow apps = new AppsWindow(); apps.Show();
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}