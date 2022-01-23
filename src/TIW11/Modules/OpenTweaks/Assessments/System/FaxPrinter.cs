using System.Management.Automation;

namespace ThisIsWin11.OpenTweaks.Assessment.System
{
    internal class Fax : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Remove Fax Printer";
        }

        public override string Info()
        {
            return "This operation cannot be undone!";
        }

        public override bool CheckAssessment()
        {
            logger.Log("Fax Printer check can not be performed, but we can remove it.");
            return false;
        }

        public override bool DoAssessment()
        {
            string script = "Remove-Printer -Name \"Fax\"";

            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            if (powerShell.Streams.Error.Count > 0)
            {
                logger.Log("Fax Printer not found.");
                return false;
            }

            logger.Log("- Fax printer has been successfully removed.");
            return true;
        }

        public override bool UndoAssessment()
        {
            logger.Log("- Fax printer can not be installed.");
            return false;
        }
    }
}