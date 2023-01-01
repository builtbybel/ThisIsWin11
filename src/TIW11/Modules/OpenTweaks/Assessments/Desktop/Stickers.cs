using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.Desktop
{
    internal class Stickers : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\current\device\Stickers";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "Enable Desktop Stickers";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "EnableStickers", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "EnableStickers", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Desktop Stickers has been enabled (ONLY available in 22H2 Build 22621 and higher).");
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
                Registry.SetValue(keyName, "EnableStickers", "0", RegistryValueKind.DWord);
                logger.Log("- Desktop Sticker feature has been disabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}