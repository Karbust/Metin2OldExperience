using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Packets
{
    public class Packet_LoginKey : Packet
    {
        public Packet_LoginKey(uint loginKey) : base(118)
        {
            Add(loginKey);
        }
    }
}
