using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class TweakerWindow : Form
    {
        public static string mAppLogsDir = Helpers.Strings.Data.PackagesLogsDir;

        private Showcase.OS osInfo = new Showcase.OS();
        private MainWindow mainForm = null;

        public TweakerWindow(Form frm)
        {
            mainForm = frm as MainWindow;

            InitializeComponent();
        }

        private void TweakerWindow_Load(object sender, EventArgs e)
        {
            InitializeCustomizationPkg();

            this.Text = mainForm.Text;
            this.ActiveControl = lblSubHeader;

            btnBack.Text = "\uE72B";
            btnTweakerMenu.Text = "\uE712";

            mainForm.pbView.Visible = false;
            mainForm.rtbPS.Visible = true;

        }

        private void TweakerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.rtbPS.Visible = false; mainForm.pbView.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.PanelLeftShow = true;
            this.mainForm.rtbPS.Visible = false;

            this.Hide();
        }

        private void InitializeCustomizationPkg()
        {
            string path = Helpers.Strings.Data.PackagesRootDir;
            if (Directory.Exists(path))
            {
                PopulatePS();
            }
        }

        private void PopulatePS()
        {
            lstPS.Items.Clear();

            DirectoryInfo dirs = new DirectoryInfo(Helpers.Strings.Data.PackagesRootDir);
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

        public async void RunTweaker()
        {
            if (lstPS.CheckedItems.Count == 0)
            {
                MessageBox.Show("No script selected.");
            }
            else
            {
                if (!osInfo.IsWin11())
                {
                    MessageBox.Show("We could not recognize this system as Windows 11. Some scripts are not tested on this operating system and could lead to malfunction.");
                }

                if (MessageBox.Show("Do you want to apply selected scripts?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < lstPS.Items.Count; i++)
                    {
                        if (lstPS.GetItemChecked(i))
                        {
                            lstPS.SelectedIndex = i;
                            string psdir = Helpers.Strings.Data.PackagesRootDir + lstPS.SelectedItem.ToString() + ".ps1";
                            var ps1File = psdir;

                            var equals = new[] { "Requires -RunSilent" };

                            var str = rtbDesc.Text;
                            btnCancel.Visible = true;
                            progress.Visible = true;
                            progress.Style = ProgressBarStyle.Marquee;
                            progress.MarqueeAnimationSpeed = 30;

                            btnApply.Text = "Processing " + lstPS.Text;

                            if (equals.Any(str.Contains))                   //silent
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
                            else                                            //create ConsoleWindow
                            {
                                var startInfo = new ProcessStartInfo()
                                {
                                    FileName = "powershell.exe",
                                    Arguments = $"-executionpolicy bypass -noexit -file \"{ps1File}\"",
                                    UseShellExecute = false,
                                };

                                await Task.Run(() => { Process.Start(startInfo).WaitForExit(); });
                            }

                            // Write log
                            CreateLogsDir();
                            File.WriteAllText(Helpers.Strings.Data.PackagesLogsDir + lstPS.Text + ".txt", "last applied: " + DateTime.Now.ToString() + Environment.NewLine + mainForm.rtbPS.Text);
                        }
                    }

                    btnApply.Text = "Apply selected";
                    progress.Visible = false;
                    btnCancel.Visible = false;

                    MessageBox.Show("Selected scripts have been successfully executed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lstPS_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string psdir = Helpers.Strings.Data.PackagesRootDir + lstPS.Text + ".ps1";
            mainForm.pbView.Visible = false;
            mainForm.rtbPS.Visible = true;

            try
            {
                using (StreamReader sr = new StreamReader(psdir, Encoding.Default))
                {
                    StringBuilder content = new StringBuilder();

                    while (!sr.EndOfStream)
                        content.AppendLine(sr.ReadLine());

                    // Code section
                    mainForm.TweakerDescription = content.ToString();

                    // Info section
                    rtbDesc.Text = string.Join(Environment.NewLine, File.ReadAllLines(psdir).Where(s => s.StartsWith("###")).Select(s => s.Substring(3).Replace("###", "\n")));
                }
            }
            catch { }
        }

        private void rtbDesc_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void btnApply_Click(object sender, EventArgs e) => RunTweaker();

        private void btnTweakerMenu_Click(object sender, EventArgs e) => this.menuTweaker.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuTweakerNewWindow_Click(object sender, EventArgs e)
        {
            TweakerWindow tw = new TweakerWindow(mainForm); tw.Show();
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

        private void menuTweaksEdit_Click(object sender, EventArgs e)
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
                process.StartInfo.Arguments = "\"" + Helpers.Strings.Data.PackagesRootDir + "\\" + lstPS.SelectedItem.ToString() + ".ps1" + "\"";
                process.Start();
            }
            catch { }
        }

        private void menuTweaksSave_Click(object sender, EventArgs e)
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
            dlg.InitialDirectory = Helpers.Strings.Data.PackagesRootDir;
            dlg.FilterIndex = 2;

            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, mainForm.rtbPS.Text, Encoding.UTF8);
                    //Refresh
                    PopulatePS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuTweaksImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available in this release.");
        }

        private void menuTweaksApplied_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dirs = new DirectoryInfo(Helpers.Strings.Data.PackagesLogsDir);
                FileInfo[] listApplied = dirs.GetFiles("*.txt");

                StringBuilder message = new StringBuilder();

                foreach (FileInfo fi in listApplied)
                {
                    message.AppendLine("- " + Path.GetFileNameWithoutExtension(fi.Name));
                }

                MessageBox.Show("List of applied tweaks:" + "\r\n\n" + message.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("No scripts applied."); }
        }
    }
}