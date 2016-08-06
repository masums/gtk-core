#if UNIX

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
            internal const string Gtk = @"libgtk-3-0.so";
        }
    }
}

#endif