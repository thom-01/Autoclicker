using Autoclicker.Modules.Impl;
using Autoclicker.Utils;
using System;
using System.Windows.Forms;

namespace Autoclicker.UI.Forms
{
    public partial class Main : Form
    {
        internal static Main Instance { get; } = new Main();

        private LeftClickerModule _leftClickerModule;

        private KeybindListener _keybindListener;

        private Keys _enableKey = Keys.None;
        private long _enableKeyCallbackId = -1L;

        private Main()
        {
            InitializeComponent();

            _leftClickerModule = ModuleManager.Instance.Get<LeftClickerModule>();
            _keybindListener = KeybindListener.Instance;

            LoadDefaultSettings();
        }

        private void LoadDefaultSettings()
        {
            CpsSlider.Value = 150; //15 cps
            IgnoreInMenusCheckBox.Checked = true;
            AllowWhileShiftingCheckBox.Checked = true;
            ExhaustCheckBox.Checked = true;
        }

        private void EnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _leftClickerModule.Enabled = EnableCheckBox.Checked;
        }

        private void EnableKeybind_Click(object sender, EventArgs e)
        {
            EnableKeybind.Text = "[...]";
            EnableKeybind.Focus();
        }

        private void EnableKeybind_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == _enableKey)
                return;

            if (_enableKeyCallbackId != -1)
                _keybindListener.UnregisterCallback(_enableKeyCallbackId);

            _enableKeyCallbackId = _keybindListener.RegisterCallback((int)e.KeyCode, () =>
            {
                Action act = () =>
                {
                    EnableCheckBox.Checked = !EnableCheckBox.Checked;
                };

                if (InvokeRequired) Invoke(act);
                else act();
            });

            EnableKeybind.Text = $"[{e.KeyCode}]";
            ActiveControl = null;
        }

        private void CpsSlider_ValueChanged(object sender, EventArgs e)
        {
            var cps = CpsSlider.Value / 10.0f;

            _leftClickerModule.Cps = cps;
            CpsLabel.Text = $"{cps.ToString("00.0").Replace(",", ".")} cps";
        }

        private void IgnoreInMenusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _leftClickerModule.IgnoreInMenus = IgnoreInMenusCheckBox.Checked;
        }

        private void AllowWhileShiftingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _leftClickerModule.AllowWhileShifting = AllowWhileShiftingCheckBox.Checked;
        }

        private void ExhaustCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _leftClickerModule.Exhaust = ExhaustCheckBox.Checked;
        }

        private void NoHitDelayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _leftClickerModule.NoHitDelay = NoHitDelayCheckBox.Checked;
        }
    }
}
