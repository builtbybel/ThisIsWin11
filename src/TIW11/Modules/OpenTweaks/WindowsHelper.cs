using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using ThisIsWin11.OpenTweaks;

namespace ThisIsWin11
{
    public static class WindowsHelper
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public static void IsServiceRunning(string service)
        {
            logger.Log($"Check if {service} service is running");
            RunCmd($"/c sc query {service} | find \"RUNNING\"");
        }

        public static void DisableService(string service)
        {
            RunCmd($"/c net stop {service}");
            ProcStart("powershell", $"-command \"Set-Service -Name {service} -StartupType disabled\"");
            logger.Log($"Disable {service} service");
        }

        public static void EnableService(string service)
        {
            RunCmd($"/c net start {service}");
            ProcStart("powershell", $"-command \"Set-Service -Name {service} -StartupType auto\"");
            logger.Log($"Enable {service} service");
        }

        public static void RunCmd(string args)
        {
            ProcStart(Helpers.Strings.Paths.ShellCommandPrompt, args);
        }

        public static void ProcStart(string name, string args)
        {
            try
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = name,
                        Arguments = args,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage),
                        CreateNoWindow = true
                    }
                };
                proc.Start();
                string line = null;
                while (!proc.StandardOutput.EndOfStream)
                {
                    line += Environment.NewLine + proc.StandardOutput.ReadLine();
                }
                proc.WaitForExit();
                logger.Log($"{name} {args} {line}");
            }
            catch (Exception ex)
            {
                logger.Log($"Could not start {name} {args}. Exception: {ex}");
            }
        }
    }
}