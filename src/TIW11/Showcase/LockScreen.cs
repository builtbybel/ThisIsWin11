using System.Runtime.InteropServices;

namespace ThisIsWin11.Showcase
{
    public class LockScreen
    {
        [DllImport("user32")]
        public static extern bool LockWorkStation();
    }
}