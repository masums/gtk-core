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
            public static extern void gtk_main();

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_main_quit();

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_init(int argc, string[] argv);

            [Obsolete]
            [DllImport(Libraries.Gtk)]
            public static extern void gtk_exit(int error_code);

            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_drawing_area_new();

            [DllImport(Libraries.Gtk)]
            public static extern IntPtr gtk_image_new_from_file(string filename);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_misc_set_alignment(IntPtr misc,
                        float xalign,
                        float yalign);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_misc_set_padding(IntPtr misc,
                        float xpad,
                        float ypad);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_misc_get_alignment(IntPtr misc,
                    out float xalign,
                    out float yalign);

            [DllImport(Libraries.Gtk)]
            public static extern void gtk_misc_get_padding(IntPtr misc,
                       out float xpad,
                       out float ypad);

            public enum GtkWindowType
            {
                GTK_WINDOW_TOPLEVEL,
                GTK_WINDOW_POPUP
            }

            public enum GtkOrientation
            {
                GTK_ORIENTATION_HORIZONTAL,
                GTK_ORIENTATION_VERTICAL
            }
        }
    }
}
