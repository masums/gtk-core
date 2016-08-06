using GObj;
using System;

namespace Gdk
{

    public class Device : GObject
    {
        public Device() : base()
        {
            RegisterObject();
        }

        public Device(IntPtr handle) : base(handle)
        {
        }
    }
}