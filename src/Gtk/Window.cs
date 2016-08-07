using GObj;
using GObj.Internal;
using System;
using System.Diagnostics;
using static Gtk.Interop.gtk;

namespace Gtk
{
    public class Window : Bin
    {
        public unsafe Window() : this(true)
        {
            _InitializeWindow();
        }

        protected unsafe Window(bool run) : base()
        {
            if(run)
            {
                _InitializeWindow();
            }
        }

        [DebuggerHidden]
        protected unsafe void _InitializeWindow()
        {
            handle = gtk_window_new(GtkWindowType.GTK_WINDOW_TOPLEVEL);

            RegisterObject();
        }

        public Window(IntPtr handle)
            : base(handle)
        {

        }

        public void SetDefaultSize(int width, int height)
        {
            gtk_window_set_default_size(handle, width, height);
        }

        public void Resize(int width, int height)
        {
            gtk_window_resize(handle, width, height);
        }

        public string Title
        {
            get
            {
                var ptr = gtk_window_get_title(handle);
                return StringHelpers.Utf8PtrToString(ptr);
            }
            set
            {
                gtk_window_set_title(handle, value);
            }
        }

        public bool IsActive
        {
            get
            {
                return gtk_window_is_active(handle);
            }
        }

        public bool IsModel
        {
            get
            {
                return gtk_window_get_modal(handle);
            }
            set
            {
                gtk_window_set_modal(handle, value);
            }
        }

        public bool IsMaximized
        {
            get
            {
                return gtk_window_is_maximized(handle);
            }
        }

        public Widget Focus
        {
            get
            {
                var ptr = gtk_window_get_focus(handle);
                return ObjectManager.Resolve<Widget>(ptr);
            }

            set
            {
                gtk_window_set_focus(handle, value.Handle);
            }
        }

        public void Close()
        {
            gtk_window_close(Handle);
        }

        public void Maximize()
        {
            gtk_window_maximize(Handle);
        }

        public void Unmaximize()
        {
            gtk_window_unmaximize(Handle);
        }

        public void Fullscreen()
        {
            gtk_window_fullscreen(Handle);
        }

        public void Unfullscreen()
        {
            gtk_window_unfullscreen(Handle);
        }

        public Size Size
        {
            get
            {
                int width = 0, height = 0;
                gtk_window_get_size(handle, ref width, ref height);
                return new Size(width, height);
            }
        }
    }
}
