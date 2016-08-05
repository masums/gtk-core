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
    public class Label : Widget
    {
        public unsafe Label() : base()
        {
            handle = gtk_label_new(string.Empty);

            RegisterObject();
        }

        public Label(IntPtr handle)
            : base(handle)
        {

        }

        public string Text
        {
            get
            {
                var ptr = gtk_label_get_text(handle);
                return StringHelpers.Utf8PtrToString(ptr);
            }
            set
            {
                gtk_label_set_text(handle, value);
            }
        }
    }
}
