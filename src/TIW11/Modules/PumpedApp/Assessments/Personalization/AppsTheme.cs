using Microsoft.Win32;

namespace ThisIsWin11.PumpedApp.Assessment.Personalization
{
    internal class AppsTheme : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Use Apps dark theme";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "AppsUseLightTheme", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "AppsUseLightTheme", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Apps dark theme has been successfully enabled.");
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
                Registry.SetValue(keyName, "AppsUseLightTheme", "1", RegistryValueKind.DWord);
                logger.Log("- Apps light theme has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}