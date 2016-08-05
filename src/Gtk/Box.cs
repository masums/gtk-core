using System;

namespace Gtk
{

    public abstract class Box : Container
    {
        public unsafe Box() : base()
        {

        }

        public Box(IntPtr handle)
            : base(handle)
        {

        }
    }
}