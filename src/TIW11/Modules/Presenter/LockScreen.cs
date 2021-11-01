using System.Runtime.InteropServices;

namespace ThisIsWin11.Presenter
{
    public class LockScreen
    {
        [DllImport("user32")]
        public static extern bool LockWorkStation();
    }
}