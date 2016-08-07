#if WIN10_X64

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
            internal const string Libstdcpp = @"C:\msys64\mingw64\bin\libstdc++-6.dll";

            internal const string Gdk = @"C:\msys64\mingw64\bin\libgdk-3.dll";

            internal const string Gtk = @"C:\msys64\mingw64\bin\libgtk-3-0.dll";

            internal const string Cairo = @"C:\msys64\mingw64\bin\libcairo-2.dll";

            internal const string Gio = @"C:\msys64\mingw64\bin\libgio-2.0-0.dll";

            internal const string GLib = @"C:\msys64\mingw64\bin\libglib-2.0-0.dll";

            internal const string GObj = @"C:\msys64\mingw64\bin\libgobject-2.0-0.dll";
        }
    }
}

#endif