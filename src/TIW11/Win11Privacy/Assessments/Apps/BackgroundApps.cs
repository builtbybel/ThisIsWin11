using Microsoft.Win32;

namespace ThisIsWin11.Assessment.Apps
{
    internal class BackgroundApps : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string AppKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications";
        private const int DesiredValue = 1;

        public override string ID()
        {
            return "Apps running in background";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(AppKey, "GlobalUserDisabled", DesiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(AppKey, "GlobalUserDisabled", DesiredValue, RegistryValueKind.DWord);

                logger.Log("- App access to running in background has been successfully disabled.");
                logger.Log(AppKey);
                return true;
            }
            catch
            { }

            return false;
        }

    }
}