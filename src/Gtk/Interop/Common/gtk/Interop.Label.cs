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
        public static extern IntPtr gtk_label_new(string str);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_label_set_text(IntPtr label, string str);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_label_get_text(IntPtr label);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_label_set_xalign(IntPtr label, float xalign);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_label_set_yalign(IntPtr label, float yalign);

        [DllImport(Libraries.Gtk)]
        public static extern float gtk_label_get_xalign(IntPtr label);

        [DllImport(Libraries.Gtk)]
        public static extern float gtk_label_get_yalign(IntPtr label);
    }
}
