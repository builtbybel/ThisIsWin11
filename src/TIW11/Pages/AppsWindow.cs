using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class AppsWindow : Form
    {
        private List<string> removeUWPList = new List<string>();
        private List<string> removeUWPFailedList = new List<string>();

        private MainWindow mainForm = null;

        public AppsWindow(Form frm)
        {
            mainForm = frm as MainWindow;

            InitializeComponent();
        }

        private void AppsWindow_Load(object sender, EventArgs e)
        {
            InitializeUWP();

            this.Text = mainForm.Text;
            btnBack.Text = "\uE72B";
            btnAppsMenu.Text = "\uE712";
        }

        public void InitializeUWP()
        {
            lstUWP.Items.Clear();

            using (PowerShell script = PowerShell.Create())
            {
                if (checkAppsAllUsers.Checked)
                {
                    script.AddScript("Get-AppxPackage -AllUsers | Select Name | Out-String -Stream");
                }
                else
                {
                    script.AddScript("Get-AppxPackage | Select Name | Out-String -Stream");
                }

                string trimmed = string.Empty;
                foreach (PSObject x in script.Invoke())
                {
                    trimmed = x.ToString().Trim();
                    if (!string.IsNullOrEmpty(trimmed) && !trimmed.Contains("---"))
                    {
                        if (trimmed != "Name") lstUWP.Items.Add(trimmed);
                    }
                }
            }

            mainForm.rtbPS.Text = lstUWP.Items.Count.ToString() + " pre-installed apps have been found on your Windows 11 installation.\n\n\n" +
                "It's a simple thing to remove some of these apps. Just hit the <Uninstall> button on your right.";
        }

        private void RemoveUWP(string app)
        {
            bool error = false;

            using (PowerShell script = PowerShell.Create())
            {
                if (checkAppsAllUsers.Checked)
                {
                    script.AddScript("Get-AppxPackage " + app + " | Remove-AppxPackage -AllUsers");
                }
                else
                {
                    script.AddScript("Get-AppxPackage " + app + " | Remove-AppxPackage");
                }

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

        private void RefreshUWP(bool unsetting)
        {
            lstUWP.Items.Clear();
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

        private void btnRemoveUWP_Click(object sender, EventArgs e)
        {
            string selectedApps = string.Empty;
            string successList = string.Empty;
            string failedList = string.Empty;

            removeUWPList.Clear();
            removeUWPFailedList.Clear();
            this.Enabled = false;

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
                        RemoveUWP(app);
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
                                     "This way we make sure you don't uninstall an important app. If you accidentally uninstall an important app, you can always reinstall all the apps preinstalled by Windows 11 in ThisIsWin11 Tweaker module.";
                    }

                    if (removeUWPFailedList.Count != 0)
                    {
                        message += "The following app(s) could not be removed: " + Environment.NewLine + failedList;
                        message += Environment.NewLine + "Note, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc." +
                                                         "as these apps are needed for the Windows 11 Experience and for other programs. If you try, you’ll see an error message saying the removal failed.\n\n" +
                                                         "Please also check ThisIsWin11 Tweaker module to see if you can find a community debloating script. These are often more aggressive.";
                    }


                    mainForm.rtbPS.Visible = true;
                    mainForm.pbView.Visible = false;
                    mainForm.rtbPS.Text = message;


                }
            }
            else
            {
                MessageBox.Show("No apps selected.");
            }

            this.Enabled = true;
        }

        private void menuAppsRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove all preinstalled apps for the logged in user, except the Microsoft Store. Do you wish to continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.PanelLeftShow = true;

            this.Hide();
        }

        private void checkAppsAllUsers_CheckedChanged(object sender, EventArgs e)
        {
            RefreshUWP(false);
        }

        private void btnAppsMenu_Click(object sender, EventArgs e) => this.menuApps.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuAppsNewWindow_Click(object sender, EventArgs e)
        {
            AppsWindow uwp = new AppsWindow(mainForm); uwp.Show();
        }

        private void menuAppsSelect_Click(object sender, EventArgs e)
        {
            menuAppsSelect.Checked = !(menuAppsSelect.Checked);
            for (int i = 0; i < lstUWP.Items.Count; i++)
            {
                if (menuAppsSelect.Checked == true)
                    lstUWP.SetItemChecked(i, menuAppsSelect.Checked = true);
                else if (menuAppsSelect.Checked == false)
                    lstUWP.SetItemChecked(i, menuAppsSelect.Checked = false);
            }
        }
    }
}