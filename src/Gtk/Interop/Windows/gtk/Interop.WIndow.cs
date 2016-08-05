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
            public static extern IntPtr gtk_window_new(GtkWindowType type);

            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_window_set_title(IntPtr window, string title);

            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_window_get_title(IntPtr window);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_window_set_default_size(IntPtr window, int width, int height);
        }
    }
}
