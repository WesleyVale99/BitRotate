using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BitRotate.FileNetwork
{
   public class Shift
    {
        [DllImport("i3BaseDx.dll", EntryPoint = "?BitRotateDecript@@YAXPAEII@Z")]
        public static extern void BitRotateDecript(byte[] from, int length, int shift);
        [DllImport("i3BaseDx.dll", EntryPoint = "?BitRotateEncrypt@@YAXPAEII@Z")]
        public static extern void BitRotateEncript(byte[] from, int length, int shift);
    }
}
