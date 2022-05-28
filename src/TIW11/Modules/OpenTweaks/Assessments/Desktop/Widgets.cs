using Microsoft.Win32;
using System;

namespace ThisIsWin11.OpenTweaks.Assessment.Desktop
{
    internal class Widgets : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Disable Widgets";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "TaskbarDa", desiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "TaskbarDa", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Widgets has been disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Widgets {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "TaskbarDa", 1, RegistryValueKind.DWord);
                logger.Log("- Widgets has been enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}