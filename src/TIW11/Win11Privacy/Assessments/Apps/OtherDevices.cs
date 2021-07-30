using Microsoft.Win32;
using System;

namespace ThisIsWin11.Assessment.Apps
{
    internal class OtherDevices : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string AppKey = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\bluetooth";
        private const string AppKey2 = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\bluetoothSync";
        private const string DesiredValue = "Deny";

        public override string ID()
        {
            return "App access to other devices";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.StringEquals(AppKey, "Value", DesiredValue) &&
               RegistryHelper.StringEquals(AppKey2, "Value", DesiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(AppKey, "Value", DesiredValue, RegistryValueKind.String);
                Registry.SetValue(AppKey2, "Value", DesiredValue, RegistryValueKind.String);

                logger.Log("- App access to other devices has been successfully disabled.");
                logger.Log(AppKey + Environment.NewLine + AppKey2);
                return true;
            }
            catch
            { }

            return false;
        }

    }
}