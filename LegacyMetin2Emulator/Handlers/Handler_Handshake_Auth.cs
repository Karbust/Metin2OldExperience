using BaseLib.Network;
using LegacyMetin2.Network;
using LegacyMetin2.Packets;
using LegacyMetin2.Server.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Handlers
{
    public class Handler_Handshake_Auth : ITCPHandler
    {
        private readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        public void Handle(BaseTcpSession baseSession, BasePacket data)
        {
            AuthSession session = (AuthSession)baseSession;

            if (session.Handshake != data.GetUInt32())
            {
                Log.Error($"Invalid handshake from client {session.Id}, disconnecting...");
                session.Disconnect();
                return;
            }

            session.Send(new Packet_Phase(10));
            session.EnableEncryptation();
        }
    }
}
