using System;

namespace Gtk
{
    public class DrawingArea : Widget
    {
        public DrawingArea() : base()
        {
            handle = Gtk.Interop.gtk.gtk_drawing_area_new();

            RegisterObject();
        }

        public unsafe DrawingArea(IntPtr handle)
            : base(handle)
        {

        }
    }
}
