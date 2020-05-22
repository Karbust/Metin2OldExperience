using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Packets
{
    public class Packet_AuthSuccess : Packet
    {
        public Packet_AuthSuccess(uint loginkey, byte result) : base(150)
        {
            Add(loginkey);
            Add(result);

            Add(0); // ?? Why by adding this is works? In IDA it shows packet size = 0x06
        }
    }
}
