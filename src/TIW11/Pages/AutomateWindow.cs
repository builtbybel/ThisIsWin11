using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
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
        public static string mAppLogsDir = Helpers.Strings.Data.ScriptsLogsDir;
        private Presenter.OS osInfo = new Presenter.OS();

        private static readonly string componentsVersion = "15";

        private void menuAutomateInfo_Click(object sender, EventArgs e) => MessageBox.Show("PowerUI\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public AutomateWindow()
        {
            InitializeComponent();
        }

        private void AutomateWindow_Load(object sender, EventArgs e)
        {
            InitializeCustomizationPkg();
            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            btnAutomateMenu.Text = "\uE712";

            rtbPS.Text = "You will find here custom tasks and script files to customize Windows 11 according to your wishes.\n\n" +
                          "To obtain new collections visit the GitHub repository of the app:\n\nhttps://github.com/builtbybel/ThisIsWin11/tree/main/collections";
        }

        private void InitializeCustomizationPkg()
        {
            string path = Helpers.Strings.Data.ScriptsRootDir;
            if (Directory.Exists(path))
            {
                PopulatePS();
            }
        }

        private void PopulatePS()
        {
            lstPS.Items.Clear();

            DirectoryInfo dirs = new DirectoryInfo(Helpers.Strings.Data.ScriptsRootDir);
            FileInfo[] listSettings = dirs.GetFiles("*.ps1");
            foreach (FileInfo fi in listSettings)
            {
                lstPS.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                lstPS.Enabled = true;
            }
        }

        private void CreateLogsDir()
        {
            try
            {
                if (!Directory.Exists(mAppLogsDir))
                    Directory.CreateDirectory(mAppLogsDir);
            }
            catch { }
        }

        public async void DoAutomate()
        {
            if (lstPS.CheckedItems.Count == 0)
            {
                MessageBox.Show("No tasks selected.");
            }
            else
            {
                if (!osInfo.IsWin11())
                {
                    MessageBox.Show("We could not recognize this system as Windows 11. Some scripts are not tested on this operating system and could lead to malfunction.");
                }

                if (MessageBox.Show("Do you want to apply selected tasks?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < lstPS.Items.Count; i++)
                    {
                        if (lstPS.GetItemChecked(i))
                        {
                            lstPS.SelectedIndex = i;
                            string psdir = Helpers.Strings.Data.ScriptsRootDir + lstPS.SelectedItem.ToString() + ".ps1";
                            var ps1File = psdir;

                            var equals = new[] { "Requires -RunSilent" };

                            var str = rtbDesc.Text;
                            btnCancel.Visible = true;
                            progress.Visible = true;
                            progress.Style = ProgressBarStyle.Marquee;
                            progress.MarqueeAnimationSpeed = 30;

                            btnApply.Enabled = false;
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

                            btnApply.Enabled = true;
                            lnkSubHeader.Text = "";

                            // Write log
                            CreateLogsDir();
                            File.WriteAllText(Helpers.Strings.Data.ScriptsLogsDir + lstPS.Text + ".txt", "last applied: " + DateTime.Now.ToString() + Environment.NewLine + rtbPS.Text);
                        }
                    }

                    btnApply.Text = "Apply selected";
                    progress.Visible = false;
                    btnCancel.Visible = false;

                    MessageBox.Show("Selected tasks have been successfully executed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lstPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string psdir = Helpers.Strings.Data.ScriptsRootDir + lstPS.Text + ".ps1";
            rtbPS.Visible = true;
            btnAutomateOnTheFly.Visible = true;

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
                process.StartInfo.Arguments = "\"" + Helpers.Strings.Data.ScriptsRootDir + "\\" + lstPS.SelectedItem.ToString() + ".ps1" + "\"";
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
            dlg.FileName = lstPS.Text + "-Copy";
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
            btnAutomateOnTheFly.Text = "Processing";

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
            btnAutomateOnTheFly.Text = "Run this code on-the-fly";
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

                MessageBox.Show("List of applied tasks:" + "\r\n\n" + message.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("No tasks applied."); }
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void rtbDesc_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnApply_Click(object sender, EventArgs e) => DoAutomate();

        private void btnAutomateMenu_Click(object sender, EventArgs e) => this.menuAutomate.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuAutomatePopOut_Click(object sender, EventArgs e)
        {
            AutomateWindow automate = new AutomateWindow(); automate.Show();
        }

        private void lblModuleInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)

            => MessageBox.Show("Send us your video tutorial on Youtube or your specially created help page on your website about this module and we will give you credits here.", "Coming soon");
    }
}