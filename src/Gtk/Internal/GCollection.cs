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

namespace Gtk.Internal
{
    unsafe class GCollection<T> : IEnumerable<T>
           where T : Widget
    {
        private GList* _instance;
        private List<T> items = new List<T>();

        public GCollection(GList* instance)
        {
            _instance = instance;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return NewMethod().GetEnumerator();
        }

        private IEnumerable<T> NewMethod()
        {
            var items = new List<T>();

            var current = _instance->next;
            while (current != null)
            {
                var data = current->data;
                var match = this.items.FirstOrDefault(x => x.Handle == data);
                if (match != null)
                {
                    match = (T)Activator.CreateInstance(typeof(T), new[] { data });
                    this.items.Add(match);
                }

                items.Add(match);

                current = _instance->next;
            }

            return items;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
