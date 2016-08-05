using Gtk;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Gtk.Interop;
using static Gtk.Interop.gio;
using static Gtk.Interop.glib;
using static Gtk.Interop.gobj;
using static Gtk.Interop.gtk;

namespace Gtk
{
    public class ButtonBox : Container
    {
        public unsafe ButtonBox() : base()
        {
            handle = gtk_button_box_new(GtkOrientation.GTK_ORIENTATION_HORIZONTAL);

            RegisterObject();
        }

        public ButtonBox(IntPtr handle)
            : base(handle)
        {

        }
    }
}
