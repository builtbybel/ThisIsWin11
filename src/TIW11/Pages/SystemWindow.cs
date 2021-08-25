using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThisIsWin11.PumpedApp;
using ThisIsWin11.PumpedApp.ITreeNode;

namespace ThisIsWin11
{
    public partial class SystemWindow : Form
    {
        private static readonly string componentsVersion = "52 Preview";

        private Showcase.OS osInfo = new Showcase.OS();

        private int progression = 0;
        private int progressionIncrease = 0;

        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private void menuSystemInfo_Click(object sender, EventArgs e) => MessageBox.Show("PumpedApp\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public SystemWindow()
        {
            InitializeComponent();
        }

        private void SystemWindow_Shown(object sender, EventArgs e)
        {
            InitializeAssessments();
            UISelection();
        }

        //some UI nicety
        private void UISelection()
        {
            logger.SetTarget(rtbPS);        //logs messages to target rtb
            btnSystemMenu.Text = "\uE712";

            rtbPS.Text = "As long as Windows 11 is in development, system and privacy settings will be rolled out cautiously." +
                         Environment.NewLine + Environment.NewLine +
                         "If you have tried one or the other fix and tweak, feel free to suggest it here: " + Helpers.Strings.Uri.GitRepo +
                         "\n\nClick the <Check> button to run a quick check of your Windows 11 configuration." +
                         "\n\nYou can always restore the default Windows 11 settings. The option for this can be found in the upper right menu.";
        }

        public void InitializeAssessments()
        {
            tvwAssessments.Nodes.Clear();
            tvwAssessments.BeginUpdate();

            // root node
            TreeNode root = new TreeNode("Windows 11" + "\x20" + osInfo.GetVersion())
            {
                Checked = true,
            };

            TreeNode appearance = new TreeNode("Personalization", new TreeNode[] {
                new AssessmentNode(new PumpedApp.Assessment.Personalization.AppsTheme()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.WindowsTheme()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.Transparency()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.SnapAssistFlyout()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.Widgets()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.TaskbarAl()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.TaskbarSearch()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.TaskbarChat()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.FileExplorer()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.MostUsedApps()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.HiddenFileFolder()),
                new AssessmentNode(new PumpedApp.Assessment.Personalization.HiddenFileExt()),
            })
            {
                Checked = true,
            };

            TreeNode system = new TreeNode("System", new TreeNode[] {
                new AssessmentNode(new PumpedApp.Assessment.System.Fax()),
                new AssessmentNode(new PumpedApp.Assessment.System.XPSWriter()),
                new AssessmentNode(new PumpedApp.Assessment.System.EnableWSL()),
                new AssessmentNode(new PumpedApp.Assessment.System.TeamsAutostart()),
            })
            {
                Checked = true,
            };

            TreeNode gaming = new TreeNode("Gaming", new TreeNode[] {
                new AssessmentNode(new PumpedApp.Assessment.Gaming.GameDVR()),
                new AssessmentNode(new PumpedApp.Assessment.Gaming.PowerThrottling()),
                new AssessmentNode(new PumpedApp.Assessment.Gaming.VisualFX()),
            })
            {
                Checked = true,
            };


            TreeNode privacy = new TreeNode("Privacy (to disable)", new TreeNode[] {
                new AssessmentNode(new PumpedApp.Assessment.Privacy.DiagnosticData()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.Telemetry()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.CompatibilityTelemetry()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.LocationTracking()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.Advertising()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.Feedback()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.SuggestedContent()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.Biometrics()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.AppsAutoInstall()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.WindowsTips()),
                new AssessmentNode(new PumpedApp.Assessment.Privacy.TailoredExperiences()),
            })
            {
                Checked = true
            };

            TreeNode apps = new TreeNode("Apps permissions (to disable)", new TreeNode[] {
                new AssessmentNode(new PumpedApp.Assessment.Apps.AppNotifications()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Camera()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Microphone()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Call()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Notifications()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.AccountInfo()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Contacts()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Calendar()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.CallHistory()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Email()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Tasks()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Messaging()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Motion()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.OtherDevices()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.BackgroundApps()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.TrackingApps()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.DiagnosticInformation()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Documents()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Pictures()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Videos()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.Radios()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.FileSystem()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.EyeGaze()),
                new AssessmentNode(new PumpedApp.Assessment.Apps.CellularData()),
            })
            {
                Checked = true
            };

            root.Nodes.AddRange(new TreeNode[]
            {
                appearance,
                system,
                gaming,
                privacy,
                apps,
            });

            tvwAssessments.Nodes.Add(root);

            //some tvw nicety
            tvwAssessments.Nodes[0].ForeColor = Color.DeepPink;
            tvwAssessments.Nodes[0].NodeFont = new Font(tvwAssessments.Font, FontStyle.Bold);
            tvwAssessments.EndUpdate();
        }

        private List<AssessmentNode> CollectAssessmentNodes()
        {
            List<AssessmentNode> selectedAssessments = new List<AssessmentNode>();

            foreach (TreeNode treeNode in tvwAssessments.Nodes.All())
            {
                if (treeNode.Checked && treeNode.GetType() == typeof(AssessmentNode))
                {
                    selectedAssessments.Add((AssessmentNode)treeNode);
                }
            }

            progressionIncrease = (int)Math.Floor(100.0f / selectedAssessments.Count);

            return selectedAssessments;
        }

        private void Reset()
        {
            lnkSystemPreset.Visible = false;

            progression = 0;
            progressionIncrease = 0;

            progress.Value = 0;
            progress.Visible = true;
            rtbPS.Text = "";
        }

        private void DoProgress(int value)
        {
            progression = value;
            progress.Value = progression;
        }

        private void IncrementProgress()
        {
            progression += progressionIncrease;
            progress.Value = progression;
        }

        private async void btnSystemCheck_Click(object sender, EventArgs e)
        {
            Reset();

            tvwAssessments.ExpandAll();
            tvwAssessments.Nodes[0].EnsureVisible();

            int performAssessmentsCount = 0;

            List<AssessmentNode> selectedAssessments = CollectAssessmentNodes();

            foreach (AssessmentNode node in selectedAssessments)
            {
                var treatment = node.Assessment;
                ListViewItem detail = new ListViewItem(treatment.ID());
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => treatment.CheckAssessment()).ConfigureAwait(true);
                // logger.Log("Check {0}", node.Text);

                bool shouldPerform = await analyzeTask;
                lnkSubHeader.Text = node.Text;

                if (shouldPerform)
                {
                    logger.Log("Should be fixed: {0}", node.Text);
                    //logger.Log("- {0}", node.Text);

                    performAssessmentsCount += 1;
                }
                else
                {
                    node.Checked = false; //uncheck all fixed
                    //logger.Log("Already fixed: {0}", node.Text);
                }
            }

            DoProgress(100);

            //add some sum
            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("======= Results =======\n");
            sum.Append($"{selectedAssessments.Count} issues has been checked.\r\n");
            sum.Append($"{selectedAssessments.Count - performAssessmentsCount} issues already fixed (we've unchecked it).\r\n");
            sum.Append(Environment.NewLine);
            sum.Append($"{performAssessmentsCount} issues needs to be fixed (just a recommendation).\r\n");

            logger.Log(sum.ToString(), "");
            lnkSubHeader.Text = performAssessmentsCount + " items requires attention.";
        }

