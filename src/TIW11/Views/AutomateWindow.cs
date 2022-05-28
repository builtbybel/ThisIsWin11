using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class AutomateWindow : Form
    {
        private GetStarted.OS osInfo = new GetStarted.OS();

        private static readonly string componentsVersion = "40";

        private void menuAutomateInfo_Click(object sender, EventArgs e) => rtbPS.Text = "PowerUI\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion;

        public AutomateWindow()
        {
            InitializeComponent();
            RegisterTheme();
        }

        private void AutomateWindow_Load(object sender, EventArgs e)
        {
            InitializeAutomationPackage();
            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            btnAutomateMenu.Text = "\uE712";
            btnEdit.Text = "\uE70B" + " Script Editor";
            rtbDesc.Text = "You will find here custom tasks and script files to customize Windows 11 according to your wishes.\n\n" +
                          "To obtain new collections visit the GitHub repository of the app:\n\n" + Helpers.Strings.Uri.URL_GITREPO;

            lstCategory.SetSelected(0, true);
        }

        private void RegisterTheme()
        {
            BorderStyle textStyle = !ThemeHelper.AppsUseLightTheme() ? BorderStyle.None : BorderStyle.Fixed3D;
            Color colorBackground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundColor : ThemeHelper.LightBackgroundColor;
            Color colorForeground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForgroundColor;
            Color colorForegroundContrast = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForegroundContrast;

            this.BackColor =
            pnlLeft.BackColor =
            pnlTop.BackColor =
            pnlBottom.BackColor =
            btnAutomateMenu.BackColor =
            lblHeader.BackColor =
            lnkSubHeader.BackColor =
            rtbDesc.BackColor =
            lstCategory.BackColor =
            lstPS.BackColor =
            lblCategories.BackColor =
            lblScripts.BackColor =
                colorBackground;

            btnAutomateMenu.ForeColor =
            lblHeader.ForeColor =
            lnkSubHeader.LinkColor =
            rtbDesc.ForeColor =
            lstPS.ForeColor =
            lstCategory.ForeColor =
            lblCode.ForeColor =
            lblCategories.ForeColor =
            lblScripts.ForeColor =
                colorForeground;

            rtbDesc.ForeColor =
            txtScriptName.ForeColor =
                colorForegroundContrast;

            txtScriptName.BorderStyle = textStyle;

            if (!ThemeHelper.AppsUseLightTheme())
            {
                txtScriptName.BackColor = Color.Black;
                lblCode.BackColor = Color.MediumVioletRed;
                rtbPS.ForeColor = Color.HotPink;
                rtbPS.BackColor = Color.FromArgb(36, 36, 36);
            }
            else
            {
                txtScriptName.BackColor = colorBackground;
                rtbPS.BackColor = Color.LavenderBlush;
                rtbPS.ForeColor = Color.Black;
            }
        }

        private void InitializeAutomationPackage()
        {
            string path = Helpers.Strings.Data.ScriptsRootDir;
            if (Directory.Exists(path))
            {
                PopulateCategory();
                PopulatePS();
            }
        }

        // Populate categories
        private void PopulateCategory()
        {
            lstPS.Items.Clear();

            String[] dirs = System.IO.Directory.GetDirectories(Helpers.Strings.Data.ScriptsRootDir);
            int i;
            for (i = 0; i < dirs.Length; i++)
            {
                lstCategory.Items.Add(Path.GetFileNameWithoutExtension(dirs[i]));
            }
        }

        // Populate PowerShell scripts
        private void PopulatePS()
        {
            lstPS.Items.Clear();

            DirectoryInfo dirs = new DirectoryInfo(Helpers.Strings.Data.ScriptsRootDir + lstCategory.Text);
            FileInfo[] listSettings = dirs.GetFiles("*.ps1");
            foreach (FileInfo fi in listSettings)
            {
                lstPS.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                lstPS.Enabled = true;
            }

            // Hide logs
            if (lstCategory.Items.Contains("logs"))
                lstCategory.Items.Remove("logs");
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)

             => PopulatePS();

        private void CreateLogsDir()
        {
            try
            {
                if (!Directory.Exists(Helpers.Strings.Data.ScriptsLogsDir))
                    Directory.CreateDirectory(Helpers.Strings.Data.ScriptsLogsDir);
            }
            catch { }
        }

        public async void DoAutomate()
        {
            if (lstPS.CheckedItems.Count == 0)
                MessageBox.Show("No tasks selected.");
            else
            {
                if (!osInfo.IsWin11())
                    MessageBox.Show("We could not recognize this system as Windows 11. Some scripts are not tested on this operating system and could lead to malfunction.");

                if (MessageBox.Show("Do you want to run selected tasks?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < lstPS.Items.Count; i++)
                    {
                        if (lstPS.GetItemChecked(i))
                        {
                            lstPS.SelectedIndex = i;
                            string psdir = Helpers.Strings.Data.ScriptsRootDir + lstCategory.Text + "\\" + lstPS.SelectedItem.ToString() + ".ps1";
                            var ps1File = psdir;

                            var equals = new[] { "Requires -RunSilent" };

                            var str = rtbDesc.Text;
                            btnCancel.Visible = true;
                            progress.Visible = true;
                            progress.Style = ProgressBarStyle.Marquee;
                            progress.MarqueeAnimationSpeed = 30;

                            btnAutomate.Enabled = false;
                            lnkSubHeader.Text = "Processing " + lstPS.Text;

                            if (equals.Any(str.Contains))                   // Silent
                            {
                                var startInfo = new ProcessStartInfo()
                                {
                                    FileName = "powershell.exe",
                                    Arguments = $"-executionpolicy bypass -file \"{ps1File}\"",
                                    UseShellExecute = false,
                                    CreateNoWindow = true,
                                };

                                await Task.Run(() => { Process.Start(startInfo).WaitForExit(); });
                            }
                            else                                            // Create ConsoleWindow
                            {
                                var startInfo = new ProcessStartInfo()
                                {
                                    FileName = "powershell.exe",
                                    Arguments = $"-executionpolicy bypass -noexit -file \"{ps1File}\"",
                                    UseShellExecute = false,
                                };

                                await Task.Run(() => { Process.Start(startInfo).WaitForExit(); });
                            }

                            btnAutomate.Enabled = true;
                            lnkSubHeader.Text = "";

                            // Write log
                            CreateLogsDir();
                            File.WriteAllText(Helpers.Strings.Data.ScriptsLogsDir + lstPS.Text + ".txt", "last applied: " + DateTime.Now.ToString() + Environment.NewLine + rtbPS.Text);
                        }
                    }

                    progress.Visible = false;
                    btnCancel.Visible = false;

                    MessageBox.Show("Selected tasks have been successfully executed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lstPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string psdir = Helpers.Strings.Data.ScriptsRootDir + lstCategory.Text + "\\" + lstPS.Text + ".ps1";
            txtScriptName.Text = lstPS.Text;
            rtbPS.Visible = true;

            try
            {
                using (StreamReader sr = new StreamReader(psdir, Encoding.Default))
                {
                    StringBuilder content = new StringBuilder();

                    while (!sr.EndOfStream)
                        content.AppendLine(sr.ReadLine());

                    // Code section
                    rtbPS.Text = content.ToString();

                    // Info section
                    rtbDesc.Text = string.Join(Environment.NewLine, File.ReadAllLines(psdir).Where(s => s.StartsWith("###")).Select(s => s.Substring(3).Replace("###", "\n")));
                }
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            String CurrentUser = Environment.UserName;
            Process[] allProcesses = Process.GetProcessesByName("powershell");
            if (null != allProcesses)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C TASKKILL /F /FI \"USERNAME eq " + CurrentUser + "\" /IM powershell.exe";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }

            btnCancel.Visible = false;
        }

        private void menuAutomateEdit_Click(object sender, EventArgs e)
        {
            if (lstPS.SelectedIndex == -1)
            {
                MessageBox.Show("No script selected.");
                return;
            }

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "powershell_ise.exe";
                process.StartInfo.Arguments = "\"" + Helpers.Strings.Data.ScriptsRootDir + lstCategory.Text + "\\" + lstPS.SelectedItem.ToString() + ".ps1" + "\"";
                process.Start();
            }
            catch { }
        }

        private void menuAutomateSave_Click(object sender, EventArgs e)
        {
            if (lstPS.SelectedIndex == -1)
            {
                MessageBox.Show("No script selected.");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt|*.ps1|*.ps1";
            dlg.FileName = txtScriptName.Text;
            dlg.DefaultExt = ".ps1";
            dlg.RestoreDirectory = true;
            dlg.InitialDirectory = Helpers.Strings.Data.ScriptsRootDir;
            dlg.FilterIndex = 2;

            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, rtbPS.Text, Encoding.UTF8);
                    PopulatePS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAutomateOnTheFly_Click(object sender, EventArgs e)
        {
            rtbDesc.Clear();
            btnAutomateOnTheFly.Text = "Processing".ToUpper();

            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddScript(rtbPS.Text);
                powerShell.AddCommand("Out-String");
                Collection<PSObject> PSOutput = powerShell.Invoke();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (PSObject pSObject in PSOutput)
                    stringBuilder.AppendLine(pSObject.ToString());

                rtbDesc.Text = stringBuilder.ToString();
            }
            btnAutomateOnTheFly.Text = "Run this code on-the-fly".ToUpper();
        }

        private void menuAutomateImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "*.txt|*.txt|*.ps1|*.ps1";
            ofd.DefaultExt = ".ps1";
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.FilterIndex = 2;

            string strDestPath = Helpers.Strings.Data.ScriptsRootDir;
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    try
                    {
                        File.Copy(fileName, strDestPath + @"\" + Path.GetFileName(fileName));
                        File.Delete(fileName);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message, this.Text); }
                }
            }

            PopulatePS();
        }

        private void menuAutomateApplied_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dirs = new DirectoryInfo(Helpers.Strings.Data.ScriptsLogsDir);
                FileInfo[] listApplied = dirs.GetFiles("*.txt");

                StringBuilder message = new StringBuilder();

                foreach (FileInfo fi in listApplied)
                {
                    message.AppendLine("- " + Path.GetFileNameWithoutExtension(fi.Name));
                }

                rtbPS.Text = "List of applied tasks:" + "\r\n\n" + message.ToString();
            }
            catch { MessageBox.Show("No tasks applied."); }
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void rtbDesc_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnAutomate_Click(object sender, EventArgs e) => DoAutomate();

        private void btnAutomateMenu_Click(object sender, EventArgs e) => this.menuAutomate.Show(Cursor.Position.X, Cursor.Position.Y);

        private void btnEdit_Click(object sender, EventArgs e)
        
            => menuAutomateEdit.PerformClick();

        private void menuAutomatePopOut_Click(object sender, EventArgs e)
        {
            AutomateWindow automate = new AutomateWindow(); automate.Show();
        }

        private void txtScriptName_Click(object sender, EventArgs e)
        {
            if (txtScriptName.Text == "Script Name")
                txtScriptName.Clear();
        }
    }
}