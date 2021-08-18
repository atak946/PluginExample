using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin.Shared
{
    public interface IPlugin
    {
        string GetName();

        bool Install();
        bool Uninstall();
    }
}
