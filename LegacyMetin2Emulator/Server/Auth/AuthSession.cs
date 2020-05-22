using BaseLib.Network;
using LegacyMetin2.Packets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Server.Auth
{
    public class AuthSession : BaseTcpSession
    {
        public readonly uint Handshake = 1337;
        private readonly uint[] Teakey = {
            1953719668, 1953719668, 1953719668, 1953719668
        };

        public AuthSession(AuthServer server) : base(server)
        {
        }

        protected override void OnConnected()
        {
            base.OnConnected();

            AuthServer server = (AuthServer)Server;
            Send(new Packet_Handshake(Handshake, server.BootTime));
        }

        protected override byte[] OnEncrypt(byte[] data)
        {
            return PacketCrypt.Encrypt(data, Teakey);
        }

        protected override byte[] OnDecrypt(byte[] data)
        {
            return PacketCrypt.Decrypt(data, Teakey);
        }
    }
}
