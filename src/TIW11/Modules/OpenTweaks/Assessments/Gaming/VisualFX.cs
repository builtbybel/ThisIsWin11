using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.Gaming
{
    internal class VisualFX : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects";
        private const int desiredValue = 2;

        public override string ID()
        {
            return "Adjust visual effects for best performance";
        }

        public override string Info()
        {
            return "Visual effects are the visual bells and whistles for the appearance of Windows for your account.\n" +
                "These visual bells and whistles can affect the performance of Windows on the PC though.\n" +
                "This will turn off all visual effects under My computer->Properties->Advanced->Settings->and set to \"Adjust for best performance\"";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "VisualFXSetting", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "VisualFXSetting", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Visual effects has been optimized.");
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
                Registry.SetValue(keyName, "VisualFXSetting", 0, RegistryValueKind.DWord);

                logger.Log("- Visual effects has been set to default choosing Windows choose what's best for your computer.");
                logger.Log(keyName);
                return true;
            }
            catch
            { }

            return false;
        }
    }
}