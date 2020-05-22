using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Packets
{
    class Packet_Empty : Packet
    {
        public Packet_Empty(int size) : base(0)
        {
            Fill(size-1);
        }
    }
}
