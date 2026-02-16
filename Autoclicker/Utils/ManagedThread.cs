using System;
using System.Threading;

namespace Autoclicker.Utils
{
    internal enum ExecutionType
    {
        Once = 0,
        Loop = 1
    }

    internal class ManagedThread
    {
        internal bool IsRunning { get; private set; }
        internal bool IsEnabled { get; private set; }

        internal int Delay { get; }
        internal ExecutionType ExecutionType { get; }

        internal event EventHandler OnCallEvent;

        internal event EventHandler OnStartEvent;
        internal event EventHandler OnStopEvent;

        internal event EventHandler OnEnableEvent;
        internal event EventHandler OnDisableEvent;

        private Thread _thread;
        private bool _mustRun;
        private bool _lastEnabled;

        internal ManagedThread(int delay, ExecutionType executionType)
        {
            Delay = delay;
            ExecutionType = executionType;
        }

        internal void Start()
        {
            if (IsRunning)
                return;

            _mustRun = true;

            _thread = new Thread(ThreadFunc) { IsBackground = true };
            _thread.Start(this);

            while (IsRunning) Thread.Sleep(1);
        }

        internal void Stop()
        {
            if (!IsRunning)
                return;

            _mustRun = false;

            _thread = null;

            while (!IsRunning) Thread.Sleep(1);
        }

        internal void Enable() => IsEnabled = true;

        internal void Disable() => IsEnabled = false;

        private static void ThreadFunc(object arg)
        {
            var self = (ManagedThread)arg;

            self.IsRunning = true;
            self.OnStartEvent?.Invoke(self, EventArgs.Empty);

            while (self._mustRun)
            {
                try
                {
                    if (self.Delay > 0) Thread.Sleep(self.Delay);

                    if (self.IsEnabled != self._lastEnabled)
                    {
                        if (self.IsEnabled)
                            self.OnEnableEvent?.Invoke(self, EventArgs.Empty);
                        else
                            self.OnDisableEvent?.Invoke(self, EventArgs.Empty);

                        self._lastEnabled = self.IsEnabled;
                    }

                    if (self.IsEnabled)
                        self.OnCallEvent?.Invoke(self, EventArgs.Empty);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"An error occured during thread execution: {ex.Message}");
                }
            }

            self.OnStopEvent?.Invoke(self, EventArgs.Empty);
            self.IsRunning = false;
        }
    }
}
