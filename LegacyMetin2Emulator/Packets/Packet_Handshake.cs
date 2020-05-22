using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Packets
{
    public class Packet_Handshake : Packet
    {
        public Packet_Handshake(uint Handshake, DateTime Boot) : base(255)
        {
            Add(Handshake);
            Add(DateTime.Now.Millisecond - Boot.Millisecond);
            Add(0);
        }
    }
}
