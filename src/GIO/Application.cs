using System;
using GObj;
using static GIO.Interop.gio;

namespace GIO
{
    public class Application : GObject
    {
        public Application(string applicationId) : this(applicationId, ApplicationFlags.None)
        {

        }

        public Application(string applicationId, ApplicationFlags flags) : this(applicationId, flags, true)
        {
            
        }

        protected Application(string applicationId, ApplicationFlags flags, bool run) : base()
        {
            if (run)
            {
                handle = g_application_new(ApplicationId, (GApplicationFlags)flags);

                RegisterObject();
            }
        }

        protected Application(IntPtr handler) : base(handler)
        {

        }

        public virtual string ApplicationId
        {
            get
            {
                var ptr = g_application_get_application_id(handle);
                return StringHelpers.Utf8PtrToString(ptr);
            }
            set
            {
                g_application_set_application_id(handle, value);
            }
        }

        private void OnActivatedCore(object sender, EventArgs e)
        {
            OnActivated(sender, e);
        }

        protected virtual int OnActivated(object sender, EventArgs e)
        {
            return 0;
        }

        public int Run(string[] args)
        {
            if(Current != null)
            {
                throw new InvalidOperationException("Cannot launch the Application when another is running.");
            }

            Current = this;

            int status = 0;

            Activated += OnActivatedCore;

            status = g_application_run(handle, args.Length, args);

            return status;
        }

        public virtual event EventHandler<EventArgs> Activated
        {
            add
            {
                RegisterSignalHandler<EventArgs>("activate", value, handleActivated);
            }

            remove
            {
                UnregisterSignalHandler(value);
            }
        }

        private void handleActivated(IntPtr arg1, IntPtr arg2, IntPtr arg3, EventHandler<EventArgs> handler)
        {
            handler(this, EventArgs.Empty);
        }

        public static Application Current { get; protected internal set; }

        public void Exit(int errorCode)
        {
            Environment.Exit(errorCode);
        }
    }
}
