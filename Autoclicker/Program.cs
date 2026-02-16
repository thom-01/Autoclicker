using Autoclicker.Modules.Impl;
using Autoclicker.Utils;
using System;
using System.Windows.Forms;

namespace Autoclicker
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            WinApi.TimeBeginPeriod(1u);

            KeybindListener.Instance.Start();
            ModuleManager.Instance.StartModules();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(UI.Forms.Main.Instance);

            KeybindListener.Instance.Stop();
            ModuleManager.Instance.StopModules();

            WinApi.TimeEndPeriod(1u);
        }
    }
}
