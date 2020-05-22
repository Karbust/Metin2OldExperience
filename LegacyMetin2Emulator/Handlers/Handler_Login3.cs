using BaseLib.Network;
using LegacyMetin2.Network;
using LegacyMetin2.Packets;
using LegacyMetin2.Server.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Handlers
{
    public class Handler_Login3 : ITCPHandler
    {
        private readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        public void Handle(BaseTcpSession baseSession, BasePacket data)
        {
            AuthSession session = (AuthSession)baseSession;

            data.PrintData();

            string username = data.Get();
            data.Skip(17 - username.Length - 1);
            string password = data.Get();
            data.Skip(17 - password.Length - 1);
            uint[] keys = new uint[4];

            keys[0] = data.GetUInt32();
            keys[1] = data.GetUInt32();
            keys[2] = data.GetUInt32();
            keys[3] = data.GetUInt32();

            username = username.ToLower();
            password = password.ToLower();

            data.Skip(1); // Sequence

            Log.Info($"Username {username}, Password {password}, Client keys {keys[0]}.{keys[1]}.{keys[2]}.{keys[3]}");

            // Login key = 1
            session.Send(new Packet_AuthSuccess(0xFF, 1));
        }
    }
}
