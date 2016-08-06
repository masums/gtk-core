#if UNIX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk
{
    internal static partial class Interop
    {
        internal static class Libraries
        {
            internal const string Gtk = @"libgtk-3-0.so";

            internal const string Cairo = @"libcairo-2.so";

            internal const string Gio = @"libgio-2.0-0.so";

            internal const string GLib = @"libglib-2.0-0.so";

            internal const string GObj = @"libgobject-2.0-0.so";
        }
    }
}

#endif