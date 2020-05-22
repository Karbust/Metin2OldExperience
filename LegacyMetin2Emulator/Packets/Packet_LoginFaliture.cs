using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Packets
{
    public class Packet_LoginFaliture : Packet
    {
        public Packet_LoginFaliture(string status) : base(7)
        {
            string newStatus = status;
            
            if (status.Length > 8)
                newStatus = status.Substring(0, 8);

            Add(newStatus);
            Fill(9 - newStatus.Length);
        }
    }
}
