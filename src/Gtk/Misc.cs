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

        public Alignment Alignment
        {
            get
            {
                float xalign, yalign;
                gtk_misc_get_alignment(handle, out xalign, out yalign);
                return new Alignment(xalign, yalign);
            }
        }

        public void SetAlignment(float xalign, float yalign)
        {
            gtk_misc_set_alignment(handle, xalign, yalign);
        }

        public Padding Padding
        {
            get
            {
                float xpad, ypad;
                gtk_misc_get_padding(handle, out xpad, out ypad);
                return new Padding(xpad, ypad);
            }
        }

        public void SetPadding(float xpad, float ypad)
        {
            gtk_misc_set_padding(handle, xpad, ypad);
        }
    }
}
