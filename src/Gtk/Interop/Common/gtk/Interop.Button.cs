using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static Interop.Libraries;

namespace Interop
{
    internal static partial class gtk
    {
        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_button_new(string label);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_button_new_with_label(string label);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_button_set_label(IntPtr button, string str);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_button_get_label(IntPtr button);
    }
}
