using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static Gtk.Interop.glib;
using static Gtk.Interop.gobj;
using static Gtk.Interop.gio;
using static Gtk.Interop.gtk;
using System.Runtime.InteropServices;
using static Gtk.Interop;

namespace Gtk
{
    public class InteropTests
    {
        private static void Test1(string[] args)
        {
            IntPtr window;

            gtk_init(args.Length, args);

            window = gtk_window_new(GtkWindowType.GTK_WINDOW_TOPLEVEL);
            gtk_window_set_title(window, "test");
            gtk_widget_show(window);

            g_signal_connect_data(window, "destroy",
                Marshal.GetFunctionPointerForDelegate<MyDelegate2>(gtk_main_quit), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

            gtk_main();
        }

        private static int Test2(string[] args)
        {
            IntPtr app;
            int status;

            app = gtk_application_new("org.gtk.example", GApplicationFlags.G_APPLICATION_FLAGS_NONE);
            g_signal_connect_data(app, "activate", Marshal.GetFunctionPointerForDelegate<CommonDelegate>(activate2), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
            status = g_application_run(app, args.Length, args);
            g_object_unref(app);

            return status;
        }

        private static void activate(IntPtr app, IntPtr user_data)
        {
            IntPtr window;

            window = gtk_application_window_new(app);
            gtk_window_set_title(window, "Window");
            gtk_window_set_default_size(window, 200, 200);
            gtk_widget_show_all(window);
        }

        static void print_hello(IntPtr widget, IntPtr data)
        {
            Console.WriteLine("Hello World\n");
        }

        private static void activate2(IntPtr app, IntPtr user_data)
        {
            IntPtr window;
            IntPtr button;
            IntPtr button_box;

            window = gtk_application_window_new(app);
            gtk_window_set_title(window, "Window");
            gtk_window_set_default_size(window, 200, 200);

            button_box = gtk_button_box_new(GtkOrientation.GTK_ORIENTATION_HORIZONTAL);
            gtk_container_add(window, button_box);

            button = gtk_button_new_with_label("Hello World");
            g_signal_connect_data(button, "clicked", Marshal.GetFunctionPointerForDelegate<CommonDelegate>(print_hello), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
            g_signal_connect_data(button, "clicked", Marshal.GetFunctionPointerForDelegate<MyDelegate>(gtk_widget_destroy), window, null, GConnectFlags.G_CONNECT_SWAPPED);
            gtk_container_add(button_box, button);

            gtk_widget_show_all(window);
        }

        delegate void MyDelegate(IntPtr arg);

        delegate void MyDelegate2();
    }
}
