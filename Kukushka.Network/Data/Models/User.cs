using Kukushka.Network.Data.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Kukushka.Network.Data.Models
{
    public class User
    {
        public byte[] Id { get; set; }
        public byte[] IP { get; set; }
        public byte[] Port { get; set; }
        public byte[] ActivityTime { get; set; }
        public byte[] RsaOpenKey { get; set; }
        public byte Status { get; set; }
        public int FreeSpace { get; set; }
        public AcceptConnectionType AcceptConnectionType { get; set; }

        public IPEndPoint GetIPEndPoint()
        {
            return new IPEndPoint(new IPAddress(IP), (int)BitConverter.ToInt16(Port, 0));
        }
    }
}
