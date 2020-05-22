using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Packets
{
    public class Packet_Empire : Packet
    {
        public Packet_Empire(byte empire) : base(90)
        {
            Add(empire);
        }
    }
}
