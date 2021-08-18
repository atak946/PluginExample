using Plugin.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin
{
    internal class Plugin : IPlugin
    {
        public string GetName() => "My plugin v1";

        public bool Install()
        {
            throw new NotImplementedException();
        }

        public bool Uninstall()
        {
            throw new NotImplementedException();
        }
    }
}
