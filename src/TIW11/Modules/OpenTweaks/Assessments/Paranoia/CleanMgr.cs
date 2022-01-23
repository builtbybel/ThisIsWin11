using System;
using System.IO;

namespace ThisIsWin11.OpenTweaks.Assessment.Paranoia
{
    internal class CleanMgr : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private string curCleaner = @"data\Burnbytes.exe";

        public override string ID()
        {
            return "Run Disk Cleanup";
        }

        public override string Info()
        {
            return "This will run cleanmgr.exe (the modernized version Burnbytes is preferred, if stored in the data folder of this app.)";
        }

        public override bool CheckAssessment()
        {
            return !(
            File.Exists(@"data\Burnbytes.exe")
           );
        }

        public override bool DoAssessment()
        {
            try
            {
                if (File.Exists(curCleaner))
                {
                    logger.Log("- Loading Burnbytes app and calculating how much space you will be able to free...\nPlease wait.");
                    logger.Log("(Press <Clean now> button to clean your system.)");
                    WindowsHelper.ProcStart(curCleaner, "");
                }
                else
                {
                    logger.Log("- Burnbytes app not found. We are cleaning your system with cleanmgr.exe\n\n" +
                                 "Download Burnbytes here: https://github.com/builtbybel/burnbytes\n" +
                                 "and put it to the data folder of this app.\n\n");
                    throw new Exception();
                }
                return true;
            }
            catch
            {
                logger.Log("Running cleanmgr.exe with -verylowdisk parameter in non-interactive mode...");
                WindowsHelper.ProcStart("cleanmgr.exe", "/verylowdisk");
                logger.Log("You have successfully resolved the low disk space condition.");
                return true;
            }
        }

        public override bool UndoAssessment()
        {
            logger.Log("- Nothing to undo here...");
            return false;
        }
    }
}