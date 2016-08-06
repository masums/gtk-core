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
    public abstract partial class Widget : GObject
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
                if (Parent == null)
                    return null;

                return WidgetHelpers.GetWindow(Parent);
            }

            set
            {
                SetWindowCore(value);
            }
        }

        public void SetSizeRequest(int width, int height)
        {
            gtk_widget_set_size_request(handle, width, height);
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

        public virtual void Show()
        {
            gtk_widget_show(Handle);
        }

        public virtual void ShowAll()
        {
            gtk_widget_show_all(Handle);
        }

        public virtual void ShowNow()
        {
            gtk_widget_show_now(Handle);
        }

        public virtual void Hide()
        {
            gtk_widget_hide(Handle);
        }

        public void Destroy()
        {
            gtk_widget_destroy(Handle);
        }

        public void QueueDraw()
        {
            gtk_widget_queue_draw(Handle);
        }

        ~Widget()
        {
            gtk_widget_destroy(handle);
        }

        public event EventHandler<CairoEventArgs> Draw
        {
            add
            {
                AddSignalHandler2<CairoEventArgs>("draw", value, (a1, a2, a3, handler) =>
                {
                    var drawingContext = new DrawingContext(a2);
                    var eventArgs = new CairoEventArgs(drawingContext);
                    handler(this, eventArgs);

                    return true;
                });
            }

            remove
            {
                RemoveSignalHandler<CairoEventArgs>(value);
            }
        }
    }
}
