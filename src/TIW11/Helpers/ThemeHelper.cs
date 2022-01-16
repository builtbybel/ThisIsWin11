using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public class ThemeHelper
    {
        // Dark theme
        public static Color DarkBackgroundColor = Color.FromArgb(32, 32, 32);

        public static Color DarkForgroundColor = Color.FromArgb(204, 204, 204);
        public static Color DarkForgroundColorful = Color.FromArgb(255, 148, 238);

        public static Color DarkMouseOverBackColor = Color.HotPink;

        // Light theme
        public static Color LightBackgroundColor = Color.White;

        public static Color LightForgroundColor = Color.Black;
        public static Color LightForegroundControl = Color.FromArgb(64, 64, 64);
        public static Color LightForgroundColorful = Color.DimGray;

        public static Color LightkMouseOverBackColor = Color.WhiteSmoke;

        // Get default Windows 11 theme
        public static bool AppsUseLightTheme()
        {
            bool AppsUseLightTheme = true;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null && key.GetValue("AppsUseLightTheme") != null)
                    {
                        Int64 value = Convert.ToInt64(key.GetValue("AppsUseLightTheme").ToString());
                        if (value == 0)
                            AppsUseLightTheme = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AppsUseLightTheme");
            }

            if (AppsUseLightTheme)

                return true;
            else

                return false;
        }
    }
}