using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public class ThemeHelper
    {
        // Dark theme
        public static Color DarkBackgroundColorNav = Color.FromArgb(21, 21, 21);
        public static Color DarkForgroundColorNav = Color.White;
        public static Color DarkMouseOverBackColorNav = Color.FromArgb(238, 125, 195);

        public static Color DarkBackgroundColor = Color.FromArgb(32, 32, 32);
        public static Color DarkBackgroundContrast = Color.FromArgb(45, 45, 45);

        public static Color DarkForgroundColor = Color.FromArgb(230, 230, 230);
        public static Color DarkForgroundAccent = Color.FromArgb(255, 148, 238);

        public static Color DarkMouseOverBackColor = Color.HotPink;

        // Light theme
        public static Color LightBackgroundColorNav = Color.White;
        public static Color LightForgroundColorNav = Color.Black;
        public static Color LightMouseOverBackColorNav = Color.FromArgb(238, 125, 195);

        public static Color LightBackgroundColor = Color.White;
        public static Color LightBackgroundContrast = Color.Gainsboro;
        public static Color LightBackgroundButtonContrast = Color.White;

        public static Color LightForgroundColor = Color.Black;
        public static Color LightForegroundContrast = Color.FromArgb(64,64,64);
        public static Color LightForgroundAccent = Color.DimGray;

        public static Color LightMouseOverBackColor = Color.WhiteSmoke;

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
            {
                return true;
            }
            else

                return false;
        }
    }
}