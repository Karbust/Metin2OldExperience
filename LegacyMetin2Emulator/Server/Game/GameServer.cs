using BaseLib.Network;
using LegacyMetin2.Handlers;
using LegacyMetin2.Network;
using NetCoreServer;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LegacyMetin2.Server.Game
{
    public class GameServer : BaseTcpServer
    {
        public DateTime BootTime { get; protected set; }

        public GameServer(string address, int port) : base(address, port)
        {
            RegisterHandlers();
        }

        private void RegisterHandlers()
        {
            Register<byte>(255, typeof(Handler_Handshake_Game));
            Register<byte>(1, typeof(Handler_Login));
            Register<byte>(109, typeof(Handle_Login2));
            Register<byte>(100, typeof(Handler_GuildMarkLogin));
        }

        protected override BasePacket GetPacket(byte[] buffer)
        {
            return new Packet(buffer);
        }

        protected override TcpSession CreateSession()
        {
            return new GameSession(this);
        }

        protected override void OnStarted()
        {
            BootTime = DateTime.Now;
        }
    }
}
