#if UNIX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLib
{
    internal static partial class Interop
    {
        internal static class Libraries
        {
            internal const string GLib = @"libglib-2.0-0.so";
        }
    }
}

#endif