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
    public abstract class Container : Widget
    {
        public Container() : base()
        {

        }

        public unsafe Container(IntPtr handle)
            : base(handle)
        {

        }

        public virtual void Add(Widget widget)
        {
            gtk_container_add(Handle, widget.Handle);
        }

        public virtual void Remove(Widget widget)
        {
            gtk_container_remove(Handle, widget.Handle);
        }

        public unsafe virtual IEnumerable<Widget> GetChildren()
        {
            var ptr = gtk_container_get_children(handle);
            return new GCollection<Widget>(ptr);
        }
    }
}
