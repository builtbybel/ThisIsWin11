using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers

{
    //ref. https://docs.microsoft.com/dotnet/api/system.windows.forms.sendkeys?view=net-5.0

    //as CTRL+ESC does not simulate the WIN key, here som P/Invoke
    internal static class Keystrokes
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 2;

        public static void KeyDown(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
        }

        public static void KeyUp(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}