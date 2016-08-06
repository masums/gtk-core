#if WIN10_X64

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GObj
{
    internal static partial class Interop
    {
        internal static class Libraries
        {
            internal const string GObj = @"C:\msys64\mingw64\bin\libgobject-2.0-0.dll";
        }
    }
}

#endif