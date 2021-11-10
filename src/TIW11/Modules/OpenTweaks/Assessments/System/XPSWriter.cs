using System.Management.Automation;

namespace ThisIsWin11.OpenTweaks.Assessment.System
{
    internal class XPSWriter : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Remove XPS Documents Writer";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            string script = "Get-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\"";

            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);

            var results = powerShell.Invoke();

            foreach (var item in results)
            {
                var Status = item.Members["State"].Value;

                if (Status.ToString() == "Enabled")
                {
                    logger.Log("XPS Documents Writer is installed.");
                    return true;
                }
            }
            logger.Log("XPS Documents Writer not found.");

            /* if (powerShell.Streams.Error.Count > 0)
             {
                 Console.WriteLine("{0} errors", powerShell.Streams.Error.Count);
             } */

            return false;
        }

        public override bool DoAssessment()
        {
            string script = "Disable-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\" -NoRestart -WarningAction SilentlyContinue | Out-Null";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);
            var results = powerShell.Invoke();

            if (powerShell.Streams.Error.Count > 0)
            {
                logger.Log("XPS Documents Writer not found.");
                return false;
            }

            logger.Log("- XPS Documents Writer has been successfully removed.");
            return true;
        }

        public override bool UndoAssessment()
        {
            string script = "Enable-WindowsOptionalFeature -Online -FeatureName \"Printing-XPSServices-Features\" -NoRestart -WarningAction SilentlyContinue | Out-Null";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);

            var results = powerShell.Invoke();
            if (powerShell.Streams.Error.Count > 0)
            {
                logger.Log("XPS Documents Writer could not be installed.");
                return false;
            }

            logger.Log("- XPS Documents Writer has been successfully installed.");
            return true;
        }
    }
}