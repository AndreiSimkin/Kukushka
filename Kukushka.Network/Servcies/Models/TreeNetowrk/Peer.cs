using Kukushka.Network.Data.Enums;
using Kukushka.Network.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Servcies.Models.TreeNetowrk
{
    public class Peer
    {
        public Peer(User user)
        {
            if (user.AcceptConnectionType == AcceptConnectionType.None)
                throw new Exception("This user cannot accept connections!");

            User = user;
        }

        private Stream _stream { get; set; }

        public Stream GetStream()
        {
            return _stream;
        }

        public User User { get; set; }
    }
}
