﻿using Microsoft.Win32;
using System;

namespace ThisIsWin11.OpenTweaks.Assessment.Desktop
{
    internal class SnapAssistFlyout : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Disable Snap Assist";
        }

        public override string Info()
        {
            return "When you hover over the maximize button in apps, this feature gives you a flyout to display possible layouts.";
        }

        public override bool CheckAssessment()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "EnableSnapAssistFlyout", desiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "EnableSnapAssistFlyout", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Snap Assist Layout has been disabled.\nPlease restart your PC for the changes to take effect.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Snap Assist {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "EnableSnapAssistFlyout", 1, RegistryValueKind.DWord);
                logger.Log("- Snap Assist has been enabled.\nPlease restart your PC for the changes to take effect.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}