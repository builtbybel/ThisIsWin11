using Microsoft.Win32;
using System;

namespace ThisIsWin11.OpenTweaks.Assessment.Privacy
{
    internal class Advertising : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Advertising ID for Relevant Ads";
        }

        public override string Info()
        {
            return "Windows 11 comes integrated with advertising. Microsoft assigns a unique identificator to track your activity in the Microsoft Store and on UWP apps to target you with relevant ads.";
        }

        public override bool CheckAssessment()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "Enabled", desiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "Enabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Advertising ID for Relevant Ads has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable advertising ID for Relevant Ads {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "Enabled", 1, RegistryValueKind.DWord);
                logger.Log("- Advertising ID for Relevant Ads has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}