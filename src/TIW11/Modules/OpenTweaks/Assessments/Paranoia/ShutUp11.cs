using System;
using System.IO;

namespace ThisIsWin11.OpenTweaks.Assessment.Paranoia
{
    internal class ShutUp11 : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private static string OOSU10 = Helpers.Strings.Data.DataRootDir + "OOSU10.exe";
        private static string OOSU10CFG = Helpers.Strings.Data.DataRootDir + "ooshutup10.cfg";

        public override string ID()
        {
            return "Automate O&O ShutUp10++";
        }

        public override string Info()
        {
            return "This app provide only the GUI for a third-party configuration file.";
        }

        public override bool CheckAssessment()
        {
            logger.Log("Usage of " + ID() +
                       "\n1. Download the application at https://www.oo-software.com/shutup10" +
                       "\n2. Export your configuration as ooshutup10.cfg" +
                       "\n3. Put both (app + configuration file) to \"Data\" folder of TIW11."
                       );
            return (File.Exists(OOSU10) && File.Exists(OOSU10CFG)
               );
        }

        public override bool DoAssessment()
        {
            try
            {
                logger.Log("Applying O&O ShutUp10++ configuration...");
                WindowsHelper.ProcStart(OOSU10, OOSU10CFG + " /quiet");

                return true;
            }
            catch (Exception ex)
            { logger.Log("O&O ShutUp10++ not found. {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            logger.Log("Revert your changes in O&O ShutUp10++");
            return true;
        }
    }
}