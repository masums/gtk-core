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
using static Gtk.Interop.glib;
using static Gtk.Interop.gobj;
using static Gtk.Interop.gtk;

namespace Gtk
{
    public class ApplicationWindow : Window
    {
        public unsafe ApplicationWindow() : base()
        {
            handle = gtk_application_window_new(Application.Current.Handle);

            RegisterObject();
        }

        public ApplicationWindow(IntPtr handle)
            : base(handle)
        {

        }

    }
}
