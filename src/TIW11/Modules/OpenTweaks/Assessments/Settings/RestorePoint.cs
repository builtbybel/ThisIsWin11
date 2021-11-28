using System;
using System.Management;

namespace ThisIsWin11.OpenTweaks.Assessment.Settings
{
    internal class RestorePoint : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SystemRestore";
        private const int desiredValue = 1; // Restore Points are enabled

        private static void CreateRestorePoint(string description)
        {
            var oScope = new ManagementScope("\\\\localhost\\root\\default");
            var oPath = new ManagementPath("SystemRestore");
            var oGetOp = new ObjectGetOptions();
            var oProcess = new ManagementClass(oScope, oPath, oGetOp);

            var oInParams =
                oProcess.GetMethodParameters("CreateRestorePoint");
            oInParams["Description"] = description;
            oInParams["RestorePointType"] = 12; // MODIFY_SETTINGS
            oInParams["EventType"] = 100;

            oProcess.InvokeMethod("CreateRestorePoint", oInParams, null);
        }

        public override string ID()
        {
            return $"Create Restore Point ({DateTime.Now})";
        }

        public override string Info()
        {
            return "This will create a Restore Point of your system.";
        }

        public override bool CheckAssessment()
        {
            return !(
            RegistryHelper.IntEquals(keyName, "RPSessionInterval", desiredValue)
          );
        }

        public override bool DoAssessment()
        {
            try
            {
                var restorepointName = $"ThisIsWin11 {DateTime.Now}";
                logger.Log($"Creating restore point {restorepointName} Please wait.");
                CreateRestorePoint(restorepointName);
                logger.Log($"Restore point {restorepointName} successfully created.");

                return true;
            }
            catch (Exception ex)
            {
                logger.Log("- Creating restore point failed. {0}", ex.Message);

                return false;
            }
        }

        public override bool UndoAssessment()
        {
            logger.Log("- Please delete Restore Points from System Restore in Windows 11.\nWe've opened the System Protection page.");
            WindowsHelper.RunCmd("/c SystemPropertiesProtection");
            return false;
        }
    }
}