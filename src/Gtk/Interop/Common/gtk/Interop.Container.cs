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
        public static extern void gtk_container_add(IntPtr container, IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_container_remove(IntPtr container, IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static unsafe extern IntPtr gtk_container_get_children(IntPtr container);
    }
}
