﻿using Microsoft.Win32;
using System;

namespace ThisIsWin11.OpenTweaks.Assessment.Taskbar
{
    internal class TaskView : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Hide Task view button on taskbar";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "ShowTaskViewButton", desiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "ShowTaskViewButton", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Task view button has been disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Task view button {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "ShowTaskViewButton", 1 , RegistryValueKind.DWord);
                logger.Log("- Task view button has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}