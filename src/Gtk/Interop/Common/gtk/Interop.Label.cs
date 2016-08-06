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
            public static extern IntPtr gtk_label_new(string str);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_label_set_text(IntPtr label, string str);

            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_label_get_text(IntPtr label);
        }
    }
}
