using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers

{
    // Ref. https://docs.microsoft.com/de-de/dotnet/api/system.windows.forms.sendkeys?view=net-5.0
    public static class Keystrokes

    {
        public static void Send(string keys, bool wait)

        {
            WshShell shell = new WshShell();

            object wObj = wait;

            shell.SendKeys(keys, ref wObj);
        }

        public static void Send(string keys)

        {
            Send(keys, false);
        }

        public static void SendWait(string keys)

        {
            Send(keys, true);
        }
    }

    /// <summary>
    /// As CTRL+ESC does not simulate the WIN key, here som P/Invoke
    /// </summary>
    internal static class WKeystrokes
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