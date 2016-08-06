using GObj.Internal;
using Gtk.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Gtk.Interop;
using static Gtk.Interop.gio;
using static Gtk.Interop.gtk;


namespace Gtk
{
    public abstract class Misc : Widget
    {
        public unsafe Misc() : base()
        {

        }

        public Misc(IntPtr handle)
            : base(handle)
        {

        }
    }
}
