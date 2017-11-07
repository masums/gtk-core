using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Interop.Libraries;

namespace Interop
{
    internal static partial class glib
    {
        [DllImport(Libraries.GLib)]
        public static unsafe extern uint g_strv_length(char** str_array);

        [DllImport(Libraries.GLib)]
        public static extern uint g_timeout_add(uint interval, IntPtr function, IntPtr data);

        /// <summary>
        /// Flags used to define the behaviour of a GApplication.
        /// </summary>
        [Flags]
        public enum GApplicationFlags
        {
            /// <summary>
            /// Default
            /// </summary>
            G_APPLICATION_FLAGS_NONE,

            /// <summary>
            /// Run as a service. In this mode, registration fails if the service is already running, and the application will initially wait up to 10 seconds for an initial activation message to arrive.
            /// </summary>
            G_APPLICATION_IS_SERVICE,

            /// <summary>
            /// Don't try to become the primary instance.
            /// </summary>
            G_APPLICATION_IS_LAUNCHER,

            /// <summary>
            /// This application handles opening files (in the primary instance). Note that this flag only affects the default implementation of local_command_line(), and has no effect if G_APPLICATION_HANDLES_COMMAND_LINE is given. See g_application_run() for details.
            /// </summary>
            G_APPLICATION_HANDLES_OPEN,

            /// <summary>
            /// This application handles command line arguments (in the primary instance). Note that this flag only affect the default implementation of local_command_line(). See g_application_run() for details.
            /// </summary>
            G_APPLICATION_HANDLES_COMMAND_LINE,

            /// <summary>
            /// Send the environment of the launching process to the primary instance. Set this flag if your application is expected to behave differently depending on certain environment variables. For instance, an editor might be expected to use the GIT_COMMITTER_NAME environment variable when editing a git commit message. The environment is available to the “command-line” signal handler, via g_application_command_line_getenv().
            /// </summary>
            G_APPLICATION_SEND_ENVIRONMENT,

            /// <summary>
            /// Make no attempts to do any of the typical single-instance application negotiation, even if the application ID is given. The application neither attempts to become the owner of the application ID nor does it check if an existing owner already exists. Everything occurs in the local process. Since: 2.30.
            /// </summary>
            G_APPLICATION_NON_UNIQUE,

            /// <summary>
            /// Allow users to override the application ID from the command line with --gapplication-app-id. Since: 2.48
            /// </summary>
            G_APPLICATION_CAN_OVERRIDE_APP_ID
        }

        public unsafe struct GList
        {
            public IntPtr data;
            public GList* next;
            public GList* prev;
        }
    }
}
