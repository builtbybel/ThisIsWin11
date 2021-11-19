using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThisIsWin11.OpenTweaks;
using ThisIsWin11.OpenTweaks.ITreeNode;

namespace ThisIsWin11
{
    public partial class SystemWindow : Form
    {
        private static readonly string componentsVersion = "80";
        private readonly string osWarning = "We could not recognize this system as Windows 11. Some settings are not tested on this operating system and could lead to malfunction.";

        private Presenter.OS osInfo = new Presenter.OS();

        private int progression = 0;
        private int progressionIncrease = 0;

        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private void menuSystemInfo_Click(object sender, EventArgs e) => MessageBox.Show("OpenTweaks\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public SystemWindow()
        {
            InitializeComponent();
        }

        private void SystemWindow_Shown(object sender, EventArgs e)
        {
            if (!osInfo.IsWin11())
            {
                MessageBox.Show(osWarning.ToString());
            }

            InitializeAssessments();
            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            logger.SetTarget(rtbPS);        // Logs messages to target rtb
            btnSystemMenu.Text = "\uE712";
            btnSystemUndo.Text = "\uE777";

            rtbPS.Text = "Click the <Check> button to run a quick check of your Windows 11 configuration." +
                         "\n\nYou can always restore the default Windows 11 settings. The option for this can be found in the upper right corner." +
                          Environment.NewLine + Environment.NewLine +
                         "If you have tried one or the other fix and tweak, feel free to suggest it here:\n\n" + Helpers.Strings.Uri.GitRepo;
        }

        public void InitializeAssessments()
        {
            tvwAssessments.Nodes.Clear();
            tvwAssessments.BeginUpdate();

            // Root node
            TreeNode root = new TreeNode("Windows 11" + "\x20" + osInfo.GetVersion())
            {
                Checked = true,
            };

            TreeNode appearance = new TreeNode("Personalization", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.AppsTheme()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.WindowsTheme()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.Transparency()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.SnapAssistFlyout()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.Widgets()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.WidgetsRemove()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.TaskbarAl()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.TaskbarSi()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.TaskbarMM()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.TaskbarSearch()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.TaskbarChat()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.TaskView()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.FileExplorer()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.MostUsedApps()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.HiddenFileFolder()),
                new AssessmentNode(new OpenTweaks.Assessment.Personalization.HiddenFileExt()),
            })
            {
                Checked = true,
            };

            TreeNode system = new TreeNode("System", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.System.Fax()),
                new AssessmentNode(new OpenTweaks.Assessment.System.XPSWriter()),
                new AssessmentNode(new OpenTweaks.Assessment.System.EnableWSL()),
                new AssessmentNode(new OpenTweaks.Assessment.System.TeamsAutostart()),
            })
            {
                Checked = true,
            };

            TreeNode gaming = new TreeNode("Gaming", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Gaming.GameDVR()),
                new AssessmentNode(new OpenTweaks.Assessment.Gaming.PowerThrottling()),
                new AssessmentNode(new OpenTweaks.Assessment.Gaming.VisualFX()),
            })
            {
                Checked = true,
            };

            TreeNode privacy = new TreeNode("Privacy (to disable)", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.DiagnosticData()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.Telemetry()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.CompatibilityTelemetry()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.LocationTracking()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.Advertising()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.Feedback()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.SuggestedContent()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.Biometrics()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.AppsAutoInstall()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.WindowsTips()),
                new AssessmentNode(new OpenTweaks.Assessment.Privacy.TailoredExperiences()),
            })
            {
                Checked = true
            };

            TreeNode apps = new TreeNode("Apps permissions (to disable)", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Apps.AppNotifications()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Camera()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Microphone()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Call()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Notifications()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.AccountInfo()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Contacts()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Calendar()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.CallHistory()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Email()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Tasks()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Messaging()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Motion()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.OtherDevices()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.BackgroundApps()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.TrackingApps()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.DiagnosticInformation()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Documents()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Pictures()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Videos()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.Radios()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.FileSystem()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.EyeGaze()),
                new AssessmentNode(new OpenTweaks.Assessment.Apps.CellularData()),
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

            // Some tvw nicety
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
                var assessment = node.Assessment;
                ListViewItem detail = new ListViewItem(assessment.ID());
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => assessment.CheckAssessment()).ConfigureAwait(true);
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

            // Add summary
            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("======= Results =======\n");
            sum.Append($"{selectedAssessments.Count} issues has been checked.\r\n");
            sum.Append($"{selectedAssessments.Count - performAssessmentsCount} issues already fixed (we've unchecked it).\r\n");
            sum.Append(Environment.NewLine);
            sum.Append($"{performAssessmentsCount} issues needs to be fixed (just a recommendation).\r\n");

            logger.Log(sum.ToString(), "");

            if (!osInfo.IsWin11())
            {
                lnkSubHeader.Text = performAssessmentsCount + " settings requires attention. " + osWarning.ToString();
            }
            else
            {
                lnkSubHeader.Text = performAssessmentsCount + " of " + selectedAssessments.Count + " settings requires attention.";
            }
        }

        private async void ApplyAssessments(List<AssessmentNode> treeNodes)
        {
            btnSystemFix.Enabled = false;
            btnSystemUndo.Enabled = false;
            tvwAssessments.Enabled = false;

            foreach (AssessmentNode node in treeNodes)
            {
                var assessment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.DoAssessment()).ConfigureAwait(true);

                lnkSubHeader.Text = node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            btnSystemFix.Enabled = true;
            btnSystemUndo.Enabled = true;
            tvwAssessments.Enabled = true;
        }

        private async void UndoAssessments(List<AssessmentNode> treeNodes)
        {
            btnSystemUndo.Enabled = false;
            btnSystemFix.Enabled = false;
            tvwAssessments.Enabled = false;

            foreach (AssessmentNode node in treeNodes)
            {
                var assessment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.UndoAssessment()).ConfigureAwait(true);

                lnkSubHeader.Text = "Undo: " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            btnSystemUndo.Enabled = true;
            btnSystemFix.Enabled = true;
            tvwAssessments.Enabled = true;
        }

        private void btnSystemFix_Click(object sender, EventArgs e)
        {
            Reset();

            List<AssessmentNode> performNodes = CollectAssessmentNodes();
            ApplyAssessments(performNodes);
        }

        private void btnSystemUndo_Click(object sender, EventArgs e)
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
            f.FileName = "opentweaks_windows10Profile";
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

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => MessageBox.Show(lnkSubHeader.Text);

        private void lblModuleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          => MessageBox.Show("Send us your video tutorial on Youtube or your specially created help page on your website about this module and we will give you credits here.", "Coming soon");
    }
}