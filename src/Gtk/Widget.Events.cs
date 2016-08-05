using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk
{
    public partial class Widget
    {
        public event EventHandler<EventArgs> ButtonPressed
        {
            add
            {
                AddSignalHandler<EventArgs>("button-press-event", value, (a1, a2, a3, handler) => {
                    unsafe
                    {
                        var ev = (Interop.gdk.GdkEventButton*)(void*)a2.ToPointer();
                    }
                });
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> ButtonReleased
        {
            add
            {
                AddSignalHandler<EventArgs>("button-release-event", value);
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> ChildNotify
        {
            add
            {
                AddSignalHandler<EventArgs>("child-notify", value);
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> CompositedChanged
        {
            add
            {
                AddSignalHandler<EventArgs>("composited-changed", value);
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> Destroyed
        {
            add
            {
                AddSignalHandler<EventArgs>("destroy", value, handleDestroyed);
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> Shown
        {
            add
            {
                AddSignalHandler<EventArgs>("show", value, handleShown);
            }

            remove
            {
                RemoveSignalHandler<EventArgs>(value);
            }
        }

        private void handleDestroyed(IntPtr arg1, IntPtr arg2, IntPtr arg3, EventHandler<EventArgs> handler)
        {
            handler(this, new EventArgs());
        }

        private void handleShown(IntPtr arg1, IntPtr arg2, IntPtr arg3, EventHandler<EventArgs> handler)
        {
            handler(this, new EventArgs());
        }
    }
}
