using GIO;
using GObj.Internal;
using System;
using System.Collections.Generic;
using static Gtk.Interop.gio;
using static Gtk.Interop.gtk;

namespace Gtk
{
    public partial class Application : GIO.Application
    {
        public Application(string applicationId) : this(applicationId, ApplicationFlags.None)
        {

        }

        public Application(string applicationId, ApplicationFlags flags) : base(applicationId, flags, false)
        {
            handle = gtk_application_new(applicationId, (GApplicationFlags)flags);

            RegisterObject();
        }

        protected Application(IntPtr handler) : base(handler)
        {

        }

        internal Application() : base(null, ApplicationFlags.None, false)
        {
            
        }

        public virtual Window ActiveWindow
        {
            get
            {
                var ptr = gtk_application_get_active_window(handle);
                return ObjectManager.Resolve<Window>(ptr);
            }
        }

        public virtual IEnumerable<Window> Windows { get; }

        public static void Init()
        {
            Init(null);
        }

        public static void Init(string[] args)
        {
            if (Application.Current != null)
                throw new InvalidOperationException("Application cannot be initialized when another is already running.");

            Current = new Application.Main();

            gtk_init(args?.Length ?? 0, args);
        }

        public static void GtkMain()
        {
            gtk_main();
        }

        public static void Exit(int errorCode)
        {
            Environment.Exit(errorCode);
        }
    }
}
