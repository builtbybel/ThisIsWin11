using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.Taskbar
{
    internal class TaskbarSi : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const int desiredValue = 0; 

        public override string ID()
        {
            return "Small Taskbar and icons";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "TaskbarSi", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "TaskbarSi", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Taskbar size has been set to small.\nRestart is required for the changes to take effect!");
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
                Registry.SetValue(keyName, "TaskbarSi", "1", RegistryValueKind.DWord);
                logger.Log("- Taskbar size has been set to default/medium.\nRestart is required for the changes to take effect!");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}