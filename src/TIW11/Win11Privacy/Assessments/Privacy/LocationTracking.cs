using Microsoft.Win32;
using System;

namespace ThisIsWin11.Assessment.Privacy
{
    internal class LocationTracking : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string LocationKey = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location";
        private const string DesiredValue = @"Deny";

        public override string ID()
        {
            return "Location tracking";
        }

        public override string Info()
        {
            return "Wherever you go, Windows 11 knows you're there. When Location Tracking is turned on, Windows and its apps are allowed to detect the current location of your computer or device.";
        }

        public override bool CheckAssessment()
        {
            return !(
                  RegistryHelper.StringEquals(LocationKey, "Value", DesiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(LocationKey, "Value", DesiredValue, RegistryValueKind.String);

                logger.Log("- Location tracking has been successfully disabled.");
                logger.Log(LocationKey);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable location tracking {0}", ex.Message); }

            return false;
        }
    }
}