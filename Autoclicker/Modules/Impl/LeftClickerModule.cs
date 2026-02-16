using Autoclicker.Utils;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Autoclicker.Modules.Impl
{
    internal class LeftClickerModule : Module
    {
        internal float Cps { get; set; }
        internal bool Exhaust { get; set; }
        internal bool IgnoreInMenus { get; set; }
        internal bool AllowWhileShifting { get; set; }
        internal bool NoHitDelay { get; set; }

        private ManagedThread _thread;

        private bool _first;

        public LeftClickerModule() 
        {
            _thread = new ManagedThread(1, ExecutionType.Loop);
            _thread.OnCallEvent += OnCallEvent;

            _first = true;
        }

        private void OnCallEvent(object sender, EventArgs e)
        {
            if (!MinecraftUtils.IsMinecraftForeground())
                return;

            if (!OsUtils.IsLeftClicking())
            {
                _first = true;
                return;
            }

            if (IgnoreInMenus && (!MinecraftUtils.IsInGame() && (!AllowWhileShifting || !OsUtils.IsKeyPressed((int)Keys.LShiftKey))))
                return;

            var meanTime = 1000.0f / Cps;
            var stdTime = 2.5f;

            var delay = MathUtils.BoxMuller(meanTime, stdTime);

            if (Exhaust)
            {
                if (MathUtils.Random.Next(0, 101) >= 95)
                    delay = (int)(90.0f * MathUtils.Random.NextDouble() + 90.0f);
                else if (MathUtils.Random.Next(0, 101) >= 99)
                    delay = (int)(120.0f * MathUtils.Random.NextDouble() + 120.0f);
            }

            var delayBetween = NoHitDelay ? 1.0f : delay / 2.0f;
            var delayAfter = NoHitDelay ? delay - 1.0f : delay / 2.0f;

            var hWnd = MinecraftUtils.GetMinecraftHwnd();

            if (_first)
            {
                _first = false;
                OsUtils.SendLeftClickUp(hWnd, (int)delayBetween);
            }
            else
            {
                OsUtils.SendLeftClick(hWnd, (int)delayBetween);
            }

            if (delayAfter > 0.0f) Thread.Sleep((int)delayAfter);
        }

        internal override void OnStart()
        {
            _thread.Start();
        }

        internal override void OnStop()
        {
            _thread.Stop();
        }

        internal override void OnEnable()
        {
            _thread.Enable();
        }

        internal override void OnDisable()
        {
            _thread.Disable();
        }
    }
}
