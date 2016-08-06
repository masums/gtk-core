using GObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gdk
{
    public class Window : GObject
    {
        public Window(IntPtr handle) : base(handle)
        {
        }
    }
}
