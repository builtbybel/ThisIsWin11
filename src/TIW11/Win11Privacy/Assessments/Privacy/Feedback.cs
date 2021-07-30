using Microsoft.Win32;
using System;

namespace ThisIsWin11.Assessment.Privacy
{
    internal class Feedback : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string PeriodInNanoSeconds = @"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules";
        private const string NumberOfSIUFInPeriod = @"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules";
        private const int DesiredValue = 0;

        public override string ID()
        {
            return "Feedback notifications";
        }

        public override string Info()
        {
            return "Windows 11 may also pop up from time to time and ask for feedback.";
        }

        public override bool CheckAssessment()
        {
            return !(
                   RegistryHelper.IntEquals(PeriodInNanoSeconds, "PeriodInNanoSeconds", DesiredValue) &&
                    RegistryHelper.IntEquals(NumberOfSIUFInPeriod, "NumberOfSIUFInPeriod", DesiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(PeriodInNanoSeconds, "PeriodInNanoSeconds", DesiredValue, RegistryValueKind.DWord);
                Registry.SetValue(NumberOfSIUFInPeriod, "NumberOfSIUFInPeriod", DesiredValue, RegistryValueKind.DWord);

                logger.Log("- Feedback has been successfully disabled.");
                logger.Log(PeriodInNanoSeconds + Environment.NewLine + NumberOfSIUFInPeriod);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Feedback {0}", ex.Message); }

            return false;
        }
    }
}