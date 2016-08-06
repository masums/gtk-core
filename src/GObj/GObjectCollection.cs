using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GLib;
using GObj.Internal;

namespace GObj
{
    public class GObjectCollection<T> : GCollection<T>
        where T : GObject
    {
        public GObjectCollection(IntPtr instance) : base(instance)
        {
        }

        protected override IEnumerable<T> GetItems()
        {
            var items = new List<T>();

            var current = Instance;

            while (true)
            {
                if (current == null)
                    break;

                var data = current.Data;
                var match = (T)ObjectManager.Resolve<GObject>(data);

                items.Add(match);

                current = current.Next;
            }

            return items;
        }
    }
}
