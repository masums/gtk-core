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
        public static extern IntPtr gtk_layout_new(IntPtr hadjustment, IntPtr vadjustment);
    }
}
