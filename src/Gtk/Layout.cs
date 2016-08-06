using Gtk;
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
    public class Layout : Container
    {
        public Layout() : base()
        {
            handle = gtk_layout_new(IntPtr.Zero, IntPtr.Zero);

            RegisterObject();
        }

        public unsafe Layout(IntPtr handle)
            : base(handle)
        {

        }
    }
}
