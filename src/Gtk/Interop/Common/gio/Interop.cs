using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Gtk.Interop;
using static Gtk.Interop.Libraries;

namespace Gtk
{
    internal static partial class Interop
    {
        internal static partial class gio
        {
            [DllImport(Gio)]
            public static extern int g_application_run(IntPtr application, int argc, string[] argv);
        }
    }
}
