using System;
using System.Diagnostics;
using System.Web;
using System.Windows.Forms;

namespace ThisIsWin11
{
    internal static class Program
    {
        /// <summary>
        /// Gets App version
        /// </summary>
        internal static string GetCurrentVersionTostring() => new Version(Application.ProductVersion).ToString(3);

        /// <summary>
        /// Sends Crash report to GitHub with exception details
        /// </summary>
        public static void SendCrashReport(Exception ex)
        {
            string header = HttpUtility.UrlEncode(ex.Message);
            string body = $"***ThisIsWin1 {GetCurrentVersionTostring()}***\n\n" +
                          $"**Message**\n{ex.Message}\n\n" +
                          $"**Source**\n{ex.Source}\n\n" +
                          $"**Stack Trace**\n```{ex.StackTrace}```\n\n";

            body = HttpUtility.UrlEncode(body);

            string uri = $"https://github.com/builtbybel/ThisIsWin11/issues/new?labels=crash+report&title={header}&body={body}";
            Process.Start(uri);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] switches)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Command-line switches
            if (switches.Length == 1)
            {
                string arg = switches[0].Trim();

                // GetStarted
                if (arg == "/getstarted")
                {
                    HomeWindow opentweaks = new HomeWindow(null);
                    opentweaks.ShowDialog();
                }

                // OpenTweaks
                if (arg == "/opentweaks")
                {
                    CustomizeWindow opentweaks = new CustomizeWindow();
                    opentweaks.ShowDialog();
                }

                // PumpedApp
                if (arg == "/pumpedapp")
                {
                    AppsWindow pumpedapp = new AppsWindow();
                    pumpedapp.ShowDialog();
                }

                // Packages
                if (arg == "/packages")
                {
                    PackagesWindow packages = new PackagesWindow();
                    packages.ShowDialog();
                }

                // PowerUI
                if (arg == "/powerui")
                {
                    AutomateWindow packages = new AutomateWindow();
                    packages.ShowDialog();
                }
            }
#if !DEBUG
            else
                try
                {
                }
                catch (Exception ex)
                {
                    SendCrashReport(ex);
                    throw;
                }

#endif

            Application.Run(new MainWindow());
        }
    }
}