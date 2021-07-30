using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThisIsWin11.ITreeNode;

namespace ThisIsWin11
{
    public partial class PrivacyWindow : Form
    {
        private static readonly string componentsVersion = "10 Beta";
        private Showcase.OS osInfo = new Showcase.OS();

        private int progression = 0;
        private int progressionIncrease = 0;

        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private MainWindow mainForm = null;

        private void menuPrivacyInfo_Click(object sender, EventArgs e) => MessageBox.Show("Lucent11\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public PrivacyWindow(Form frm)
        {
            mainForm = frm as MainWindow;

            InitializeComponent();
        }

        private void PrivacyWindow_Load(object sender, EventArgs e)
        {
            InitializeAssessments();
            logger.SetTarget(mainForm.rtbPS);

            btnBack.Text = "\uE72B";
            btnPrivacyMenu.Text = "\uE712";

            mainForm.rtbPS.Visible = true;
            mainForm.rtbPS.Text = "As long as Windows 11 is in development, privacy settings will be rolled out cautiously." +
                                    Environment.NewLine + Environment.NewLine +
                                    "If you have tried one or the other fix and tweak, feel free to suggest it here: " + Helpers.Strings.Uri.GitRepo +
                                    "\n\nDisable \"Diagnostic data\" only if you’re not in the Windows Insider program. Currently, as Windows 11 is only available through it, you shouldn’t disable it.";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.PanelForms = true;
            this.mainForm.rtbPS.Visible = false;

            this.Hide();
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
                new AssessmentNode(new Assessment.Privacy.Telemetry()),
                new AssessmentNode(new Assessment.Privacy.CompatibilityTelemetry()),
                new AssessmentNode(new Assessment.Privacy.DiagnosticData()),
                new AssessmentNode(new Assessment.Privacy.LocationTracking()),
                new AssessmentNode(new Assessment.Privacy.Advertising()),
                new AssessmentNode(new Assessment.Privacy.Feedback()),
            })
            {
                Checked = true
            };

            TreeNode apps = new TreeNode("Apps permissions", new TreeNode[] {
                new AssessmentNode(new Assessment.Apps.AppNotifications()),
                new AssessmentNode(new Assessment.Apps.Camera()),
                new AssessmentNode(new Assessment.Apps.Microphone()),
                new AssessmentNode(new Assessment.Apps.Call()),
                new AssessmentNode(new Assessment.Apps.Notifications()),
                new AssessmentNode(new Assessment.Apps.AccountInfo()),
                new AssessmentNode(new Assessment.Apps.Contacts()),
                new AssessmentNode(new Assessment.Apps.Calendar()),
                new AssessmentNode(new Assessment.Apps.CallHistory()),
                new AssessmentNode(new Assessment.Apps.Email()),
                new AssessmentNode(new Assessment.Apps.Tasks()),
                new AssessmentNode(new Assessment.Apps.Messaging()),
                new AssessmentNode(new Assessment.Apps.Motion()),
                new AssessmentNode(new Assessment.Apps.OtherDevices()),
                new AssessmentNode(new Assessment.Apps.BackgroundApps()),
                new AssessmentNode(new Assessment.Apps.TrackingApps()),
                new AssessmentNode(new Assessment.Apps.DiagnosticInformation()),
                new AssessmentNode(new Assessment.Apps.Documents()),
                new AssessmentNode(new Assessment.Apps.Pictures()),
                new AssessmentNode(new Assessment.Apps.Videos()),
                new AssessmentNode(new Assessment.Apps.Radios()),
                new AssessmentNode(new Assessment.Apps.FileSystem()),
                new AssessmentNode(new Assessment.Apps.EyeGaze()),
                new AssessmentNode(new Assessment.Apps.CellularData()),
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

        private void SelectAssessmentNodes(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    SelectAssessmentNodes(trNode.Nodes, isCheck);
            }
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

                detail.Tag = treatment;
            }

            DoProgress(100);

            //add some sum
            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("=============== Results ===============\n");
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
                Stopwatch stopWatch = new Stopwatch();

                var result = await performTask;
            }

            DoProgress(100);
        }

        private void btnPrivacyFix_Click(object sender, EventArgs e)
        {
            Reset();

            List<AssessmentNode> performNodes = CollectAssessmentNodes();
            ApplyAssessments(performNodes);
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
            progress.Visible = true;
            mainForm.rtbPS.Text = "";

            progressionIncrease = 0;
            progress.Value = 0;
        }

        private void DoProgress(int value)
        {
            progression = value;
            progress.Value = progression;
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

        private void btnPrivacyMenu_Click(object sender, EventArgs e) => this.menuPrivacy.Show(Cursor.Position.X, Cursor.Position.Y);

        private void menuPrivacyNewWindow_Click(object sender, EventArgs e)
        {
            PrivacyWindow privacy = new PrivacyWindow(mainForm); privacy.Show();
        }

        private void menuPrivacyExportLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mainForm.rtbPS.Text))
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
                        File.WriteAllText(dlg.FileName, mainForm.rtbPS.Text, Encoding.UTF8);
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

     
    }
}