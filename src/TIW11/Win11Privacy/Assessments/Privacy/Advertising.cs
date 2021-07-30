using Microsoft.Win32;
using System;

namespace ThisIsWin11.Assessment.Privacy
{
    internal class Advertising : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string AdsKey = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo";
        private const int DesiredValue = 0;

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
                 RegistryHelper.IntEquals(AdsKey, "Enabled", DesiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(AdsKey, "Enabled", DesiredValue, RegistryValueKind.DWord);

                logger.Log("- Advertising ID for Relevant Ads has been successfully disabled.");
                logger.Log(AdsKey);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Advertising ID for Relevant Ads {0}", ex.Message); }

            return false;
        }
    }
}