using Gtk.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk
{
    public class DrawingContext : IDisposable
    {
        private IntPtr handle;
        internal bool propagate = false;

        public IntPtr Handle
        {
            get { return handle; }
        }

        public DrawingContext(IntPtr handle)
        {
            this.handle = handle;
        }

        public void SetSourceRgb(double r, double g, double b)
        {
            Interop.cairo.cairo_set_source_rgb(handle, r, g, b);
        }

        public void SelectFontFace(string family)
        {
            Interop.cairo.cairo_select_font_face(handle, family, Interop.cairo._cairo_font_slant.CAIRO_FONT_SLANT_NORMAL, Interop.cairo.cairo_font_weight_t.CAIRO_FONT_WEIGHT_NORMAL);
        }

        public void SetFontSize(double size)
        {
            Interop.cairo.cairo_set_font_size(handle, size);
        }

        public void MoveTo(double x, double y)
        {
            Interop.cairo.cairo_move_to(handle, x, y);
        }

        public void ShowText(string text)
        {
            Interop.cairo.cairo_show_text(handle, text);
        }

        public void DrawRectangle(double x, double y, double width, double height) 
        {
            Interop.cairo.cairo_rectangle(handle, x, y, width, height);
        }

        public void SetLineWidth(int width) 
        {
            Interop.cairo.cairo_set_line_width(handle, width);
        }

        public void StrokePreserve()
        {
            Interop.cairo.cairo_stroke_preserve(handle);
        }

        public void Fill()
        {
            Interop.cairo.cairo_fill(handle);
        }

        public void Dispose()
        {
            propagate = false;
            handle = IntPtr.Zero;
        }
    }
}
