using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitRotate.FileNetwork
{
   public class Shift
    {
        public static void Encrypt(byte[] buffer, int start, int length, int bits)
        {
            int total = start + length;
            if (buffer.Length < total)
            {
                total = buffer.Length;
            }
            byte first = buffer[start];
            byte current;
            for (int i = start; i < total; i++)
            {
                if (i >= (total - 1))
                {
                    current = first;
                }
                else
                {
                    current = buffer[i + 1];
                }
                buffer[i] = (byte)(current >> (8 - bits) | (buffer[i] << bits));
            }
        }

        public static bool Decrypt(IList<byte> data, int start, int length, int bits)
        {
            try
            {
                int total = start + length;

                if (data.Count < total) total = data.Count;

                byte last = data[total - 1];

                for (var i = total - 1; i >= start; i--)
                {
                    var _current = i <= start ? last : data[i - 1];
                    data[i] = (byte)((_current << (8 - bits)) | (data[i] >> bits));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
