using BaseLib.Network;
using LegacyMetin2.Network;
using LegacyMetin2.Packets;
using LegacyMetin2.Server.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Handlers
{
    public class Handler_Login : ITCPHandler
    {
        private readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        public void Handle(BaseTcpSession baseSession, BasePacket data)
        {
            GameSession session = (GameSession)baseSession;
            data.PrintData();

            string username = data.Get();
            data.Skip(17 - username.Length - 1);
            string password = data.Get();
            data.Skip(17 - password.Length - 1);

            data.Skip(1); // Sequence

            Log.Info($"Username {username}, Password {password}");

            session.Send(new Packet_Phase(3));
            session.Send(new Packet_Empire(1));
            session.SendPlayerInfo();
        }
    }
}
