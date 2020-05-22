using BaseLib.Network;
using LegacyMetin2.Network;
using LegacyMetin2.Packets;
using LegacyMetin2.Server.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Handlers
{
    public class Handle_Login2 : ITCPHandler
    {
        private readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        public void Handle(BaseTcpSession baseSession, BasePacket data)
        {
            GameSession session = (GameSession)baseSession;

            data.PrintData();

            string username = data.Get();
            data.Skip(17 - username.Length - 1);

            uint loginKey = data.GetUInt32();

            uint[] DecryptKey = new uint[4];
            DecryptKey[0] = data.GetUInt32();
            DecryptKey[1] = data.GetUInt32();
            DecryptKey[2] = data.GetUInt32();
            DecryptKey[3] = data.GetUInt32();
            data.Skip(1); // Sequence

            Log.Info($"Username {username}, lkey {loginKey}, keys {DecryptKey[0]},{DecryptKey[1]},{DecryptKey[2]},{DecryptKey[3]}");

            session.ComputeKey(DecryptKey);

            session.Send(new Packet_Empire(2));
            session.Send(new Packet_Phase(3));
            session.SendPlayerInfo();
        }
    }
}
