using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.Taskbar
{
    internal class TaskbarAl : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0; //left

        public override string ID()
        {
            return "Align Taskbar to left";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "TaskbarAl", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "TaskbarAl", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Taskbar alignment has been set to left.");
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
                Registry.SetValue(keyName, "TaskbarAl", "1", RegistryValueKind.DWord);
                logger.Log("- Taskbar alignment has been set to middle.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}