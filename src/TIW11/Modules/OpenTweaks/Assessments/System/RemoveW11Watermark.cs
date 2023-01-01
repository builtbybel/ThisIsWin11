﻿using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.System
{
    internal class RemoveW11Watermark : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Control Panel\UnsupportedHardwareNotificationCache";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Remove Windows 11 System requirements watermark";
        }

        public override string Info()
        {
            return "Microsoft will display with Build 2257 a desktop watermark on devices where Windows 11 is running on unsupported hardware.";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "SV2", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "SV2", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Watermark and the settings notification should be gone.");
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
                var RegKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\UnsupportedHardwareNotificationCache", true);

                RegKey.DeleteValue("SV2");
                logger.Log("- Watermark has been enabled again.");

                return true;
            }
            catch
            { }

            return false;
        }
    }
}