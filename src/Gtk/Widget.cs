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
    public abstract class Widget : GObject
    {
        private IntPtr window;
        private IntPtr parent;

        public Widget()
            : base()
        {

        }

        public Widget(IntPtr handle)
            : base(handle)
        {
            
        }

        public string Name
        {
            get
            {
                var ptr = gtk_widget_get_name(handle);
                return StringHelpers.Utf8PtrToString(ptr);
            }
            set
            {
                gtk_widget_set_name(handle, value);
            }
        }

        public event EventHandler<EventArgs> Destroyed
        {
            add
            {
                AddSignalHandler<EventArgs>("destroy", value, handleDestroyed);
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        private void handleDestroyed(IntPtr instance, IntPtr data, EventHandler<EventArgs> handler)
        {
            handler(this, new EventArgs());
        }

        public event EventHandler<EventArgs> Shown
        {
            add
            {
                AddSignalHandler<EventArgs>("show", value, handleShown);
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        private void handleShown(IntPtr instance, IntPtr data, EventHandler<EventArgs> handler)
        {
            handler(this, new EventArgs());
        }

        public Container Parent
        {
            get
            {
                var parent = gtk_widget_get_parent(handle);
                return ObjectManager.Resolve<Container>(parent);
            }

            set
            {
                SetParentCore(value);
            }
        }

        public Window Window
        {
            get
            {
                var window = gtk_widget_get_window(handle);
                return ObjectManager.Resolve<Window>(window);
            }

            set
            {
                SetWindowCore(value);
            }
        }

        internal void SetParentCore(Container parent)
        {
            if (parent == null)
            {
                gtk_widget_set_parent(handle, IntPtr.Zero);
            }
            else
            {
               gtk_widget_set_parent(handle, parent.handle);
            }
        }

        internal void SetWindowCore(Window window)
        {
            if (window == null)
            {
                gtk_widget_set_window(handle, IntPtr.Zero);
            }
            else
            {
                gtk_widget_set_window(handle, window.handle);
            }
        }

        ~Widget()
        {
            gtk_widget_destroy(handle);
        }
    }
}
