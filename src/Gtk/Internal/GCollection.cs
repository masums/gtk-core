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
           where T : GObject
    {
        private GList* _instance;

        public GCollection(GList* instance)
        {
            _instance = instance;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetItems().GetEnumerator();
        }

        private IEnumerable<T> GetItems()
        {
            var items = new List<T>();

            var current = _instance;

            while(true)
            {
                if (current == null)
                    break;

                var data = current->data;
                var match = (T)ObjectManager.Resolve<GObject>(data);

                items.Add(match);

                current = current->next;
            }

            return items;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
