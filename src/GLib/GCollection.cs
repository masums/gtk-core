using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Interop.glib;

namespace GLib
{
    public unsafe class GCollection<T> : IEnumerable<T>
    {
        private Node _instance;

        public GCollection(IntPtr instance)
        {
            _instance = new Node((IntPtr)instance);
        }

        protected Node Instance
        {
            get
            {
                return _instance;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetItems().GetEnumerator();
        }

        protected virtual IEnumerable<T> GetItems()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        protected unsafe class Node
        {
            private GList* handle;
            private Node next;
            private Node prev;

            public Node(IntPtr handle)
            {
                this.handle = (GList*)handle;
            }

            public IntPtr Data
            {
                get
                {
                    return handle->data;
                }
            }

            public Node Prev
            {
                get
                {
                    if (prev == null)
                    {
                        prev = new Node((IntPtr)handle->prev);
                    }
                    return prev;
                }
            }

            public Node Next
            {
                get
                {
                    if (next == null)
                    {
                        next = new Node((IntPtr)handle->next);
                    }
                    return next;
                }
            }
        }
    }
}
