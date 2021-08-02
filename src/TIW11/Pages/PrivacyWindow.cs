using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThisIsWin11.Lucent11;
using ThisIsWin11.Lucent11.ITreeNode;

namespace ThisIsWin11
{
    public partial class PrivacyWindow : Form
    {
        private static readonly string componentsVersion = "20 Beta";
        private Showcase.OS osInfo = new Showcase.OS();

        private int progression = 0;
        private int progressionIncrease = 0;

        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private void menuPrivacyInfo_Click(object sender, EventArgs e) => MessageBox.Show("Lucent11\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public PrivacyWindow()
        {
            InitializeComponent();
        }

        private void PrivacyWindow_Shown(object sender, EventArgs e)
        {
            InitializeAssessments();
            UISelection();

            logger.SetTarget(rtbPS);        //logs messages to rtbPS
        }

        //some UI nicety
        private void UISelection()
        {
            btnPrivacyMenu.Text = "\uE712";

            rtbPS.Text = "As long as Windows 11 is in development, privacy settings will be rolled out cautiously." +
                         Environment.NewLine + Environment.NewLine +
                         "If you have tried one or the other fix and tweak, feel free to suggest it here: " + Helpers.Strings.Uri.GitRepo +
                         "\n\nDisable \"Diagnostic data\" only if you’re not in the Windows Insider program. Currently, as Windows 11 is only available through it, you shouldn’t disable it.";
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

            TreeNode privacy = new TreeNode("Privacy", new TreeNode[] {
                new AssessmentNode(new Lucent11.Assessment.Privacy.DiagnosticData()),
                new AssessmentNode(new Lucent11.Assessment.Privacy.Telemetry()),
                new AssessmentNode(new Lucent11.Assessment.Privacy.CompatibilityTelemetry()),
                new AssessmentNode(new Lucent11.Assessment.Privacy.LocationTracking()),
                new AssessmentNode(new Lucent11.Assessment.Privacy.Advertising()),
                new AssessmentNode(new Lucent11.Assessment.Privacy.Feedback()),
                new AssessmentNode(new Lucent11.Assessment.Privacy.SuggestedContent()),
                new AssessmentNode(new Lucent11.Assessment.Privacy.Biometrics()),
            })
            {
                Checked = true
            };

            TreeNode apps = new TreeNode("Apps permissions", new TreeNode[] {
                new AssessmentNode(new Lucent11.Assessment.Apps.AppNotifications()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Camera()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Microphone()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Call()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Notifications()),
                new AssessmentNode(new Lucent11.Assessment.Apps.AccountInfo()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Contacts()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Calendar()),
                new AssessmentNode(new Lucent11.Assessment.Apps.CallHistory()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Email()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Tasks()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Messaging()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Motion()),
                new AssessmentNode(new Lucent11.Assessment.Apps.OtherDevices()),
                new AssessmentNode(new Lucent11.Assessment.Apps.BackgroundApps()),
                new AssessmentNode(new Lucent11.Assessment.Apps.TrackingApps()),
                new AssessmentNode(new Lucent11.Assessment.Apps.DiagnosticInformation()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Documents()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Pictures()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Videos()),
                new AssessmentNode(new Lucent11.Assessment.Apps.Radios()),
                new AssessmentNode(new Lucent11.Assessment.Apps.FileSystem()),
                new AssessmentNode(new Lucent11.Assessment.Apps.EyeGaze()),
                new AssessmentNode(new Lucent11.Assessment.Apps.CellularData()),
            })
            {
                Checked = true
            };

            root.Nodes.AddRange(new TreeNode[]
            {
                privacy,
                apps,
            });

            tvwAssessments.Nodes.Add(root);

            //som tvw nicety
            tvwAssessments.ExpandAll();
            tvwAssessments.Nodes[0].EnsureVisible();
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

        private async void btnPrivacyAnalyse_Click(object sender, EventArgs e)
        {
            Reset();
            int performAssessmentsCount = 0;

            List<AssessmentNode> selectedAssessments = CollectAssessmentNodes();

            foreach (AssessmentNode node in selectedAssessments)
            {
                var treatment = node.Assessment;
                ListViewItem detail = new ListViewItem(treatment.ID());
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => treatment.CheckAssessment()).ConfigureAwait(true);
                // logger.Log("Check {0}", node.Text);

                bool shouldPerform = await analyzeTask;
                StringBuilder issues = new StringBuilder();

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
            sum.Append($"{selectedAssessments.Count} privacy issues has been checked.\r\n");
            sum.Append($"{selectedAssessments.Count - performAssessmentsCount} privacy issues already fixed (we've unchecked it).\r\n");
            sum.Append(Environment.NewLine);
            sum.Append($"{performAssessmentsCount} privacy issues needs to be fixed.\r\n");

            logger.Log(sum.ToString(), "");
        }

        private async void ApplyAssessments(List<AssessmentNode> treeNodes)
        {
            foreach (AssessmentNode node in treeNodes)
            {
                var treatment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => treatment.DoAssessment()).ConfigureAwait(true);

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
        }

        private async void UndoAssessments(List<AssessmentNode> treeNodes)
        {
            foreach (AssessmentNode node in treeNodes)
            {
                var treatment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => treatment.UndoAssessment()).ConfigureAwait(true);

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
        }

        private void btnPrivacyFix_Click(object sender, EventArgs e)
        {
            Reset();

            List<AssessmentNode> performNodes = CollectAssessmentNodes();
            ApplyAssessments(performNodes);
        }

        private void menuPrivacyUndo_Click(object sender, EventArgs e)
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

        private void CheckTreeViewNodes(TreeNode node, bool isChecked)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;

                if (child.Nodes.Count > 0)
                {
                    CheckTreeViewNodes(child, isChecked);
                }
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

        private void menuPrivacyNewWindow_Click(object sender, EventArgs e)
        {
            PrivacyWindow privacy = new PrivacyWindow(); privacy.Show();
        }

        private void menuPrivacyExportLog_Click(object sender, EventArgs e)
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
                dlg.FileName = "ThisIsWin11-privacylog";
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

        private void menuPrivacySelect_Click(object sender, EventArgs e)
        {
            menuPrivacySelect.Checked = !(menuPrivacySelect.Checked);

            if (menuPrivacySelect.Checked == true)
                SelectAssessmentNodes(tvwAssessments.Nodes, true);
            else
                SelectAssessmentNodes(tvwAssessments.Nodes, false);
        }

        private void btnPrivacyMenu_Click(object sender, EventArgs e) => this.menuPrivacy.Show(Cursor.Position.X, Cursor.Position.Y);

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);
    }
}