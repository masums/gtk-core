using Gdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk
{
    public partial class Widget
    {
        public event EventHandler<ButtonEventArgs> ButtonPressed
        {
            add
            {
                AddSignalHandler<ButtonEventArgs>("button-press-event", value, (a1, a2, a3, handler) => {
                    var ev = new ButtonEventArgs(a2);
                    handler(this, ev);
                });
            }

            remove
            {
                RemoveSignalHandler<ButtonEventArgs>(value);
            }
        }

        public event EventHandler<ButtonEventArgs> ButtonReleased
        {
            add
            {
                AddSignalHandler<ButtonEventArgs>("button-release-event", value, (a1, a2, a3, handler) =>
                {
                    var ev = new ButtonEventArgs(a2);
                    handler(this, ev);
                });
            }

            remove
            {
                RemoveSignalHandler<ButtonEventArgs>(value);
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

        public event EventHandler<CairoEventArgs> Draw
        {
            add
            {
                AddSignalHandler2<CairoEventArgs>("draw", value, (a1, a2, a3, handler) =>
                {
                    var drawingContext = new DrawingContext(a2);
                    var eventArgs = new CairoEventArgs(drawingContext);
                    handler(this, eventArgs);

                    return true;
                });
            }

            remove
            {
                RemoveSignalHandler<CairoEventArgs>(value);
            }
        }

        public event EventHandler<DeleteEventArgs> Delete
        {
            add
            {
                AddSignalHandler2<DeleteEventArgs>("delete-event", value, (a1, a2, a3, handler) =>
                {
                    var eventArgs = new DeleteEventArgs(a2);
                    handler(this, eventArgs);

                    return true;
                });
            }

            remove
            {
                RemoveSignalHandler<DeleteEventArgs>(value);
            }
        }

        public event EventHandler<DestroyEventArgs> Destroyed
        {
            add
            {
                AddSignalHandler2<DestroyEventArgs>("destroy-event", value, (a1, a2, a3, handler) =>
                {
                    var eventArgs = new DestroyEventArgs(a2);
                    handler(this, eventArgs);

                    return true;
                });
            }

            remove
            {
                RemoveSignalHandler<DestroyEventArgs>(value);
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
