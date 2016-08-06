#if WIN10_X64

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gdk
{
    internal static partial class Interop
    {
        internal static class Libraries
        {
            internal const string Gdk = @"C:\msys64\mingw64\bin\libgdk-3.dll";
        }
    }
}

#endif