using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static Gtk.Interop.glib;
using static Gtk.Interop.Libraries;

namespace Gtk
{
    internal static partial class Interop
    {
        internal static partial class gtk
        {
            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_button_box_new(GtkOrientation orientation);
        }
    }
}
