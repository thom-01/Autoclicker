using System;
using System.Collections.Generic;

namespace Autoclicker.Modules.Impl
{
    internal class ModuleManager : List<Module>
    {
        internal static ModuleManager Instance = new ModuleManager();

        private ModuleManager()
        {
            foreach (var type in typeof(ModuleManager).Assembly.GetTypes())
            {
                if (type.IsAbstract || type.IsInterface)
                    continue;

                if (!typeof(Module).IsAssignableFrom(type))
                    continue;

                var module = (Module)Activator.CreateInstance(type);
                Add(module);
            }
        }

        internal void StartModules()
        {
            foreach (var module in this)
                module.OnStart();
        }

        internal void StopModules()
        {
            foreach (var module in this)
                module.OnStop();
        }

        internal T Get<T>() where T : Module
        {
            foreach (var module in this)
                if (module is T tModule)
                    return tModule;

            return default;
        }
    }
}
