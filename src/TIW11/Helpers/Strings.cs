using System;
using System.IO;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    internal class Strings
    {
        public static readonly string TweetIntent = "https://twitter.com/intent/tweet?text=" +
                                            "This%20is%20a%20%23Windows11%20feature!%20Checked%20with%20%23ThisIsWin11%20%23app";

        public static class Data
        {
            public static string DataRootDir = Application.StartupPath +
                                                @"\data\";

            public static string PackagesRootDir = Application.StartupPath +
                                                @"\data\packages\";

            public static string PackagesLogsDir = Application.StartupPath +
                                                @"\data\packages\logs\";
        }

        public static class Uri
        {
            public const string GitRepo = "https://github.com/builtbybel/ThisIsWin11";
            public const string Twitter = "https://twitter.com/builtbybel";
            public const string Donate = "https://www.builtbybel.com/donate";
            public const string GitUpdateRepo = "https://github.com/builtbybel/thisiswin11/releases/tag/";
            public const string GitVersionCheck = "https://raw.githubusercontent.com/builtbybel/thisiswin11/master/appversion.txt";
            public const string GitVersionHint = "https://raw.githubusercontent.com/builtbybel/thisiswin11/main/changes.txt";
        }

        public static class Paths
        {
            public static string SysDir = Path.GetPathRoot(Environment.SystemDirectory);

            public static string ShellCommandPrompt = File.Exists(SysDir + @"Windows\Sysnative\cmd.exe") ?
                                                      SysDir + @"Windows\Sysnative\cmd.exe" : SysDir + @"Windows\System32\cmd.exe";

            public static string System32Location = File.Exists(SysDir + @"Windows\Sysnative\cmd.exe") ?
                                                    SysDir + @"Windows\Sysnative\" : SysDir + @"Windows\System32\";
        }
    }
}