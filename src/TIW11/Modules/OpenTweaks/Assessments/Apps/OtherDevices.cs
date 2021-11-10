using Microsoft.Win32;
using System;

namespace ThisIsWin11.OpenTweaks.Assessment.Apps
{
    internal class OtherDevices : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\bluetooth";
        private const string keyName2 = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\bluetoothSync";
        private const string desiredValue = "Deny";

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
               RegistryHelper.StringEquals(keyName, "Value", desiredValue) &&
               RegistryHelper.StringEquals(keyName2, "Value", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "Value", desiredValue, RegistryValueKind.String);
                Registry.SetValue(keyName2, "Value", desiredValue, RegistryValueKind.String);

                logger.Log("- App access to other devices has been successfully disabled.");
                logger.Log(keyName + Environment.NewLine + keyName2);
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
                Registry.SetValue(keyName, "Value", "Allow", RegistryValueKind.String);
                Registry.SetValue(keyName2, "Value", "Allow", RegistryValueKind.String);
                logger.Log("- App access to other devices has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}