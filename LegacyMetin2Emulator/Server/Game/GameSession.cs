using BaseLib.Network;
using LegacyMetin2.Packets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Server.Game
{
    public class GameSession : BaseTcpSession
    {
        public readonly uint Handshake = 1337;
        private uint[] CryptKey = null;
        private uint[] DecryptKey = null;

        private readonly uint[] Teakey = {
            1953719668, 1953719668, 1953719668, 1953719668
        };

        public GameSession(GameServer server) : base(server)
        {
            CryptKey = Teakey;
            DecryptKey = Teakey;
        }

        protected override void OnConnected()
        {
            base.OnConnected();

            GameServer server = (GameServer)Server;
            Send(new Packet_Phase(1));
            Send(new Packet_Handshake(Handshake, server.BootTime));
        }

        protected override byte[] OnEncrypt(byte[] data)
        {
            return PacketCrypt.Encrypt(data, CryptKey);
        }

        protected override byte[] OnDecrypt(byte[] data)
        {
            return PacketCrypt.Decrypt(data, DecryptKey);
        }

        public void SendPlayerInfo()
        {
            Send(new Packet_LoginSuccess());
        }

        public void ComputeKey(uint[] keys)
        {
            DecryptKey = keys;

            string key = "JyTxtHljHJlVJHorRM301vf@4fvj10-v";

            CryptKey = PacketCrypt.ToUintArray(PacketCrypt.Encrypt(PacketCrypt.ToByteArray(keys), PacketCrypt.ToUintArray(Encoding.ASCII.GetBytes(key))));
        }
    }
}
