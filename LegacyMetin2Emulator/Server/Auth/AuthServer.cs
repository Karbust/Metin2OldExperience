using BaseLib.Network;
using LegacyMetin2.Handlers;
using LegacyMetin2.Network;
using NetCoreServer;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LegacyMetin2.Server.Auth
{
    public class AuthServer : BaseTcpServer
    {
        public DateTime BootTime { get; protected set; }

        public AuthServer(IPAddress address, int port) : base(address, port)
        {
            RegisterHandlers();
        }

        public AuthServer(string address, int port) : base(address, port)
        {
            RegisterHandlers();
        }

        public AuthServer(IPEndPoint endpoint) : base(endpoint)
        {
            RegisterHandlers();
        }

        private void RegisterHandlers()
        {
            Register<byte>(255, typeof(Handler_Handshake_Auth));
            Register<byte>(111, typeof(Handler_Login3));
        }

        protected override BasePacket GetPacket(byte[] buffer)
        {
            return new Packet(buffer);
        }

        protected override TcpSession CreateSession()
        {
            return new AuthSession(this);
        }

        protected override void OnStarted()
        {
            BootTime = DateTime.Now;
        }
    }
}
