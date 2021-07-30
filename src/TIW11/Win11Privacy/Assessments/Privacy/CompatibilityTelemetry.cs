using Microsoft.Win32;
using System;

namespace ThisIsWin11.Assessment.Privacy
{
    internal class CompatibilityTelemetry : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string TelemetryKey = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\CompatTelRunner.exe";
        private const string DesiredValue = @"%windir%\System32\taskkill.exe";

        public override string ID()
        {
            return "Compatibility Telemetry";
        }

        public override string Info()
        {
            return "This process is periodically collecting a variety of technical data about your computer and its performance and sending it to Microsoft for its Windows Customer Experience Improvement Program.";
        }

        public override bool CheckAssessment()
        {
            return !(
          RegistryHelper.StringEquals(TelemetryKey, "Debugger", DesiredValue)
           );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(TelemetryKey, "Debugger", DesiredValue, RegistryValueKind.String);
                logger.Log("- Compatibility Telemetry has been successfully disabled.");
                logger.Log(TelemetryKey);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable compatibility telemetry: {0}", ex.Message); }

            return false;
        }
    }
}