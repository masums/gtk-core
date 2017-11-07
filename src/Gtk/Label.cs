using GObj;
using Gtk;
using Gtk.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static Interop.gio;
using static Interop.gtk;

namespace Gtk
{
    public class Label : Misc
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

        public float XAlign
        {
            get
            {
                return gtk_label_get_xalign(handle);
            }

            set
            {
                gtk_label_set_xalign(handle, value);
            }
        }

        public float YAlign
        {
            get
            {
                return gtk_label_get_yalign(handle);
            }

            set
            {
                gtk_label_set_yalign(handle, value);
            }
        }
    }
}
