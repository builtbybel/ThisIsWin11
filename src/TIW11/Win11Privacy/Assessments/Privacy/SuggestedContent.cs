using Microsoft.Win32;
using System;

namespace ThisIsWin11.Lucent11.Assessment.Privacy
{
    internal class SuggestedContent : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string ContentKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string ContentKey2 = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string ContentKey3 = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const int DesiredValue = 0;

        public override string ID()
        {
            return "Suggested content in Settings app";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
                 RegistryHelper.IntEquals(ContentKey, "SubscribedContent-338393Enabled", DesiredValue) &&
                 RegistryHelper.IntEquals(ContentKey2, "SubscribedContent-353694Enabled", DesiredValue) &&
                 RegistryHelper.IntEquals(ContentKey3, "SubscribedContent-353696Enabled", DesiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(ContentKey, "SubscribedContent-338393Enabled", DesiredValue, RegistryValueKind.DWord);
                Registry.SetValue(ContentKey2, "SubscribedContent-353694Enabled", DesiredValue, RegistryValueKind.DWord);
                Registry.SetValue(ContentKey3, "SubscribedContent-353696Enabled", DesiredValue, RegistryValueKind.DWord);

                logger.Log("- Suggested content in Settings app has been successfully disabled.");
                logger.Log(ContentKey);
                return true;

            }
            catch (Exception ex)
            { logger.Log("Could not disable suggested content in Settings app {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(ContentKey, "SubscribedContent-338393Enabled", 1, RegistryValueKind.DWord);
                Registry.SetValue(ContentKey2, "SubscribedContent-353694Enabled", 1, RegistryValueKind.DWord);
                Registry.SetValue(ContentKey3, "SubscribedContent-353696Enabled", 1, RegistryValueKind.DWord);

                logger.Log("- Suggested content in Settings app has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}