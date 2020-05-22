using BaseLib.Network;
using System.Collections.Generic;
using System.Text;

namespace LegacyMetin2.Network
{
    public class Packet : BasePacket
    {
        public Packet(byte id)
        {
            Add(id);
        }

        public Packet(byte[] data)
        {
            Add(data);
            Seek(1);
        }

        #region Virtual

        protected override void Add(string data, Encoding encoding)
        {
            // Custom API for adding strings
            Add(encoding.GetBytes(data));
        }

        public override string Get()
        {
            List<byte> lb = new List<byte>();

            while (true)
            {
                byte b = GetByte();

                if (b == 0x00)
                    break;

                lb.Add(b);
            }

            return Encoding.ASCII.GetString(lb.ToArray());
        }

        public override void SkipString()
        {
            // Custom API for skipping strings
            while (GetByte() != 0) ;
        }

        public override object GetID()
        {
            return Data[0];
        }
        #endregion
    }
}
