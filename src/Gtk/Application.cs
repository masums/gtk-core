using Gtk;
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
    public class Application
    {
        private Window window;
        private string[] args;
        private IntPtr handle;

        protected Application()
        {

        }

        public string ApplicationId { get; set; }

        public virtual int OnActivated(Application application, string[] args)
        {
            return 0;
        }

        public int Run(string[] args)
        {
            Current = this;
            int status = 0;

            CommonDelegate onActivatedCore = OnActivatedCore;

            handle = gtk_application_new(ApplicationId, GApplicationFlags.G_APPLICATION_FLAGS_NONE);
            g_signal_connect_data(handle, "activate", Marshal.GetFunctionPointerForDelegate(onActivatedCore), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
            g_application_run(Handle, args.Length, args);
            return status;
        }

        private void OnActivatedCore(IntPtr app, IntPtr user_data)
        {
            OnActivated(this, args);
        }

        public static Application Current { get; private set; }

        public Window ActiveWindow
        {
            get;
            internal set;
        }

        public IEnumerable<Window> Windows { get; }

        public IntPtr Handle
        {
            get
            {
                return handle;
            }
        }
    }
}
