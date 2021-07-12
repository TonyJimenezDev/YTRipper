using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YTRipper
{
    class Utilities
    {
        public const string build = "Debug";
        #region Drag Application
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void MovePanelWinForms(IntPtr handle, MouseEventArgs e_Event)
        {
            if (e_Event.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Bring browser into focus
        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(HandleRef hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr WindowHandle);

        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };
        public static void FocusProcess(string procName)
        {
            Process[] process = Process.GetProcessesByName(procName);
            if (process.Length > 0)
            {
                IntPtr hWnd = IntPtr.Zero;
                for (int i = 0; i < process.Length; i++)
                {
                    hWnd = process[i].MainWindowHandle;
                    ShowWindowAsync(new HandleRef(null, hWnd), Convert.ToInt32(ShowWindowEnum.Maximize));
                    SetForegroundWindow(process[i].MainWindowHandle);
                }

            }
        }
        #endregion
    }
}
