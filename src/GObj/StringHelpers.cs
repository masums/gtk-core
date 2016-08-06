using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GObj
{
    public static class StringHelpers
    {
        static unsafe ulong strlen(IntPtr s)
        {
            ulong cnt = 0;
            byte* b = (byte*)s;
            while (*b != 0)
            {
                b++;
                cnt++;
            }
            return cnt;
        }


        public static string Utf8PtrToString(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return null;

            int len = (int)(uint)strlen(ptr);
            byte[] bytes = new byte[len];
            Marshal.Copy(ptr, bytes, 0, len);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
