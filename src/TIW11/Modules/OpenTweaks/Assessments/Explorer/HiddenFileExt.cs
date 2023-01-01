﻿using Microsoft.Win32;
using System;

namespace ThisIsWin11.OpenTweaks.Assessment.Explorer
{
    internal class HiddenFileExt : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Show hidden file name extensions";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "HideFileExt", desiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "HideFileExt", desiredValue, RegistryValueKind.DWord);

                logger.Log("- File name extensions are now visible.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not hide file name extensions {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "HideFileExt", 1, RegistryValueKind.DWord);
                logger.Log("- File name extensions are now hidden again.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}