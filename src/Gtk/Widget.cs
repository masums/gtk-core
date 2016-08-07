using Gdk;
using GObj;
using GObj.Internal;
using Gtk;
using Gtk.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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

        public Gdk.Window GdkWindow
        {
            get
            {
                var ptr = gtk_widget_get_window(handle);
                return ObjectManager.Resolve<Gdk.Window>(ptr);
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
            gtk_widget_show_all(handle);
        }

        public virtual void ShowNow()
        {
            gtk_widget_show_now(handle);
        }

        public virtual void Hide()
        {
            gtk_widget_hide(handle);
        }

        public void Destroy()
        {
            gtk_widget_destroy(handle);
        }

        public void QueueDraw()
        {
            gtk_widget_queue_draw(handle);
        }

        public Margin Margin
        {
            get
            {
                var left = gtk_widget_get_margin_left(handle);
                var right = gtk_widget_get_margin_right(handle);
                var top = gtk_widget_get_margin_top(handle);
                var bottom = gtk_widget_get_margin_bottom(handle);
                return new Margin(left, right, top, bottom);
            }
        }

        public void SetMargin(int leftRight, int topBottom)
        {
            gtk_widget_set_margin_left(handle, leftRight);
            gtk_widget_set_margin_right(handle, leftRight);
            gtk_widget_set_margin_top(handle, topBottom);
            gtk_widget_set_margin_bottom(handle, topBottom);
        }

        public void SetMargin(int left, int right, int top, int bottom)
        {
            gtk_widget_set_margin_left(handle, left);
            gtk_widget_set_margin_right(handle, right);
            gtk_widget_set_margin_top(handle, top);
            gtk_widget_set_margin_bottom(handle, bottom);
        }

        ~Widget()
        {
            gtk_widget_destroy(handle);
        }
    }
}
