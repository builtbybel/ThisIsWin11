using System;
using System.IO;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    internal class Strings
    {
        public static readonly string TweetIntent = "https://twitter.com/intent/tweet?text=Try%20the%20new%20%23ThisIsWin11%20app%20and%20personalize%20%23Windows11%20and%20streamline%20it%20to%20your%20liking.%0a%0ahttps://github.com/builtbybel/ThisIsWin11";

        public static class Data
        {
            public static string DataRootDir = Application.StartupPath +
                                                @"\data\";

            public static string ScriptsRootDir = Application.StartupPath +
                                                @"\data\scripts\";

            public static string ScriptsLogsDir = Application.StartupPath +
                                                @"\data\scripts\logs\";
        }

        public static class Uri
        {
            public const string URL_ASSEMBLY = "https://raw.githubusercontent.com/builtbybel/ThisIsWin11/main/src/TIW11/Properties/AssemblyInfo.cs";
            public const string URL_TWITTER = "https://twitter.com/builtbybel";
            public const string URL_DONATE = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=donate@builtbybel.com&lc=US&item_name=%20Builtbybel&no_note=0&cn=&currency_code=USD&bn=PP-DonationsBF:btn_donateCC_LG.gif:NonHosted";
            public const string URL_GITREPO = "https://github.com/builtbybel/ThisIsWin11";
            public const string URL_FEEDBACK = URL_GITREPO + "/issues";
            public const string URL_GITLATEST = URL_GITREPO +"/releases/latest";
            public const string URL_GITCHANGELOG = "https://raw.githubusercontent.com/builtbybel/thisiswin11/main/changes.txt";
            public const string URL_POWERUIPLUGS = "https://github.com/builtbybel/ThisIsWin11/tree/main/src/TIW11/Resources/data/plugins";
        }

        public static class Paths
        {
            public static string SysDir = Path.GetPathRoot(Environment.SystemDirectory);
            public static string WinDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            public static string AppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            public static string LocalAppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            public static string ShellWT = File.Exists(LocalAppDataDir + @"\Microsoft\WindowsApps\wt.exe") ?
                                                      LocalAppDataDir + @"\Microsoft\WindowsApps\wt.exe" : LocalAppDataDir + @"\Microsoft\WindowsApps\wt.exe";

            public static string ShellCommandPrompt = File.Exists(SysDir + @"Windows\Sysnative\cmd.exe") ?
                                                      SysDir + @"Windows\Sysnative\cmd.exe" : SysDir + @"Windows\System32\cmd.exe";

            public static string ShellPS = File.Exists(SysDir + @"Windows\Sysnative\WindowsPowerShell\v1.0\powershell.exe") ?
                                                       SysDir + @"Windows\Sysnative\WindowsPowerShell\v1.0\powershell.exe" : SysDir + @"Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
        }

        // Create data directory if non present
        public static void CreateDataDir()
        {
            bool dirExists = Directory.Exists(@"data");
            if (!dirExists)
                Directory.CreateDirectory(@"data");
        }
    }
}