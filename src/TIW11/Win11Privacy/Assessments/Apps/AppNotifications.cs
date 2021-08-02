using Microsoft.Win32;

namespace ThisIsWin11.Lucent11.Assessment.Apps
{
    internal class AppNotifications : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string AppKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PushNotifications";
        private const int DesiredValue = 0;

        public override string ID()
        {
            return "App notifications";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(AppKey, "ToastEnabled", DesiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(AppKey, "ToastEnabled", DesiredValue, RegistryValueKind.DWord);

                logger.Log("- App notifications has been successfully disabled.");
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
                Registry.SetValue(AppKey, "ToastEnabled", "1", RegistryValueKind.DWord);
                logger.Log("- App notifications has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}