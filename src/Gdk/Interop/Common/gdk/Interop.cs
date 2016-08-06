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
            //IntPtr gdk_window_new(GdkWindow* parent,
            //    GdkWindowAttr* attributes,
            //    int attributes_mask);

            [DllImport(Libraries.Gdk)]
            public static extern IntPtr gdk_cairo_create(IntPtr window);

            //public unsafe struct GdkWindowAttr
            //{
            //    char* title;
            //    int event_mask;
            //    int x, y;
            //    int width;
            //    int height;
            //    GdkWindowWindowClass wclass;
            //    GdkVisual* visual;
            //    GdkWindowType window_type;
            //    GdkCursor* cursor;
            //    char* wmclass_name;
            //    char* wmclass_class;
            //    boolean override_redirect;
            //    GdkWindowTypeHint type_hint;
            //};
        }
    }
}
