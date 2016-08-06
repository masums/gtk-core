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
    public abstract class Bin : Container
    {
        public unsafe Bin() : base()
        {

        }

        public Bin(IntPtr handle)
            : base(handle)
        {

        }

        public override void Add(Widget widget)
        {
            if(Child != null)
            {
                throw new InvalidOperationException("Already has a child");
            }

            base.Add(widget);
        }

        public Widget Child
        {
            get
            {
                var parent = gtk_bin_get_child(handle);
                return ObjectManager.Resolve<Container>(parent);
            }
        }
    }
}
