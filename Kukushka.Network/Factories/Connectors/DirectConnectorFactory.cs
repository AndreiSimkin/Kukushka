using Kukushka.Network.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Kukushka.Network.Factories.Connectors
{
    public class DirectConnectorFactory : ConnectorFactory
    {
        public DirectConnectorFactory(User user) : base(user)
        {
        }

        private bool _connected { get; set; }

        private Stream _stream;

        public override bool Connect()
        {
            try
            {
                var client = new TcpClient();
                client.Connect(User.GetIPEndPoint());
                _stream = client.GetStream();
                _connected = true;
                return _connected;
            }
            catch
            {
                _connected = false;
                return _connected;
            }
        }

        public override Stream GetStream()
        {
            if (_connected)
                return _stream;
            else
                return null;
        }
    }
}
