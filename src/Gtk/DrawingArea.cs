using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public event EventHandler<CairoDrawEventArgs> Draw
        {
            add
            {
                AddSignalHandler2<CairoDrawEventArgs>("draw", value, (a1, a2, a3, handler) =>
                {
                    var drawingContext = new DrawingContext(a2);
                    var eventArgs = new CairoDrawEventArgs(drawingContext);
                    handler(this, eventArgs);

                    return !eventArgs.Context._continue;
                });
            }

            remove
            {
                RemoveSignalHandler<CairoDrawEventArgs>(value);
            }
        }
    }

    public class CairoDrawEventArgs : EventArgs
    {
        internal CairoDrawEventArgs(DrawingContext context)
        {
            Context = context;
        }

        public DrawingContext Context { get; private set; }
    }
}
