using System.Management.Automation;

namespace ThisIsWin11.OpenTweaks.Assessment.System
{
    internal class EnableWSL : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Enable Microsoft Windows Subsystem for Linux";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            string script = "Get-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);
            var results = powerShell.Invoke();

            foreach (var item in results)
            {
                var Status = item.Members["State"].Value;

                if (Status.ToString() == "Enabled")
                {
                    logger.Log("Microsoft Windows Subsystem for Linux is already enabled.");
                    return false;
                }
            }
            logger.Log("Microsoft Windows Subsystem for Linux is disabled.");

            return true;
        }

        public override bool DoAssessment()
        {
            string script = "Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux";

            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            logger.Log("- Microsoft Windows Subsystem for Linux has been successfully enabled.");
            return true;
        }

        public override bool UndoAssessment()
        {
            string script = "Disable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux";

            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            logger.Log("- Microsoft Windows Subsystem for Linux has been successfully disabled.");
            return true;
        }
    }
}