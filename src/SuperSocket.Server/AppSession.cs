using System;
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Buffers;
using SuperSocket;
using SuperSocket.Channel;
using SuperSocket.ProtoBase;

namespace SuperSocket.Server
{
    public class AppSession : IAppSession
    {
        internal AppSession(IServerInfo server, IChannel channel)
        {
            Server = server;
            Channel = channel;
            SessionID = Guid.NewGuid().ToString();
        }

        public string SessionID { get; private set; }

        public IServerInfo Server { get; private set; }

        public IChannel Channel { get; private set; }
    }
}