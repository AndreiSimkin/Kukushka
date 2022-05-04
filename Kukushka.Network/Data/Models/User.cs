using Kukushka.Network.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Kukushka.Network.Data.Models
{
    public class User
    {
        public const byte MaxTreeLevel = 3;
        public long Id { get; set; }
        [Required]
        public byte[] NickHash { get; set; }

        [MinLength(4, ErrorMessage = "IP cannot be less than 4 bytes ")]
        [MaxLength(4, ErrorMessage = "IP cannot be more than 4 bytes")]
        [Required]
        public byte[] IP { get; set; }
        [MinLength(2, ErrorMessage = "Port cannot be less than 2 bytes ")]
        [MaxLength(2, ErrorMessage = "Port cannot be more than 2 bytes")]
        [Required]
        public byte[] Port { get; set; }
        [MinLength(21, ErrorMessage = "ActivityTime cannot be less than 21 bytes ")]
        [MaxLength(21, ErrorMessage = "ActivityTime cannot be more than 21 bytes")]
        [Required]
        public byte[] ActivityTime { get; set; }
        public byte[] RsaOpenKey { get; set; }
        [Required]
        public int FreeSpace { get; set; }
        public AcceptConnectionType AcceptConnectionType { get; set; }

        public IPEndPoint GetIPEndPoint()
        {
            return new IPEndPoint(new IPAddress(IP), BitConverter.ToInt16(Port, 0));
        }
        [Required]
        public bool IsOnline { get; set; }
        [Required]
        public bool IsMobile { get; set; }
        private byte _treeLevel;
        [Required]
        public byte TreeLevel
        {
            get => _treeLevel;
            set
            {
                if (value > MaxTreeLevel)
                {
                    throw new Exception($"TreeLevel cannot be more than {MaxTreeLevel}");
                }
                _treeLevel = value;
            }
        }
    }
}
