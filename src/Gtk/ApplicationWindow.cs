using Gtk;
using Gtk.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Gtk.Interop;
using static Gtk.Interop.gio;
using static Gtk.Interop.gtk;

namespace Gtk
{
    public class ApplicationWindow : Window
    {
        public unsafe ApplicationWindow() : base(false)
        {
            _InitializeWindow();
        }

        new private unsafe void _InitializeWindow()
        {
            var app = Application.Current;
            if (app == null)
            {
                throw new InvalidOperationException("No Application has been initialized.");
            }
            if (!WidgetHelpers.IsApplicationMain(app))
            {
                handle = gtk_application_window_new(Application.Current.Handle);

                RegisterObject();
            }
            else
            {
                // Fallback to the Window implementation.

                base._InitializeWindow();
            }
        }

        public ApplicationWindow(IntPtr handle)
            : base(handle)
        {

        }
    }
}
