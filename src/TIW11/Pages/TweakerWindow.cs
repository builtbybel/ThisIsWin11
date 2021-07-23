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
        private Features.OS osInfo = new Features.OS();

        private MainWindow mainForm = null;

        public TweakerWindow(Form frm)
        {
            mainForm = frm as MainWindow;
            InitializeComponent();
            InitializeCustomizationPkg();

            btnImport.Text = "\uE710";          // Import scripts
        }

        private void InitializeCustomizationPkg()
        {
            string path = @"custom";
            if (Directory.Exists(path))
            {
                PopulatePS();
            }
        }

        private void PopulatePS()
        {
            lstPS.Items.Clear();

            DirectoryInfo dirs = new DirectoryInfo(@"custom");
            FileInfo[] listSettings = dirs.GetFiles("*.ps1");
            foreach (FileInfo fi in listSettings)
            {
                lstPS.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                lstPS.Enabled = true;
            }
        }

        public async void RunScripter()
        {
            if (!osInfo.IsWin11())
            {
                MessageBox.Show("We could not recognize this system as Windows 11. Some scripts are not tested on this operating system and could lead to malfunction.");
            }

            if (MessageBox.Show("Do you want to apply selected scripts?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lstPS.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select a script.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                for (int i = 0; i < lstPS.Items.Count; i++)
                {
                    if (lstPS.GetItemChecked(i))
                    {
                        lstPS.SelectedIndex = i;
                        string psdir = @"custom\" + lstPS.SelectedItem.ToString() + ".ps1";
                        var ps1File = psdir;

                        var equals = new[] { "Silent" };
                        var str = richDesc.Text;

                        btnApply.Text = "Processing";

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

                        btnApply.Text = "Apply selected";

                        MessageBox.Show("Custom script " + "\"" + lstPS.Text + "\" " + "has been successfully executed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            {
                this.mainForm.ShowLeftPanel = true;
                this.mainForm.textPS.Visible = false;

                this.Hide();
            }
        }

        private void lstPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string psdir = @"custom\" + lstPS.Text + ".ps1";

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
                    richDesc.Text = string.Join(Environment.NewLine, System.IO.File.ReadAllLines(psdir).Where(s => s.StartsWith("###")).Select(s => s.Substring(3).Replace("###", "\r\n\n")));
                }
            }
            catch { }
        }

        private void btnApply_Click(object sender, EventArgs e) => RunScripter();

        private void richDesc_LinkClicked(object sender, LinkClickedEventArgs e) => ThisIsWin11.Helpers.Utils.LaunchUri(e.LinkText);

        private void TweakerWindow_FormClosing(object sender, FormClosingEventArgs e) => mainForm.textPS.Visible = false;

        private void btnImport_Click(object sender, EventArgs e) => MessageBox.Show("Not available in this release.", "Import script");
    }
}