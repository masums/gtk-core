#if MACOS

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
            internal const string Gdk = @"/usr/local/Cellar/gtk+3/3.22.1/lib/libgtk-3.0.dylib";
        }
    }
}

#endif