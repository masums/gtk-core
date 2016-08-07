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
                RegisterSignalHandler<ButtonEventArgs>("button-press-event", value, (a1, a2, a3, handler) => {
                    var ev = new ButtonEventArgs(a2);
                    handler(this, ev);
                });
            }

            remove
            {
                UnregisterSignalHandler<ButtonEventArgs>(value);
            }
        }

        public event EventHandler<ButtonEventArgs> ButtonReleased
        {
            add
            {
                RegisterSignalHandler<ButtonEventArgs>("button-release-event", value, (a1, a2, a3, handler) =>
                {
                    var ev = new ButtonEventArgs(a2);
                    handler(this, ev);
                });
            }

            remove
            {
                UnregisterSignalHandler<ButtonEventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> ChildNotify
        {
            add
            {
                RegisterSignalHandler<EventArgs>("child-notify", value);
            }

            remove
            {
                UnregisterSignalHandler<EventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> CompositedChanged
        {
            add
            {
                RegisterSignalHandler<EventArgs>("composited-changed", value);
            }

            remove
            {
                UnregisterSignalHandler<EventArgs>(value);
            }
        }

        public event EventHandler<CairoEventArgs> Draw
        {
            add
            {
                RegisterSignalHandlerWithReturnValue<CairoEventArgs>("draw", value, (a1, a2, a3, handler) =>
                {
                    var drawingContext = new DrawingContext(a2);
                    var eventArgs = new CairoEventArgs(drawingContext);
                    handler(this, eventArgs);

                    return true;
                });
            }

            remove
            {
                UnregisterSignalHandler<CairoEventArgs>(value);
            }
        }

        public event EventHandler<DeleteEventArgs> Delete
        {
            add
            {
                RegisterSignalHandlerWithReturnValue<DeleteEventArgs>("delete-event", value, (a1, a2, a3, handler) =>
                {
                    var eventArgs = new DeleteEventArgs(a2);
                    handler(this, eventArgs);

                    return true;
                });
            }

            remove
            {
                UnregisterSignalHandler<DeleteEventArgs>(value);
            }
        }

        public event EventHandler<DestroyEventArgs> Destroyed
        {
            add
            {
                RegisterSignalHandlerWithReturnValue<DestroyEventArgs>("destroy-event", value, (a1, a2, a3, handler) =>
                {
                    var eventArgs = new DestroyEventArgs(a2);
                    handler(this, eventArgs);

                    return true;
                });
            }

            remove
            {
                UnregisterSignalHandler<DestroyEventArgs>(value);
            }
        }

        public event EventHandler<EventArgs> Shown
        {
            add
            {
                RegisterSignalHandler<EventArgs>("show", value, handleShown);
            }

            remove
            {
                UnregisterSignalHandler<EventArgs>(value);
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
