using System;
using System.IO;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    internal class Strings
    {
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
            public const string AssemblyInfo = "https://raw.githubusercontent.com/builtbybel/ThisIsWin11/main/src/TIW11/Properties/AssemblyInfo.cs";
            public const string Twitter = "https://twitter.com/builtbybel";
            public const string Support = "https://www.builtbybel.com/donate";
            public const string Feedback = "https://github.com/builtbybel/ThisIsWin11/issues";
            public const string GitRepo = "https://github.com/builtbybel/ThisIsWin11";
            public const string GitLatest = "https://github.com/builtbybel/ThisIsWin11/releases/latest";
            public const string GitChanges = "https://raw.githubusercontent.com/builtbybel/thisiswin11/main/changes.txt";
        }

        public static class Paths
        {
            public static string WinDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            public static string AppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            public static string SysDir = Path.GetPathRoot(Environment.SystemDirectory);

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