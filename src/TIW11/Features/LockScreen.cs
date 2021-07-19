using System.Runtime.InteropServices;

namespace ThisIsWin11.Features
{
    public class LockScreen
    {
        [DllImport("user32")]
        public static extern bool LockWorkStation();
    }
}