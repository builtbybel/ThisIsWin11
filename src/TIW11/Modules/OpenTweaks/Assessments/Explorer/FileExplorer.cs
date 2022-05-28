using Microsoft.Win32;

namespace ThisIsWin11.OpenTweaks.Assessment.Explorer
{
    internal class FileExplorer : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";

        public override string ID()
        {
            return "Enable Windows 10 File Explorer";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.StringEquals(keyName, "{e2bf9676-5f8f-435c-97eb-11607a5bedf7}", "")
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "{e2bf9676-5f8f-435c-97eb-11607a5bedf7}", "", RegistryValueKind.String);

                logger.Log("- Windows 10 File Explorer has been successfully enabled.\nRestart is required for the changes to take effect!");
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
                var RegKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked", true);
                RegKey.DeleteValue("{e2bf9676-5f8f-435c-97eb-11607a5bedf7}");

                logger.Log("- Windows 10 File Explorer has been successfully disabled.\nRestart is required for the changes to take effect!");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}