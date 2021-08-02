using Microsoft.Win32;

namespace ThisIsWin11.Lucent11.Assessment.Apps
{
    internal class CallHistory : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string AppKey = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\phoneCallHistory";
        private const string DesiredValue = "Deny";

        public override string ID()
        {
            return "App access to call history";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.StringEquals(AppKey, "Value", DesiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(AppKey, "Value", DesiredValue, RegistryValueKind.String);

                logger.Log("- App access to call history has been successfully disabled.");
                logger.Log(AppKey);
                return true;
            }
            catch
            { }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(AppKey, "Value", "Allow", RegistryValueKind.String);
                logger.Log("- App access to call history has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}