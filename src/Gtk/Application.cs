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
    public class Application : GObject
    {
        private Window window;
        private string[] args;

        protected Application() : base()
        {
            handle = gtk_application_new(ApplicationId, GApplicationFlags.G_APPLICATION_FLAGS_NONE);

            RegisterObject();
        }

        protected Application(IntPtr handler) : base(handler)
        {

        }

        public string ApplicationId { get; set; }

        protected virtual int OnActivated(Application application, string[] args)
        {
            return 0;
        }

        private int Start(string[] args)
        {
            Current = this;

            int status = 0;

            Activated += OnActivated;

            status = g_application_run(Handle, args.Length, args);

            return status;
        }

        protected virtual void OnActivated(object sender, EventArgs e)
        {
            
        }

        public event EventHandler<EventArgs> Activated
        {
            add
            {
                AddSignalHandler("activate", value, handleActivated);
            }

            remove
            {
                RemoveSignalHandler(value);
            }
        }

        private void handleActivated(IntPtr arg1, IntPtr arg2, IntPtr arg3, EventHandler<EventArgs> handler)
        {
            handler(this, new EventArgs());
        }

        public static int Run<T>(string[] args)
            where T : Application
        {
            var app = (T)Activator.CreateInstance<T>();
            return app.Start(args);
        }

        private void OnActivatedCore(IntPtr app, IntPtr user_data)
        {
            OnActivated(this, args);
        }

        public static Application Current { get; private set; }

        public Window ActiveWindow
        {
            get
            {
                var ptr = gtk_application_get_active_window(handle);
                return ObjectManager.Resolve<Window>(ptr);
            }
        }

        public IEnumerable<Window> Windows { get; }
    }
}
