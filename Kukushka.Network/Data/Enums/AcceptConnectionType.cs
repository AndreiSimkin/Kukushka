using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Data.Enums
{
    public enum AcceptConnectionType : byte
    {
        None = 0,
        Direct = 1,
        STUNServer = 2,
        UDPPunchHole = 3
    }
}
