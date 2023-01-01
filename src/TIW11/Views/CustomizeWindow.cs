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
    public partial class CustomizeWindow : Form
    {
        private static readonly string componentsVersion = "150";
        private readonly string osWarning = "We could not recognize this system as Windows 11. Some settings are not tested on this operating system and could lead to malfunction.";

        private GetStarted.OS osInfo = new GetStarted.OS();

        private int progression = 0;
        private int progressionIncrease = 0;

        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private void menuCustomizeInfo_Click(object sender, EventArgs e) => MessageBox.Show("OpenTweaks\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public CustomizeWindow()
        {
            InitializeComponent();
            RegisterTheme();
        }

        private void CustomizeWindow_Shown(object sender, EventArgs e)
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

            btnCustomizeMenu.Text = "\uE712";
            btnCustomizeImport.Text = "\uECC8";
            btnCustomizeExportNShare.Text = "\uE72D";
            rtbPS.Text = "Click the <Check> button to run a quick check of your Windows 11 configuration and to get a preview of the changes that could be applied." +
                         "\n\nYou can always restore the default Windows 11 settings. The option for this can be found in the upper right corner." +
                          Environment.NewLine + Environment.NewLine +
                         "\n\nTip:\nIf you have just switched to Windows 11, we recommend you importing the predefined out-of-box experience \"OOBE Profile\" " +
                         "by clicking on the import button in the upper right corner.";
        }

        private void RegisterTheme()
        {
            Color colorBackground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkBackgroundColor : ThemeHelper.LightBackgroundColor;
            Color colorForeground = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForgroundColor;
            Color colorForegroundContrast = !ThemeHelper.AppsUseLightTheme() ? ThemeHelper.DarkForgroundColor : ThemeHelper.LightForegroundContrast;

            this.BackColor =
            pnlLeft.BackColor =
            pnlRight.BackColor =
            btnCustomizeMenu.BackColor =
            btnCustomizeImport.BackColor =
            btnCustomizeExportNShare.BackColor =
            lnkSubHeader.BackColor =
            rtbPS.BackColor =
            tvwAssessments.BackColor =
                colorBackground;

            btnCustomizeMenu.ForeColor =
            btnCustomizeImport.ForeColor =
            btnCustomizeExportNShare.ForeColor =
            lblHeader.ForeColor =
            lnkSubHeader.LinkColor =
            tvwAssessments.ForeColor =
                colorForeground;

            rtbPS.ForeColor =
                colorForegroundContrast;
        }

        #region 65 Customizations last update 2022/01/23

        public void InitializeAssessments()
        {
            tvwAssessments.Nodes.Clear();
            tvwAssessments.BeginUpdate();

            // Root node
            TreeNode root = new TreeNode("Windows 11" + "\x20" + osInfo.GetVersion())
            {
                Checked = true,
            };

            TreeNode settings = new TreeNode("Settings", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Settings.RestorePoint()),
            })
            {
                Checked = true,
            };

            TreeNode explorer = new TreeNode("Explorer", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Explorer.FileExplorer()),
                new AssessmentNode(new OpenTweaks.Assessment.Explorer.HiddenFileFolder()),
                new AssessmentNode(new OpenTweaks.Assessment.Explorer.HiddenFileExt()),
            })
            {
                Checked = true,
            };

            System.Windows.Forms.TreeNode taskbar = new System.Windows.Forms.TreeNode("Taskbar and Start menu", new System.Windows.Forms.TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Taskbar.TaskbarAl()),
                new AssessmentNode(new OpenTweaks.Assessment.Taskbar.TaskbarSi()),
                new AssessmentNode(new OpenTweaks.Assessment.Taskbar.TaskbarMM()),
                new AssessmentNode(new OpenTweaks.Assessment.Taskbar.TaskbarSearch()),
                new AssessmentNode(new OpenTweaks.Assessment.Taskbar.TaskbarChat()),
                new AssessmentNode(new OpenTweaks.Assessment.Taskbar.TaskView()),
                new AssessmentNode(new OpenTweaks.Assessment.Taskbar.MostUsedApps()),
            })
            {
                Checked = true,
            };

            System.Windows.Forms.TreeNode desktop = new System.Windows.Forms.TreeNode("Desktop", new System.Windows.Forms.TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Desktop.AppsTheme()),
                new AssessmentNode(new OpenTweaks.Assessment.Desktop.WindowsTheme()),
                new AssessmentNode(new OpenTweaks.Assessment.Desktop.Transparency()),
                new AssessmentNode(new OpenTweaks.Assessment.Desktop.SnapAssistFlyout()),
                new AssessmentNode(new OpenTweaks.Assessment.Desktop.Widgets()),
                new AssessmentNode(new OpenTweaks.Assessment.Desktop.WidgetsRemove()),
                new AssessmentNode(new OpenTweaks.Assessment.Desktop.Stickers()),
            })
            {
                Checked = true,
            };

            System.Windows.Forms.TreeNode system = new System.Windows.Forms.TreeNode("My Computer", new System.Windows.Forms.TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.System.Fax()),
                new AssessmentNode(new OpenTweaks.Assessment.System.XPSWriter()),
                new AssessmentNode(new OpenTweaks.Assessment.System.RemoveW11Watermark()),
                new AssessmentNode(new OpenTweaks.Assessment.System.EnableWSL()),
                new AssessmentNode(new OpenTweaks.Assessment.System.InstallWSA()),
                new AssessmentNode(new OpenTweaks.Assessment.System.HyperV()),
                new AssessmentNode(new OpenTweaks.Assessment.System.TeamsAutostart()),
             })
            {
                Checked = true,
            };
            TreeNode paranoia = new TreeNode("Paranoia", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Paranoia.CleanMgr()),
                new AssessmentNode(new OpenTweaks.Assessment.Paranoia.WindowsSpyBlocker()),
                new AssessmentNode(new OpenTweaks.Assessment.Paranoia.ShutUp11()),
            })
            {
                Checked = true,
            };

            TreeNode update = new TreeNode("Windows Update", new TreeNode[] {
                new AssessmentNode(new OpenTweaks.Assessment.Update.Wusa()),
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

            TreeNode privacy = new TreeNode("Privacy (disable)", new TreeNode[] {
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

            TreeNode apps = new TreeNode("Apps permissions (disable)", new TreeNode[] {
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
                settings,
                explorer,
                taskbar,
                desktop,
                system,
                paranoia,
                update,
                gaming,
                privacy,
                apps,
            });

            tvwAssessments.Nodes.Add(root);

            // Some tvw nicety
            foreach (TreeNode tn in tvwAssessments.Nodes) { tn.Expand(); }
            tvwAssessments.Nodes[0].ForeColor = Color.MediumVioletRed;
            tvwAssessments.Nodes[0].NodeFont = new Font(tvwAssessments.Font, FontStyle.Bold);
            tvwAssessments.EndUpdate();
        }

        #endregion 65 Customizations last update 2022/01/23

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

        private async void btnCustomizeCheck_Click(object sender, EventArgs e)
        {
            Reset();
            int performAssessmentsCount = 0;

            List<AssessmentNode> selectedAssessments = CollectAssessmentNodes();

            foreach (AssessmentNode node in selectedAssessments)
            {
                var assessment = node.Assessment;
                ListViewItem detail = new ListViewItem(assessment.ID());
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => assessment.CheckAssessment()).ConfigureAwait(true);
                // logger.Log("Check {0}", node.Text);

                bool shouldPerform = await analyzeTask;
                lnkSubHeader.Text = "Check " + node.Text;

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

            tvwAssessments.ExpandAll();
            tvwAssessments.SelectedNode = tvwAssessments.Nodes[0];
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
            btnCustomizeFix.Enabled = false;
            btnCustomizeUndo.Enabled = false;
            tvwAssessments.Enabled = false;

            foreach (AssessmentNode node in treeNodes)
            {
                var assessment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.DoAssessment()).ConfigureAwait(true);

                lnkSubHeader.Text = "Fixing " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            btnCustomizeFix.Enabled = true;
            btnCustomizeUndo.Enabled = true;
            tvwAssessments.Enabled = true;
        }

        private async void UndoAssessments(List<AssessmentNode> treeNodes)
        {
            btnCustomizeUndo.Enabled = false;
            btnCustomizeFix.Enabled = false;
            tvwAssessments.Enabled = false;

            foreach (AssessmentNode node in treeNodes)
            {
                var assessment = node.Assessment;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.UndoAssessment()).ConfigureAwait(true);

                lnkSubHeader.Text = "Undo " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            btnCustomizeUndo.Enabled = true;
            btnCustomizeFix.Enabled = true;
            tvwAssessments.Enabled = true;
        }

        private void btnCustomizeFix_Click(object sender, EventArgs e)
        {
            Reset();

            List<AssessmentNode> performNodes = CollectAssessmentNodes();
            ApplyAssessments(performNodes);
        }

        private void btnCustomizeUndo_Click(object sender, EventArgs e)
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

        private void menuCustomizePopOut_Click(object sender, EventArgs e)
        {
            CustomizeWindow customize = new CustomizeWindow(); customize.Show();
        }

        private void menuCustomizeExportLog_Click(object sender, EventArgs e)
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
                dlg.FileName = "opentweaks_log";
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

        private void menuCustomizeExpand_Click(object sender, EventArgs e)
        {
            menuCustomizeExpand.Checked = !(menuCustomizeExpand.Checked);

            tvwAssessments.BeginUpdate();
            if (menuCustomizeExpand.Checked == true)
            {
                tvwAssessments.Nodes[0].ExpandAll();
                tvwAssessments.Nodes[0].EnsureVisible();
            }
            else if (menuCustomizeExpand.Checked == false)
                tvwAssessments.Nodes[0].Collapse();

            tvwAssessments.EndUpdate();
        }

        private void menuCustomizeExportProfile_Click(object sender, EventArgs e)
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

        private void menuCustomizeImportProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Helpers.Strings.Data.DataRootDir;
            f.FileName = "opentweaks_oobeProfile";
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
                                if (!ThemeHelper.AppsUseLightTheme()) treeNode.BackColor = Color.FromArgb(67, 53, 25);
                                else treeNode.BackColor = Color.Yellow;
                                treeNode.Text += "\x20" + "(" + Path.GetFileNameWithoutExtension(f.FileName) + ")";
                                treeNode.Checked = true;
                            }
                        }
                    }
                    MessageBox.Show("Profile has been successfully imported.\n\nWe have highlighted the configuration that would be enabled (no changes are done yet).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rtbPS_LinkClicked(object sender, LinkClickedEventArgs e) => Helpers.Utils.LaunchUri(e.LinkText);

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => MessageBox.Show(lnkSubHeader.Text);

        private void btnCustomizeMenu_Click(object sender, EventArgs e) => this.menuCustomize.Show(Cursor.Position.X, Cursor.Position.Y);

        private void btnCustomizeImport_Click(object sender, EventArgs e) => menuCustomizeImportProfile.PerformClick();

        private void btnCustomizeExportNShare_Click(object sender, EventArgs e) => menuCustomizeExportProfile.PerformClick();
    }
}