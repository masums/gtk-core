#if MACOS

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
            internal const string Gtk = @"/usr/local/Cellar/gtk+3/3.22.1/lib/libgtk-3.0.dylib";

            internal const string Cairo = @"/usr/local/Cellar/cairo/1.14.6_1/lib/libcairo.2.dylib";

            internal const string Gio = @"/usr/local/Cellar/glib/2.50.0/lib/libgio-2.0.0.dylib";

            internal const string GLib = @"/usr/local/Cellar/glib/2.50.0/lib/libglib-2.0.0.dylib";

            internal const string GObj = @"/usr/local/Cellar/glib/2.50.0/lib/libgobject-2.0.0.dylib";
        }
    }
}

#endif