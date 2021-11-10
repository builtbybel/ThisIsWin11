using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.Apps
{
    internal class TrackingApps : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Tracking of app starts";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "Start_TrackProgs", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "Start_TrackProgs", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Tracking of app starts has been successfully disabled.");
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
                Registry.SetValue(keyName, "Start_TrackProgs", 1, RegistryValueKind.DWord);
                logger.Log("- Tracking of app starts has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}