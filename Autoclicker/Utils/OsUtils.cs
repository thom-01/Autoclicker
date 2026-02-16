using Autoclicker.UI.Forms;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Autoclicker.Utils
{
    internal static class OsUtils
    {
        internal static bool IsLeftClicking()
            => (WinApi.GetAsyncKeyState(1) & 0x8000) != 0;

        internal static bool IsKeyPressed(int key)
            => (WinApi.GetAsyncKeyState(key) & 0x8000) != 0;

        internal static bool IsCursorVisible()
        {
            WinApi.CURSORINFO info;
            info.cbSize = Marshal.SizeOf(typeof(WinApi.CURSORINFO));
            WinApi.GetCursorInfo(out info);

            //TODO: Find a reliable way
            return info.hCursor.ToInt32() == Main.Instance.Cursor.Handle.ToInt32();
        }

        internal static void SendLeftClick(IntPtr hWnd, int delayBefore = 0)
        {
            WinApi.SendMessage(hWnd, 0x201, 0, 0);
            if (delayBefore > 0) Thread.Sleep(delayBefore);
            WinApi.SendMessage(hWnd, 0x202, 0, 0);
        }

        internal static void SendLeftClickDown(IntPtr hWnd, int delayAfter = 0)
        {
            WinApi.SendMessage(hWnd, 0x201, 0, 0);
            if (delayAfter > 0) Thread.Sleep(delayAfter);
        }

        internal static void SendLeftClickUp(IntPtr hWnd, int delayBefore = 0)
        {
            if (delayBefore > 0) Thread.Sleep(delayBefore);
            WinApi.SendMessage(hWnd, 0x202, 0, 0);
        }
    }
}
