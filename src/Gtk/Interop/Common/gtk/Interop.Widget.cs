using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static Interop.Libraries;

namespace Interop
{
    internal static partial class gtk
    {
        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_show(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_show_all(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_show_now(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_hide(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_destroy(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_name(IntPtr widget, string name);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_widget_get_name(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_parent(IntPtr widget, IntPtr parent);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_widget_get_parent(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_window(IntPtr widget, IntPtr window);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_widget_get_window(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern uint gtk_widget_get_type(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_queue_draw(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_queue_draw_area(IntPtr widget,
                        int x,
                        int y,
                        int width,
                        int height);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_size_request(IntPtr widget,
                      int width,
                      int height);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_margin_left(IntPtr widget, int margin);

        [DllImport(Libraries.Gtk)]
        public static extern int gtk_widget_get_margin_left(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_margin_right(IntPtr widget, int margin);

        [DllImport(Libraries.Gtk)]
        public static extern int gtk_widget_get_margin_right(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_margin_start(IntPtr widget, int margin);

        [DllImport(Libraries.Gtk)]
        public static extern int gtk_widget_get_margin_start(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_margin_end(IntPtr widget, int margin);

        [DllImport(Libraries.Gtk)]
        public static extern int gtk_widget_get_margin_end(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_margin_top(IntPtr widget, int margin);

        [DllImport(Libraries.Gtk)]
        public static extern int gtk_widget_get_margin_top(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_widget_set_margin_bottom(IntPtr widget, int margin);

        [DllImport(Libraries.Gtk)]
        public static extern int gtk_widget_get_margin_bottom(IntPtr widget);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_widget_get_parent_window(IntPtr widget);
    }
}