        private async void ApplyAssessments(List<AssessmentNode> treeNodes)
        {
            foreach (AssessmentNode node in treeNodes)
            {
                var treatment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => treatment.DoAssessment()).ConfigureAwait(true);

                lnkSubHeader.Text = node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";
        }

        private async void UndoAssessments(List<AssessmentNode> treeNodes)
        {
            foreach (AssessmentNode node in treeNodes)
            {
                var treatment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => treatment.UndoAssessment()).ConfigureAwait(true);

                lnkSubHeader.Text = "Undo: " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";
        }

        private void btnSystemFix_Click(object sender, EventArgs e)
        {
            Reset();

            List<AssessmentNode> performNodes = CollectAssessmentNodes();
            ApplyAssessments(performNodes);
        }

        private void menuSystemUndo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to revert all selected settings to Windows 11 default state?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                List<AssessmentNode> performNodes = CollectAssessmentNodes();
                UndoAssessments(performNodes);
            }
        }

        private void SelectAssessmentNodes(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    SelectAssessmentNodes(trNode.Nodes, isCheck);
            }
        }

        private void tvwAssessments_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tvwAssessments.BeginUpdate();

            foreach (TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }

            tvwAssessments.EndUpdate();
        }

        private void menuSystemPopOut_Click(object sender, EventArgs e)
        {
            SystemWindow system = new SystemWindow(); system.Show();
        }

        private void menuSystemExportLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbPS.Text))
            {
                MessageBox.Show("Nothing to export.");
            }
            else
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "*.txt|*.txt";
                dlg.DefaultExt = ".txt";
                dlg.FileName = "ThisIsWin11-systemlog";
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

        private void menuSystemSelect_Click(object sender, EventArgs e)
        {
            menuSystemSelect.Checked = !(menuSystemSelect.Checked);

            if (menuSystemSelect.Checked == true)
                SelectAssessmentNodes(tvwAssessments.Nodes, true);
            else
                SelectAssessmentNodes(tvwAssessments.Nodes, false);
        }

        private void btnSystemMenu_Click(object sender, EventArgs e) => this.menuSystem.Show(Cursor.Position.X, Cursor.Position.Y);

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void menuSystemExportProfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;
            f.FileName = "tiw11-profile";
            f.Filter = "ThisIsWin11 files *.tiw1|*.tiw1";

            if (f.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(f.OpenFile()))
                {
                    foreach (TreeNode treeNode in tvwAssessments.Nodes.All())
                    {
                        if (!treeNode.Checked)
                            continue;
                        writer.WriteLine(String.Format("{0}", treeNode.Text));
                    }

                    writer.Close();
                }
                MessageBox.Show("Profile has been successfully exported.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuSystemImportProfile_Click(object sender, EventArgs e)
        {
            lnkSystemPreset.Visible = false;

            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;
            f.FileName = "windows10-profile";
            f.Filter = "ThisIsWin11 files *.tiw1|*.tiw1";

            if (f.ShowDialog() == DialogResult.OK)
            {
                SelectAssessmentNodes(tvwAssessments.Nodes, false);
                tvwAssessments.ExpandAll();
                tvwAssessments.Nodes[0].EnsureVisible();
                using (StreamReader reader = new StreamReader(f.OpenFile()))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        foreach (TreeNode treeNode in tvwAssessments.Nodes.All())
                        {
                            if (treeNode.Text.Contains(line))
                            {
                                treeNode.BackColor = Color.Yellow;
                                treeNode.Text += "\x20" + "(" + Path.GetFileNameWithoutExtension(f.FileName) + ")";
                                treeNode.Checked = true;
                            }
                        }
                    }
                    MessageBox.Show("Profile has been successfully imported.\n\nWe have highlighted the configuration that would be enabled (no changes are done yet).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lnkSystemPreset.Visible = true;
            }
        }

        private void lnkSystemPreset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => menuSystemImportProfile.PerformClick();

        private void tvwAssessments_Click(object sender, EventArgs e) => lnkSystemPreset.Visible = false;
    }
}