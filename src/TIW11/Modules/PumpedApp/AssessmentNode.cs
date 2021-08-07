using System.Windows.Forms;
using ThisIsWin11.PumpedApp.Assessment;

namespace ThisIsWin11.PumpedApp
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