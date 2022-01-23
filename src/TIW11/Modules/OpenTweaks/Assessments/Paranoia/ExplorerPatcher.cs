using System;
using System.IO;
using System.Net;

namespace ThisIsWin11.PumpedApp.Assessment.ThirdParty
{
    internal class ExplorerPatcher : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private const string configIcons = @"/c %windir%\explorer.exe shell:::{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9}\SystemIcons";

        public override string ID()
        {
            return "Enable classic Taskbar with https://github.com/valinet/ExplorerPatcher";
        }

        public override string Info()
        {
            return "This third-party tool will hack a Windows 10 taskbar back into Windows 11";
        }

        public override bool CheckAssessment()
        {
            return !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\dxgi.dll");
        }

        public override bool DoAssessment()
        {
            try
            {
                using (var client = new WebClient())
                {
                    //download ExplorerPatcher
                    logger.Log("- Downloading ExplorerPatcher from https://github.com/valinet/ExplorerPatcher");
                    client.DownloadFile("https://github.com/builtbybel/ThisIsWin11/blob/main/collections/third-party/dxgi.dll", "data\\dxgi.dll");

                    //patching
                    logger.Log("- Patching Explorer");
                    File.Move("data\\dxgi.dll", Helpers.Strings.Paths.WinDir + "\\dxgi.dll");

                    WindowsHelper.RunCmd("/c taskkill /f /im explorer.exe");
                    WindowsHelper.RunCmd("/c start explorer.exe");

                    logger.Log("INFO: Once File Explorer restarts, some necessary files (symbol files) will be downloaded from Microsoft (around 50MB)." +
                                "\nThis should be relatively quick, depending on your Internet connection speed.");

                    logger.Log("\nAs you have noticed, some system tray icons are missing (e.g. clock, sound etc.)\nWe've opened a window where you can enable your icons.");
                    WindowsHelper.RunCmd(configIcons);

                    logger.Log("\n- Done.\nA big shout out to https://github.com/valinet\n\n" +
                                          "How-to configure: https://github.com/valinet/ExplorerPatcher#configuration-interface");

                    return true;
                }
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                //unpatching
                logger.Log("- Uninstalling ExplorePatcher");
                File.Move(Helpers.Strings.Paths.WinDir + "\\dxgi.dll", Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\dxgio.dll");

                WindowsHelper.RunCmd("/c taskkill /f /im explorer.exe");
                WindowsHelper.RunCmd("/c start explorer.exe");

                File.Delete(Helpers.Strings.Paths.WinDir + "\\dxgio.dll");

                logger.Log("\n- Done.\nDeleting %appdata%\\ExplorerPatcher directory as well.");
                Directory.Delete(Helpers.Strings.Paths.AppDataDir + "\\ExplorerPatcher", true);

                return true;
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }
    }
}