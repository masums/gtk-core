using GObj.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static GObj.Interop.gobj;

namespace GObj
{
    /// <summary>
    /// Base class for all GObject. 
    /// This class should not be derived from outside of this library. 
    /// Constructors have been marked as internal.
    /// </summary>
    public abstract class GObject
    {
        protected IntPtr handle;

        private Dictionary<object, uint> signalHandlerMap;

        private delegate void SignalHandlerDelegate(IntPtr arg1, IntPtr arg2, IntPtr arg3);

        private delegate bool SignalHandlerDelegate2(IntPtr arg1, IntPtr arg2, IntPtr arg3);

        protected GObject()
        {
            this.signalHandlerMap = new Dictionary<object, uint>();
        }

        protected GObject(IntPtr handle) : this()
        {
            this.handle = handle;

            RegisterObject();
        }

        public string GType
        {
            get
            {
                var gType = Interop.gobj.g_object_get_type(handle);
                var ptr = Interop.gobj.g_type_name(gType);
                return StringHelpers.Utf8PtrToString(ptr);
            }
        }

        /// <summary>
        /// Registers an object to the ObjectManager.
        /// </summary>
        protected void RegisterObject()
        {
            ObjectManager.Register(handle, this);
        }

        /// <summary>
        /// Registers a signal handler. 
        /// </summary>
        /// <typeparam name="TEventArgs"></typeparam>
        /// <param name="name"></param>
        /// <param name="eventHandler"></param>
        /// <param name="process"></param>
        protected void AddSignalHandler<TEventArgs>(string name, EventHandler<TEventArgs> eventHandler, Action<IntPtr, IntPtr, IntPtr, EventHandler<TEventArgs>> process = null)
             where TEventArgs : EventArgs
        {
           var handlerId = g_signal_connect_data(handle, name, WrapEventHandler(this, eventHandler, process), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

            signalHandlerMap.Add(eventHandler, handlerId);
        }

        /// <summary>
        /// Registers a signal handler. 
        /// </summary>
        /// <typeparam name="TEventArgs"></typeparam>
        /// <param name="name"></param>
        /// <param name="eventHandler"></param>
        /// <param name="process"></param>
        protected void AddSignalHandler2<TEventArgs>(string name, EventHandler<TEventArgs> eventHandler, Func<IntPtr, IntPtr, IntPtr, EventHandler<TEventArgs>, bool> process = null)
             where TEventArgs : EventArgs
        {
            var handlerId = g_signal_connect_data(handle, name, WrapEventHandler(this, eventHandler, process), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

            signalHandlerMap.Add(eventHandler, handlerId);
        }

        protected void RemoveSignalHandler<TEventArgs>(EventHandler<TEventArgs> eventHandler)
             where TEventArgs : EventArgs
        {
            var handlerId = signalHandlerMap[eventHandler];

            signalHandlerMap.Remove(eventHandler);

            g_signal_handler_disconnect(Handle, handlerId);
        }

        private static IntPtr WrapEventHandler<TEventArgs>(object instance, EventHandler<TEventArgs> eventHandler, Action<IntPtr, IntPtr, IntPtr, EventHandler<TEventArgs>> process)
            where TEventArgs : EventArgs
        {
            var ptr = Marshal.GetFunctionPointerForDelegate<SignalHandlerDelegate>((a, b, c) => {
                if (process != null)
                {
                    process(a, b, c, eventHandler);
                }
                else
                {
                    eventHandler(instance, Activator.CreateInstance<TEventArgs>());
                }
            });
            return ptr;
        }

        private static IntPtr WrapEventHandler<TEventArgs>(object instance, EventHandler<TEventArgs> eventHandler, Func<IntPtr, IntPtr, IntPtr, EventHandler<TEventArgs>, bool> process)
            where TEventArgs : EventArgs
        {
            var ptr = Marshal.GetFunctionPointerForDelegate<SignalHandlerDelegate2>((a, b, c) => {
                bool result = false;

                if (process != null)
                {
                    result = process(a, b, c, eventHandler);
                }
                else
                {
                    eventHandler(instance, Activator.CreateInstance<TEventArgs>());
                }

                return result;
            });
            return ptr;
        }

        /// <summary>
        /// Gets a safe pointer to the underlying GLib object.
        /// </summary>
        public unsafe IntPtr Handle
        {
            get
            {
                return handle;
            }
        }

        public override int GetHashCode()
        {
            return handle.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        ~GObject()
        {
            ObjectManager.Unregister(handle);
        }
    }
}