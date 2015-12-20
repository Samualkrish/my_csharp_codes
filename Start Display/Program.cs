using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StartDisplay
{
    class Program
    {
        public static int WM_SYSCOMMAND = 0x0112;
        public static int SC_MONITORPOWER = 0xF170;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        static void Main(string[] args)
        {
            int handle = Process.GetCurrentProcess().MainWindowHandle.ToInt32();
            SendMessage(handle, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }
    }
}
