﻿using GObj;
using System;

namespace Gdk
{
    public class Window : GObject
    {
        public Window() : base()
        {
            RegisterObject();
        }

        public Window(IntPtr handle) : base(handle)
        {
        }
    }
}
