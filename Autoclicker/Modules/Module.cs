namespace Autoclicker.Modules.Impl
{
    internal abstract class Module
    {
        internal bool Enabled
        {
            get => _enabled;
            set
            {
                if (value != _enabled)
                {
                    if (value)
                        OnEnable();
                    else
                        OnDisable();
                }

                _enabled = value;
            }
        }

        private bool _enabled;

        internal virtual void OnStart() { }
        internal virtual void OnStop() { }

        internal virtual void OnEnable() { }
        internal virtual void OnDisable() { }
    }
}
