using GIO;
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
using static Gtk.Interop;
using static Gtk.Interop.gio;
using static Gtk.Interop.gtk;

namespace Gtk
{
    public class Application : GIO.Application
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
