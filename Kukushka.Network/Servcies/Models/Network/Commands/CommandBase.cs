using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Servcies.Models.Network.Commands
{
    public abstract class CommandBase
    {
        public abstract string Name { get; set; }
    }
}
