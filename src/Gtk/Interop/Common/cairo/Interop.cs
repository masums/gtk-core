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
        public static extern void cairo_set_source_rgb(IntPtr cr, int r, int g, int b);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_select_font_face(IntPtr cr, string family, _cairo_font_slant slant, cairo_font_weight_t weight);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_set_font_size(IntPtr cr, double size);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_show_text(IntPtr cr, string text);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_move_to(IntPtr cr, double x, double y);

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
