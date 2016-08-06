using System;

namespace Gtk
{

    public class CairoEventArgs : EventArgs
    {
        private DrawingContext context;

        internal CairoEventArgs(DrawingContext context)
        {
            this.context = context;
        }

        public DrawingContext GetDrawingContext()
        {
            return context;
        }
    }
}