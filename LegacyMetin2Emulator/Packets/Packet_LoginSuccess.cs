using LegacyMetin2.Network;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LegacyMetin2.Packets
{
    public class Packet_LoginSuccess : Packet
    {
        public Packet_LoginSuccess() : base(6)
        {
            /*Add(1);

            string username = "Arves100 ^^";
            Add(username);
            FillByte(0x19 - username.Length - 1);

            Add(2);

            for (int i = 0; i < 26; i++) // Playerinfo 1?
            {
                Add((byte)0);
            }

            // Game server port
            Add(0x7F000001);
            Add((ushort)50001);

             username = "\xA7\xDA\xB5\x6E\x3F\xA4\x46\x3A\x29";
             Add(2);
             Add(username);
             FillByte(0x19 - username.Length - 1);
             Add(0);
             for (int i = 0; i < 26; i++) // Playerinfo 2/3?
             {
                 Add((byte)0);
             }

             Add(0); // x
             Add(0); // y
             Add(0x7F000001); // Game Addr
             Add((ushort)50001); // Game port

             username = "?";
             Add(3);
             Add(username);
             FillByte(0x18 - username.Length - 1);
             Add(0);
             for (int i = 0; i < 26; i++) // Playerinfo 2/3?
             {
                 Add((byte)0);
             }

             Add(0x7F000001);
             Add((ushort)50001);*/

            string username = "Arves100 ^^";

            Add(1); // ID
            Add(username);
            Fill(25 - username.Length);
            Add((byte)3); // Job (0 = Warrior (M), 1 = Ninja (W), 2 = Sura (M), 3 = Shaman (W) MAX = 3)
            Add((byte)99); // Level
            Add(12000); // Play minutes
            Add((byte)255); // ST
            Add((byte)255); // HT
            Add((byte)255);  // DX
            Add((byte)255); // IQ

            Fill(2); // Mainpart?
            Add((byte)0); // Change name

            Fill(3); // ?

            Add(0); // x
            Add(0); // y

            byte[] a = IPAddress.Parse("127.0.0.1").GetAddressBytes();
            Add(a); // ip
           // Add((ushort)IPAddress.NetworkToHostOrder(50000)); // port
           // Add((byte)1);

            username = "???";
            Add(1); // ID
            Add(username);
            Fill(25 - username.Length);
            Add((byte)1); // Job (0 = Warrior (M), 1 = Ninja (W), 2 = Sura (M), 3 = Shaman (W) MAX = 3)
            Add((byte)99); // Level
            Add(12000); // Play minutes
            Add((byte)255); // ST
            Add((byte)255); // HT
            Add((byte)255);  // DX
            Add((byte)255); // IQ

            Fill(2); // Mainpart?
            Add((byte)0); // Change name

            Fill(3); // ?

            Add(0); // x
            Add(0); // y

            a = IPAddress.Parse("127.0.0.1").GetAddressBytes();
            Add(a); // ip
                    //Add((ushort)IPAddress.NetworkToHostOrder(50000)); // port

            /*username = "??????";
            Add(2); // ID
            Add(username);
            FillByte(25 - username.Length);
            Add((byte)0); // Job (0 = Warrior (M), 1 = Ninja (W), 2 = Sura (M), 3 = Shaman (W) MAX = 3)
            Add((byte)99); // Level
            Add(12000); // Play minutes
            Add((byte)255); // ST
            Add((byte)255); // HT
            Add((byte)255);  // DX
            Add((byte)255); // IQ

            FillByte(2); // Mainpart?
            Add((byte)0); // Change name

            FillByte(3); // ?

            Add(0); // x
            Add(0); // y

            a = IPAddress.Parse("127.0.0.1").GetAddressBytes();
            Add(a); // ip
            Add((ushort)IPAddress.NetworkToHostOrder(50000)); // port
            Add((byte)1);*/

            /*username = "\xA7\xDA\xB5\x6E\x3F\xA4\x46\x3A\x29";
            Add(2); // ID
            Add(username);
            FillByte(25 - username.Length);
            Add((byte)0); // Job (0 = Warrior (M), 1 = Ninja (W), 2 = Sura (M), 3 = Shaman (W) MAX = 3)
            Add((byte)45); // Level
            Add(12000); // Play minutes
            Add((byte)255); // ST
            Add((byte)230); // HT
            Add((byte)80);  // DX
            Add((byte)125); // IQ

            Add((ushort)100); // Main part??
            Add((byte)0); // Change name?

            Add((ushort)100); // Hair part???

            Add(0xFF); // Dummy ?

            Add(0); // x
            Add(0); // y
            Add(0x7F000001); // ip
            Add((ushort)50000); // port

            username = "PACI SCAMMER";
            Add(4); // ID
            Add(username);
            FillByte(25 - username.Length);
            Add((byte)1); // Job (0 = Warrior (M), 1 = Ninja (W), 2 = Sura (M), 3 = Shaman (W) MAX = 3)
            Add((byte)99); // Level
            Add(12000); // Play minutes
            Add((byte)255); // ST
            Add((byte)230); // HT
            Add((byte)80);  // DX
            Add((byte)125); // IQ

            Add((ushort)100); // Main part??
            Add((byte)0); // Change name?

            Add((ushort)100); // Hair part???

            Add(0xFF); // Dummy ?

            Add(0); // x
            Add(0); // y
            Add(0x7F000001); // ip
            Add((ushort)50000); // port*/

            Fill(60 /** 2*/);

            // Guilds
            Add(1000);
            Add(0);
            Add(0);

            Add("Longju Dev");
            Fill(3);

            // Guild names
            Fill(13 * 2);

            Add(1); // Handle
            Add(10); // Random key
        }
    }
}
