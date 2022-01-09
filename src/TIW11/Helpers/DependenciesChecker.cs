using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    internal class DependenciesChecker
    {
        // Requires Packages module
        public static bool IsWingetInstalled()
        {
            string LocalWindowsAppsDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\WindowsApps\\";
            bool ExecutableExists;
            if (System.IO.File.Exists(LocalWindowsAppsDir + "winget.exe"))
            {
                ExecutableExists = true;
            }
            else
            {
                MessageBox.Show("We could not locate winget on your System.\nPlease install it by clicking on the button above.", "Packages", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ExecutableExists = false;
            }
            return ExecutableExists;
        }

        //public static void WingetInstallPackage(string packageid)
        //{
        //    var proc = new Process
        //    {
        //        StartInfo = new ProcessStartInfo
        //        {
        //            FileName = Strings.Paths.ShellWT,
        //            Arguments = "winget install --id " + packageid + " --accept-source-agreements --accept-package-agreements",
        //            UseShellExecute = false,
        //            CreateNoWindow = false,
        //        }
        //    };

        //    proc.Start();
        //    proc.WaitForExit();
        //}

    }
}