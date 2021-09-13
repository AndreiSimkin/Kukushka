using Kukushka.Network.Data.Enums;
using Kukushka.Network.Data.Models;
using Kukushka.Network.Factories.Connectors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Kukushka.Network.Factories
{
    public abstract class ConnectorFactory
    {
        public ConnectorFactory(User user)
        {
            user = User;
        }

        public static ConnectorFactory Create(User user)
        {
            if (user.AcceptConnectionType == AcceptConnectionType.None)
                throw new Exception("This user cannot accept connections!");
            else if (user.AcceptConnectionType == AcceptConnectionType.Direct)
                return new DirectConnectorFactory(user);

            return null;
        }

        public abstract bool Connect();

        public abstract Stream GetStream();

        public User User { get; set; }
    }
}
