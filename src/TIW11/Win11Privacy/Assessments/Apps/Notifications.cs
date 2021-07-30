using Microsoft.Win32;

namespace ThisIsWin11.Assessment.Apps
{
    internal class Notifications : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string AppKey = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\userNotificationListener";
        private const string DesiredValue = "Deny";

        public override string ID()
        {
            return "App access to notifications";
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

                logger.Log("- App access to notifications has been successfully disabled.");
                logger.Log(AppKey);
                return true;
            }
            catch
            { }

            return false;
        }

    }
}