using System;
using System.Windows.Forms;

namespace ThisIsWin11
{
    internal static class Program
    {
        internal static string GetCurrentVersionTostring() => new Version(Application.ProductVersion).ToString(4);

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
            else
                Application.Run(new MainWindow());
        }
    }
}