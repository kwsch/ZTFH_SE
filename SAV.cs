using System;
using System.Linq;

namespace ZTFH_SE
{
    // CRC32 code
    // Via http://sanity-free.org/12/crc32_implementation_in_csharp.html
    public class Crc32
    {
        uint[] table;

        public uint ComputeChecksum(byte[] bytes)
        {
            uint crc = 0xffffffff;
            foreach (byte t in bytes)
            {
                byte index = (byte)(((crc) & 0xff) ^ t);
                crc = ((crc >> 8) ^ table[index]);
            }
            return ~crc;
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            return BitConverter.GetBytes(ComputeChecksum(bytes));
        }

        public Crc32()
        {
            const uint poly = 0xedb88320;
            table = new uint[256];
            for (uint i = 0; i < table.Length; ++i)
            {
                uint temp = i;
                for (int j = 8; j > 0; --j)
                {
                    if ((temp & 1) == 1)
                        temp = ((temp >> 1) ^ poly);
                    else
                        temp >>= 1;
                }
                table[i] = temp;
            }
        }
    }

    public class SAV
    {
        public byte[] Data;
        public Crc32 CHK = new Crc32();
        internal static readonly int SIZE = 0x2C00;

        public SAV(byte[] data)
        {
            Data = (byte[])data.Clone();
        }
        public byte[] Write()
        {
            byte[] newSAV = (byte[])Data.Clone();
            byte[] r1 = Data.Skip(0x000).Take(0x1FC).ToArray();
            byte[] r2 = Data.Skip(0x200).Take(0x17FC).ToArray();
            byte[] r3 = Data.Skip(0x1A00).Take(0x11FC).ToArray();

            uint r1crc = CHK.ComputeChecksum(r1);
            uint r2crc = CHK.ComputeChecksum(r2);
            uint r3crc = CHK.ComputeChecksum(r3);

            BitConverter.GetBytes(r1crc).CopyTo(newSAV, 0x1FC);
            BitConverter.GetBytes(r2crc).CopyTo(newSAV, 0x19FC);
            BitConverter.GetBytes(r3crc).CopyTo(newSAV, 0x2BFC);

            return newSAV;
        }

        public uint Rupees
        {
            get { return BitConverter.ToUInt32(Data, 0x2B0); }
            set { BitConverter.GetBytes(value).CopyTo(Data, 0x2B0); }
        }
    }
}
