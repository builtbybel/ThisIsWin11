using System.Management.Automation;

namespace ThisIsWin11.OpenTweaks.Assessment.System
{
    internal class HyperV : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "Enable Microsoft Hyper-V";
        }

        public override string Info()
        {
            return "Allows the creation of virtual machines.\nE.g., it is also a requirement for Windows Subsystem for Linux and Android.";
        }

        public override bool CheckAssessment()
        {
            
            string script = "Get-WindowsOptionalFeature -Online -FeatureName Microsoft-Hyper-V";
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript(script);
            var results = powerShell.Invoke();

            foreach (var item in results)
            {
                var Status = item.Members["State"].Value;

                if (Status.ToString() == "Enabled")
                {
                    logger.Log("Microsoft-Hyper-V is already enabled.");
                    return false;

                }
            }
            logger.Log("Microsoft-Hyper-V is disabled.");
         
            return true;
        }

        public override bool DoAssessment()
        {
            string script = "Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Hyper-V";

            logger.Log("Please wait.");
            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            logger.Log("- Microsoft Hyper-V has been successfully enabled.\nA restart is required for the changes to take effect.");
            return true;
        }

        public override bool UndoAssessment()
        {
            string script = "Disable-WindowsOptionalFeature -Online -FeatureName Microsoft-Hyper-V";
            logger.Log("Please wait.");
            PowerShell powerShell = PowerShell.Create();

            powerShell.AddScript(script);
            powerShell.Invoke();

            logger.Log("- Microsoft Hyper-V has been successfully disabled.\nA restart is required for the changes to take effect.");
            return true;
        }
    }
}