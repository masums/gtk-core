using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Gdk
{
    internal static partial class Interop
    {
        internal static partial class gdk
        {
            [DllImport(Libraries.Gdk)]
            public static extern IntPtr gdk_cairo_create(IntPtr window);
        }
    }
}
