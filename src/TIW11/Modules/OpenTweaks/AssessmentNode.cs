using System.Windows.Forms;
using ThisIsWin11.OpenTweaks.Assessment;

namespace ThisIsWin11.OpenTweaks
{
    internal class AssessmentNode : TreeNode
    {
        public AssessmentBase Assessment { get; }

        public AssessmentNode(AssessmentBase assessment)
        {
            Assessment = assessment;
            Text = Assessment.ID();
            ToolTipText = Assessment.Info();
            Checked = true;
        }
    }
}