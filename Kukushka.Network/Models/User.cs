using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Kukushka.Network.Models
{
    public class User
    {
        private byte[] _id { get; set; }
        private byte[] _ip { get; set; }
        private byte[] _port { get; set; }
        private byte[] _status { get; set; }
        private byte[] _freeSpace { get; set; }
        private byte[] _acitvityTime { get; set; }

        private byte[] _rsaOpenKey { get; set; }

        public byte[] RsaOpenKey { get => _rsaOpenKey; }

        public string Ip { get => string.Concat(_id.Select(b => b.ToString("X2")).ToArray()); }
        public IPEndPoint IP { get => new IPEndPoint(new IPAddress(_ip), (int)BitConverter.ToInt16(_port, 0)); }
        public long FreeSpace { get => (long)BitConverter.ToInt32(_freeSpace, 0) * 1024; }

        public void SetActivity(DayOfWeek day, int hour, bool activity)
        {
            if (_acitvityTime == null)
                _acitvityTime = new byte[21];
            var array = new BitArray(_acitvityTime);
            array[(int)day * 7 + hour] = activity;
            array.CopyTo(_acitvityTime, 0);
        }

        public Dictionary<DayOfWeek, bool[]> ActivityTime
        {
            get
            {
                if (_acitvityTime == null)
                    _acitvityTime = new byte[21];

                var result = new Dictionary<DayOfWeek, bool[]>();

                byte[] current = new byte[3];

                foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                {
                    current[0] = _acitvityTime[(int)day * 3];
                    current[1] = _acitvityTime[(int)day * 3 + 1];
                    current[2] = _acitvityTime[(int)day * 3 + 2];

                    var hours = new BitArray(current);

                    result.Add(day, new bool[hours.Length]);

                    for (int i = 0; i < hours.Length; i++)
                        result[day][i] = hours[i];
                }

                return result;
            }

        }

        public byte[] ToByte()
        {

            var result = new byte[320];
            _id.CopyTo(result, 0);
            _status.CopyTo(result, 16);
            _freeSpace.CopyTo(result, 17);
            _ip.CopyTo(result, 21);
            _port.CopyTo(result, 25);
            _acitvityTime.CopyTo(result, 27);
            _rsaOpenKey.CopyTo(result, 48);
            return result;
        }

    }
}
