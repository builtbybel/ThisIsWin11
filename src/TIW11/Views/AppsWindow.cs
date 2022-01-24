using System;
using System.Collections.Generic;
using System.Drawing;
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
        private List<string> removeAppsList = new List<string>();
        private List<string> removeAppsFailedList = new List<string>();
        private List<string> removeAppsSystem = new List<string>();

        private readonly PowerShell powerShell = PowerShell.Create();

        private static readonly string componentsVersion = "60";
        private bool isAppsSystem = false;

        private void menuAppsInfo_Click(object sender, EventArgs e) => MessageBox.Show("PumpedApp\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public AppsWindow()
        {
            InitializeComponent();
            RegisterTheme();
        }

        private void AppsWindow_Shown(object sender, EventArgs e)
        {
            UISelection();

            InitializeAppsSystem();   // Systemapps from resource file
            InitializeApps();         // Now the normal apps
        }

        // Some UI nicety
        private void UISelection()
        {
            btnAppsMenu.Text = "\uE712";
            btnAppsRefresh.Text = "\uE777";
        }

        private void RegisterTheme()
        {
            Color colorBackground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundColor : ThemeHelper.LightBackgroundColor;
            Color colorBackgroundContrast = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundContrast : ThemeHelper.LightBackgroundContrast;

            Color colorForeground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForgroundColor;
            Color colorForegroundContrast = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForegroundContrast;

            this.BackColor =
            pnlLeft.BackColor =
            pnlMiddle.BackColor =
            pnlRight.BackColor =
            lblHeader.BackColor =
            btnAppsMenu.BackColor =
            btnAppsRefresh.BackColor =
            lblSubHeader.BackColor =
            lstApps.BackColor =
            lstAppsRemove.BackColor =
            lblAppsBinCount.BackColor =
            lblAppsBinOptions.BackColor =
            rtbPS.BackColor =
                colorBackground;

            lblHeader.ForeColor =
            btnAppsMenu.ForeColor =
            btnAppsRefresh.ForeColor =
            lblAppsBinCount.ForeColor =
            lblAppsBinOptions.LinkColor =
            lblSubHeader.ForeColor =
            lstAppsRemove.ForeColor =
            rtbPS.ForeColor =
                colorForeground;

            btnAdd.BackColor =
            btnAddAll.BackColor =
            btnRemove.BackColor =
            btnRemoveAll.BackColor =
                colorBackgroundContrast;

            btnAdd.ForeColor =
            btnAddAll.ForeColor =
            btnRemove.ForeColor =
            btnRemoveAll.ForeColor =
                colorForeground;

            lstApps.ForeColor =
                colorForegroundContrast;
        }

        private void InitializeApps()
        {
            lstApps.Items.Clear();
            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString();
                // Show ONLY NON-SYSTEM apps by comparing found apps with systemapps.txt
                if (removeAppsSystem != null) if ((removeAppsSystem.Any(current.Contains)) && isAppsSystem == false) continue;

                if (lstApps.Items.Contains(Regex.Replace(current, "(@{Name=)|(})", ""))) continue;
                lstApps.Items.Add(Regex.Replace(current, "(@{Name=)|(})", ""));
            }

            // Compare left and rights apps list and remove differences
            string compare = lstApps.Items.ToString();
            foreach (string item in lstAppsRemove.Items) if (item.Any(compare.Contains)) lstApps.Items.Remove(item);

            RefreshApps();
        }

        private void InitializeAppsSystem()
        {
            StreamReader Database = null;

            try
            {
                Helpers.Strings.CreateDataDir();
                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemApps.txt");
            }
            catch (FileNotFoundException) // Create file if it doesnt exisits
            {
                StreamWriter sw = File.CreateText(Helpers.Strings.Data.DataRootDir + "systemApps.txt");
                sw.Write(Properties.Resources.systemApps);    // Populate it with built in preset
                sw.Close();

                Database = File.OpenText(Helpers.Strings.Data.DataRootDir + "systemApps.txt");
            }
            finally
            {
                if (Database.Peek() > 0) // Exists and not empty
                {
                    string buff;
                    while ((buff = Database.ReadLine()) != null)
                    {
                        removeAppsSystem.Add(buff);
                    }
                };
                Database.Close();
            }
        }

        private void btnAppsRefresh_Click(object sender, EventArgs e)
        {
            lstApps.Items.Clear();
            lstAppsRemove.Items.Clear();

            InitializeAppsSystem();
            InitializeApps();
        }

        private void RefreshApps()
        {
            int installed = lstApps.Items.Count;
            int remove = lstAppsRemove.Items.Count;
            btnAppsInstalledCount.Text = installed.ToString() + " apps";
            lblAppsBinCount.Text = "Recycle bin" + " (" + remove.ToString() + ")";

            if (lstAppsRemove.Items.Count == 0)
            {
                rtbPS.Visible = true;
                lblAppsBinOptions.Visible = true;
                lstAppsRemove.Visible = false;
            }
            else
            {
                lstAppsRemove.Visible = true;
                rtbPS.Visible = false;
                lblAppsBinOptions.Visible = false;
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
                btnRemoveApps.Enabled =
                false;
            else
                btnRemoveAll.Enabled =
                btnRemove.Enabled =
                btnRemoveApps.Enabled =
                true;
        }

        private void RemoveApps(string app)
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
                removeAppsFailedList.Add(app);
            }
            else
            {
                removeAppsList.Add(app);
            }

            return;
        }

        private async void btnRemoveApps_Click(object sender, EventArgs e)
        {
            string selectedApps = string.Empty;
            string successList = string.Empty;
            string failedList = string.Empty;

            foreach (string app in lstAppsRemove.Items)
            {
                selectedApps += app + Environment.NewLine;
            }
            if (MessageBox.Show("Do you want to empty the Recycle bin and delete all apps in it?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                removeAppsList.Clear();
                removeAppsFailedList.Clear();
                rtbPS.Visible = true;
                rtbPS.Clear();
                lstAppsRemove.Visible = false;
                btnRemoveApps.Enabled = false;

                foreach (string app in lstAppsRemove.Items)
                {
                    rtbPS.Text += Environment.NewLine + "Uninstalling " + app.ToString();

                    await Task.Run(() => RemoveApps(app));
                }

                foreach (var str in removeAppsList)
                {
                    successList += "-" + str + Environment.NewLine;
                }
                foreach (var str in removeAppsFailedList)
                {
                    failedList += "-" + str + Environment.NewLine;
                }

                // Summary removal process
                string message = string.Format("Summary:\n{0} app(s) has been selected for removal.\n{1} app(s) has been removed.",
                    removeAppsList.Count + removeAppsFailedList.Count, removeAppsList.Count) + Environment.NewLine + Environment.NewLine;

                if (removeAppsList.Count != 0)
                {
                    message += "The folowing app(s) have been removed successfully:" + Environment.NewLine + successList + Environment.NewLine;
                }

                if (removeAppsFailedList.Count != 0)
                {
                    message += "The following app(s) could not be removed: " + Environment.NewLine + failedList;
                    message += Environment.NewLine + "Note, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc. " +
                                                     "as these apps are needed for the Windows 11 Experience and for other programs. If you try, you’ll see an error message saying the removal failed." +
                                                     "\n\nPlease check also the automation module to see if you can find a community debloating task. These are often more aggressive.";
                }

                btnAppsRefresh.PerformClick();

                btnRemoveApps.Enabled = true;
                rtbPS.Text = message + Environment.NewLine;
                rtbPS.Text += Environment.NewLine + lstApps.Items.Count + " apps are left.\n";
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
                        RefreshApps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnAppsSystem_Click(object sender, EventArgs e)
        {
            if (!isAppsSystem)
            {
                isAppsSystem = true;
                btnAppsSystem.BackColor = Color.Black;

                MessageBox.Show("Be picky about which System applications to uninstall." +
                "\n\nYou can uninstall most of the built-in apps, even ones that don't normally offer an \"Uninstall\" option." +
                "\n\nNote, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc. " +
                "as these apps are needed for the Windows 11 \"Experience\" and for other programs. If you try, you’ll see an error message saying the removal failed.", this.Text, MessageBoxButtons.OK);

                InitializeAppsSystem();
                InitializeApps();
            }
            else
            {
                isAppsSystem = false;
                btnAppsSystem.BackColor = Color.Magenta;

                InitializeApps();
            }
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstApps.Items)
            {
                lstAppsRemove.Items.Add(item);
            }
            lstApps.Items.Clear();
            RefreshApps();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstApps.Items.Count != 0)
            {
                if (lstApps.SelectedItem == null) lstApps.SelectedIndex = 0;
                while (lstApps.SelectedItem != null)
                {
                    lstAppsRemove.Items.Add(lstApps.SelectedItem);
                    lstApps.Items.Remove(lstApps.SelectedItem);
                }
                RefreshApps();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstAppsRemove.Items)
            {
                lstApps.Items.Add(item);
                // lstApps.Items.Remove(item);
            }
            lstAppsRemove.Items.Clear();
            RefreshApps();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstAppsRemove.Items.Count != 0)
            {
                if (lstAppsRemove.SelectedItem == null) lstAppsRemove.SelectedIndex = 0;
                while (lstAppsRemove.SelectedItem != null)
                {
                    lstApps.Items.Add(lstAppsRemove.SelectedItem);
                    lstAppsRemove.Items.Remove(lstAppsRemove.SelectedItem);
                }
                RefreshApps();
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
                    lstAppsRemove.Items.Clear();

                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lstAppsRemove.Items.Add(line);
                        RefreshApps();

                        // Compare imported list with installed apps and add differences ONLY
                        string compare = lstApps.Items.ToString();
                        foreach (string item in lstAppsRemove.Items) if (item.Any(compare.Contains)) lstApps.Items.Remove(item);
                    }

                    RefreshApps();

                    MessageBox.Show("We've synced your import list with the apps in Recycle bin.\n" +
                        "Please note, that some of these apps may not be installed on your system.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuAppsExport_Click(object sender, EventArgs e)
        {
            if (lstAppsRemove.Items.Count == 0)
            {
                MessageBox.Show("No apps in Recycle bin found.");
                return;
            }

            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "my-bloatware-list";
            s.Filter = "Text File | *.txt";

            if (s.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(s.OpenFile());
                for (int i = 0; i < lstAppsRemove.Items.Count; i++)
                {
                    writer.WriteLine(lstAppsRemove.Items[i].ToString());
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

        private void lblAppsBinOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => menuAppsImport.PerformClick();
    }
}