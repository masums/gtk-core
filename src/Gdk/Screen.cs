using GObj;
using System;

namespace Gdk
{

    public class Screen : GObject
    {
        public Screen() : base()
        {
            RegisterObject();
        }

        public Screen(IntPtr handle) : base(handle)
        {
        }
    }
}