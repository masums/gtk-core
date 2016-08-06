using GObj;
using System;

namespace Gdk
{

    public class Display : GObject
    {
        public Display() : base()
        {
            RegisterObject();
        }

        public Display(IntPtr handle) : base(handle)
        {
        }
    }
}