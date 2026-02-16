using System;

namespace Autoclicker.Utils
{
    internal static class MinecraftUtils
    {
        internal static bool IsMinecraftForeground()
        {
            var foregroundhWnd = WinApi.GetForegroundWindow();

            return foregroundhWnd == WinApi.FindWindow("LWJGL", null)
                || foregroundhWnd == WinApi.FindWindow("GLFW30", null);
        }

        internal static bool IsInGame()
        {
            return !OsUtils.IsCursorVisible();
        }

        internal static IntPtr GetMinecraftHwnd()
        {
            var foregroundhWnd = WinApi.GetForegroundWindow();

            return IsMinecraftForeground()
                ? foregroundhWnd
                : IntPtr.Zero;
        }
    }
}
