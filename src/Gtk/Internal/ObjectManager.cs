using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk.Internal
{
    /// <summary>
    /// Keeps track of all CLR objects that wrap GObject handlers.
    /// </summary>
    internal static class ObjectManager
    {
        private static Dictionary<IntPtr, GObject> _list = new Dictionary<IntPtr, GObject>();

        /// <summary>
        /// Registers an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handle"></param>
        /// <param name="obj"></param>
        public static void Register<T>(IntPtr handle, T obj)
            where T : GObject
        {
            _list.Add(handle, obj);
        }

        /// <summary>
        /// Gets or creates an object wrapper for a specified handle.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static T Resolve<T>(IntPtr handle)
            where T : GObject
        {
            if (handle == IntPtr.Zero)
                return null;

            GObject obj = null;
            if(!_list.TryGetValue(handle, out obj))
            {
                obj = (T)Activator.CreateInstance(typeof(T), new[] { handle });
                _list.Add(handle, obj);
            }

            return (T)obj;
        }

        /// <summary>
        /// Unregisters an object.
        /// </summary>
        /// <param name="handle"></param>
        public static void Unregister(IntPtr handle)
        {
            _list.Remove(handle);
        }
    }
}
