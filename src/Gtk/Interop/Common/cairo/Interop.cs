using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Interop
{
    internal static partial class cairo
    {
        [DllImport(Libraries.Cairo)]
        public static extern void cairo_set_source_rgb(IntPtr cr, double r, double g, double b);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_select_font_face(IntPtr cr, string family, _cairo_font_slant slant, cairo_font_weight_t weight);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_set_font_size(IntPtr cr, double size);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_show_text(IntPtr cr, string text);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_move_to(IntPtr cr, double x, double y);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_rectangle(IntPtr cr,
                 double x,
                 double y,
                 double width,
                 double height);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_rel_line_to(IntPtr cr, double dx, double dy);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_close_path(IntPtr cr);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_stroke_preserve(IntPtr cr);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_fill(IntPtr cr);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_set_line_width(IntPtr cr, int widith);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_arc(IntPtr cr,
           double xc,
           double yc,
           double radius,
           double angle1,
           double angle2);

        public enum _cairo_font_slant
        {
            CAIRO_FONT_SLANT_NORMAL,
            CAIRO_FONT_SLANT_ITALIC,
            CAIRO_FONT_SLANT_OBLIQUE
        }

        public enum cairo_font_weight_t
        {
            CAIRO_FONT_WEIGHT_NORMAL,
            CAIRO_FONT_WEIGHT_BOLD
        }
    }
}
