using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Packets
{
    public class Packet_Phase : Packet
    {
        public Packet_Phase(byte phase) : base(253)
        {
            Add(phase);
        }
    }
}
