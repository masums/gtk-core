#if MACOS

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
            internal const string GObj = @"/usr/local/Cellar/glib/2.50.0/lib/libgobject-2.0.0.dylib";
        }
    }
}

#endif