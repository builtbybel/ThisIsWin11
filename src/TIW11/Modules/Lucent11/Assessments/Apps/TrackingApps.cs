using Microsoft.Win32;

namespace ThisIsWin11.Lucent11.Assessment.Apps
{
    internal class TrackingApps : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string AppKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int DesiredValue = 0;

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
               RegistryHelper.IntEquals(AppKey, "Start_TrackProgs", DesiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(AppKey, "Start_TrackProgs", DesiredValue, RegistryValueKind.DWord);

                logger.Log("- Tracking of app starts has been successfully disabled.");
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
                Registry.SetValue(AppKey, "Start_TrackProgs", 1, RegistryValueKind.DWord);
                logger.Log("- Tracking of app starts has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}