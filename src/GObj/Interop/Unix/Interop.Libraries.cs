#if UNIX

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
            internal const string GObj = @"libgobject-2.0-0.so";
        }
    }
}

#endif