using Microsoft.Win32;
using System;

namespace ThisIsWin11.Lucent11.Assessment.Privacy
{
    internal class Biometrics : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string BiometricsKey = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Biometrics";
        private const int DesiredValue = 0;

        public override string ID()
        {
            return "Windows Hello Biometrics";
        }

        public override string Info()
        {
            return "Windows Hello biometrics lets you sign in to your devices, apps, online services, and networks using your face, iris, or fingerprint.";
        }

        public override bool CheckAssessment()
        {
            return !(
             RegistryHelper.IntEquals(BiometricsKey, "Enabled", DesiredValue)
           );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(BiometricsKey, "Enabled", DesiredValue, RegistryValueKind.DWord);

                logger.Log("- Windows Hello Biometrics has been successfully disabled.");
                logger.Log(BiometricsKey);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Windows Hello Biometrics { 0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(BiometricsKey, "Enabled", 1, RegistryValueKind.DWord);
                logger.Log("- Windows Hello Biometrics has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}