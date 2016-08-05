using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Gtk
{
    internal static partial class Interop
    {
        internal static partial class gio
        {
            public const string GIO_PATH = @"C:\msys64\mingw64\bin\libgio-2.0-0.dll";

            [DllImport(GIO_PATH)]
            public static extern int g_application_run(IntPtr application, int argc, string[] argv);
        }
    }
}
