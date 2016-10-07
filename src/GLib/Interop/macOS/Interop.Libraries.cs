#if MACOS

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
            internal const string GLib = @"/usr/local/Cellar/glib/2.50.0/lib/libglib-2.0.0.dylib";
        }
    }
}

#endif