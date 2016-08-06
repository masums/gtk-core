using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static GObj.Interop;
using static GObj.Interop.Libraries;

namespace GObj
{
    internal static partial class Interop
    {
        public delegate void CommonDelegate(IntPtr subject, IntPtr data);

        internal static partial class gobj
        {
            [DllImport(Libraries.GObj)]
            public static extern void g_object_unref(IntPtr application);

            [Obsolete("Is no longer supported as of GTK+ 3.")]
            [DllImport(Libraries.GObj)]
            public static extern uint g_signal_connect(IntPtr instance, string detailed_signal, IntPtr handler, IntPtr data);

            [DllImport(Libraries.GObj)]
            public static extern uint g_signal_connect_data(IntPtr instance, string detailed_signal, IntPtr handler, IntPtr data, GClosureNotify destroy_data, GConnectFlags connect_flags);

            [DllImport(Libraries.GObj)]
            public static extern uint g_signal_connect_swapped(IntPtr instance, string detailed_signal, IntPtr handler, IntPtr data);

            [DllImport(Libraries.GObj)]
            public static extern uint g_signal_handler_disconnect(IntPtr instance, uint handler_id);

            [DllImport(Libraries.GObj)]
            public static extern uint g_object_get_type(IntPtr instance);

            [DllImport(Libraries.GObj)]
            public static extern IntPtr g_type_name(uint typeId);

            public unsafe delegate void GCallback(IntPtr source, IntPtr user_data);

            public delegate void GClosureNotify();

            /// <summary>
            /// The connection flags are used to specify the behaviour of a signal's connection.
            /// </summary>
            [Flags]
            public enum GConnectFlags
            {
                /// <summary>
                /// whether the handler should be called before or after the default handler of the signal.
                /// </summary>
                G_CONNECT_AFTER,

                /// <summary>
                /// whether the instance and data should be swapped when calling the handler; see g_signal_connect_swapped() for an example.
                /// </summary>
                G_CONNECT_SWAPPED
            }
        }
    }
}
