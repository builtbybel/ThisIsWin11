using Microsoft.Win32;
using System;

namespace ThisIsWin11.Showcase
{
    public class OS
    {
        public string ComputerName { get; set; }

        public bool IsWin11()
        {
            ComputerName = Environment.MachineName;

            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
                int osbuild = Convert.ToInt32(key.GetValue("CurrentBuildNumber"));
                if (osbuild >= 22000)
                {
                    return true;
                }
            }
            catch { }
            return false;
        }

        public string GetVersion()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            var UBR = key.GetValue("UBR").ToString();
            var CurrentBuild = key.GetValue("CurrentBuild").ToString();

            string version = CurrentBuild + "." + UBR;

            return "Build " + version;
        }

        public string Is64Bit()
        {
            string bitness = string.Empty;

            if (Environment.Is64BitOperatingSystem)
            {
                bitness = "64bit";
            }
            else
            {
                bitness = "32bit";
            }

            return bitness;
        }
    }
}