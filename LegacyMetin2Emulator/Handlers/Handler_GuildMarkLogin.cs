using BaseLib.Network;
using LegacyMetin2.Network;
using LegacyMetin2.Server.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Handlers
{
    class Handler_GuildMarkLogin : ITCPHandler
    {
        public void Handle(BaseTcpSession session, BasePacket data)
        {
            // TODO
            session.Disconnect();
        }
    }
}
