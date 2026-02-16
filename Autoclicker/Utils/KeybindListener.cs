using System;
using System.Collections.Generic;

namespace Autoclicker.Utils
{
    internal class KeybindListener
    {
        internal static KeybindListener Instance = new KeybindListener();

        private ManagedThread _managedThread;

        private Dictionary<int, bool> _keyStates = new Dictionary<int, bool>();

        private Dictionary<long, Tuple<int, Action>> _keyCallbacks = new Dictionary<long, Tuple<int, Action>>();
        private long _callbackId = 0L;

        private KeybindListener()
        {
            _managedThread = new ManagedThread(10, ExecutionType.Loop);
            _managedThread.OnCallEvent += OnCallEvent;
        }

        ~KeybindListener()
        {
            _managedThread.OnCallEvent -= OnCallEvent;
            _managedThread = null;
        }

        internal long RegisterCallback(int key, Action callback)
        {
            var callbackId = _callbackId++;
            _keyCallbacks[callbackId] = new Tuple<int, Action>(key, callback);
            _keyStates[key] = true;
            return callbackId;
        }

        internal void UnregisterCallback(long callbackId)
        {
            _keyCallbacks.Remove(callbackId);
        }

        private void OnCallEvent(object sender, EventArgs e)
        {
            for (int i = 1; i < 255; i++)
            {
                var lastPressed = _keyStates[i];
                var pressed = (WinApi.GetAsyncKeyState(i) & 0x8000) != 0;

                if (pressed != lastPressed)
                {
                    if (pressed)
                    {
                        foreach (var kv in _keyCallbacks.Values)
                            if (kv.Item1 == i)
                                kv.Item2();
                    }

                    _keyStates[i] = pressed;
                }
            }
        }

        internal void Start()
        {
            for (int i = 1; i < 255; i++)
                _keyStates[i] = (WinApi.GetAsyncKeyState(i) & 0x8000) != 0;

            _managedThread.Start();
            _managedThread.Enable();
        }

        internal void Stop()
        {
            _managedThread.Disable();
            _managedThread.Stop();
        }
    }
}
