using System;

namespace Gtk
{
    public abstract class Bin : Container
    {
        public unsafe Bin() : base()
        {

        }

        public Bin(IntPtr handle)
            : base(handle)
        {

        }
    }
}
