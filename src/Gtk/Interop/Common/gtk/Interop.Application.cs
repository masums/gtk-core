using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static Gtk.Interop.Libraries;

namespace Gtk
{
    internal static partial class Interop
    {
        internal static partial class gtk
        {
            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_application_new(string application_id, gio.GApplicationFlags flags);

            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_application_window_new(IntPtr application);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_application_add_window(IntPtr application, IntPtr window);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_application_remove_window(IntPtr application, IntPtr window);

            [DllImport(Libraries.Gtk)]
            public static unsafe extern IntPtr gtk_application_get_windows(IntPtr application);

            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_application_get_window_by_id(IntPtr application, uint id);

            [DllImport(Libraries.Gtk)]
            public static unsafe extern IntPtr gtk_application_get_active_window(IntPtr application);
        }
    }
}
