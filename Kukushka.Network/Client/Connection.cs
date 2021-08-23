using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using STUN;
using STUN.Attributes;

namespace Kukushka.Network.Client
{
    public class Connection
    {
        public static async Task<STUNQueryResult> GetStunAdress()
        {
            if (!STUNClient.TryParseHostAndPort("stun.schlund.de:3478", out IPEndPoint stunEndPoint))
                throw new Exception("Failed to resolve STUN server address");

            STUNClient.ReceiveTimeout = 500;
            var queryResult = await STUNClient.QueryAsync(stunEndPoint, STUNQueryType.ExactNAT, false);

            if (queryResult.QueryError != STUNQueryError.Success)
                throw new Exception("Query Error: " + queryResult.QueryError.ToString());

            System.Diagnostics.Debug.WriteLine("PublicEndPoint: {0}", queryResult.PublicEndPoint);
            System.Diagnostics.Debug.WriteLine("LocalEndPoint: {0}", queryResult.LocalEndPoint);
            System.Diagnostics.Debug.WriteLine("NAT Type: {0}", queryResult.NATType);

            var queryResult2 = await STUNClient.QueryAsync(queryResult.Socket,stunEndPoint, STUNQueryType.ExactNAT);

            new Thread(() =>
            {
                queryResult2.Socket.Send(new byte[] { 255 });

            }).Start();


            var buffer = new byte[1];
            var result = queryResult.Socket.Receive(buffer);
            System.Diagnostics.Debug.WriteLine(buffer[0]);

            //          queryResult.Socket.Close();

            return queryResult;
        }
    }
}
