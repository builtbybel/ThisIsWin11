using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.Apps
{
    internal class AppNotifications : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PushNotifications";
        private const int desiredValue = 0;

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
               RegistryHelper.IntEquals(keyName, "ToastEnabled", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "ToastEnabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- App notifications has been successfully disabled.");
                logger.Log(keyName);
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
                Registry.SetValue(keyName, "ToastEnabled", "1", RegistryValueKind.DWord);
                logger.Log("- App notifications has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}