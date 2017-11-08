using System;

namespace Interop
{
    static class Libraries
    {
#if MACOS

        internal const string Gdk = @"/usr/local/Cellar/gtk+3/3.22.15/lib/libgdk-3.0.dylib";

        internal const string Gtk = @"/usr/local/Cellar/gtk+3/3.22.15/lib/libgtk-3.0.dylib";

        internal const string Cairo = @"/usr/local/Cellar/cairo/1.14.8/lib/libcairo.2.dylib";

        internal const string Gio = @"/usr/local/Cellar/glib/2.54.2/lib/libgio-2.0.0.dylib";

        internal const string GLib = @"/usr/local/Cellar/glib/2.54.2/lib/libglib-2.0.0.dylib";

        internal const string GObj = @"/usr/local/Cellar/glib/2.54.2/lib/libgobject-2.0.0.dylib";

#endif

#if LINUX

        internal const string Gdk = @"/usr/lib/x86_64-linux-gnu/libgdk-3.so.";

        internal const string Gtk = @"/usr/lib/x86_64-linux-gnu/libgtk-3.so";

        internal const string Cairo = @"/usr/lib/x86_64-linux-gnu/libcairo.so";

        internal const string Gio = @"/usr/lib/x86_64-linux-gnu/libgio-2.0.so";

        internal const string GLib = @"/usr/lib/x86_64-linux-gnu/libglib-2.0.so";

        internal const string GObj = @"/usr/lib/x86_64-linux-gnu/libgobject-2.0.so";

#endif

#if WIN64

        // TODO: Update these paths

        internal const string Libstdcpp = @"C:\msys64\mingw64\bin\libstdc++-6.dll";

        internal const string Gdk = @"C:\msys64\mingw64\bin\libgdk-3.dll";

        internal const string Gtk = @"C:\msys64\mingw64\bin\libgtk-3-0.dll";

        internal const string Cairo = @"C:\msys64\mingw64\bin\libcairo-2.dll";

        internal const string Gio = @"C:\msys64\mingw64\bin\libgio-2.0-0.dll";

        internal const string GLib = @"C:\msys64\mingw64\bin\libglib-2.0-0.dll";

        iinternal const string GObj = @"C:\msys64\mingw64\bin\libgobject-2.0-0.dll";

#endif
    }
}
