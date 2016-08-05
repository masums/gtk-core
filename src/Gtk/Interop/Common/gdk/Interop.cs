using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk
{
    internal static partial class Interop
    {
        internal static partial class gdk
        {
            //[DllImport(Libraries.Gdk)]

            public unsafe struct GdkEventButton
            {
                GdkEventType type;
                GdkWindow* window;
                byte send_event;
                int time;
                double x;
                double y;
                double* axes;
                uint state;
                uint button;
                GdkDevice* device;
                double x_root, y_root;
            };

            public enum GdkEventType
            {
                GDK_NOTHING,
                GDK_DELETE,
                GDK_DESTROY,
                GDK_EXPOSE,
                GDK_MOTION_NOTIFY,
                GDK_BUTTON_PRESS,
                GDK_2BUTTON_PRESS,
                GDK_DOUBLE_BUTTON_PRESS,
                GDK_3BUTTON_PRESS,
                GDK_TRIPLE_BUTTON_PRESS,
                GDK_BUTTON_RELEASE,
                GDK_KEY_PRESS,
                GDK_KEY_RELEASE,
                GDK_ENTER_NOTIFY,
                GDK_LEAVE_NOTIFY,
                GDK_FOCUS_CHANGE,
                GDK_CONFIGURE,
                GDK_MAP,
                GDK_UNMAP,
                GDK_PROPERTY_NOTIFY,
                GDK_SELECTION_CLEAR,
                GDK_SELECTION_REQUEST,
                GDK_SELECTION_NOTIFY,
                GDK_PROXIMITY_IN,
                GDK_PROXIMITY_OUT,
                GDK_DRAG_ENTER,
                GDK_DRAG_LEAVE,
                GDK_DRAG_MOTION,
                GDK_DRAG_STATUS,
                GDK_DROP_START,
                GDK_DROP_FINISHED,
                GDK_CLIENT_EVENT,
                GDK_VISIBILITY_NOTIFY,
                GDK_SCROLL,
                GDK_WINDOW_STATE,
                GDK_SETTING,
                GDK_OWNER_CHANGE,
                GDK_GRAB_BROKEN,
                GDK_DAMAGE,
                GDK_TOUCH_BEGIN,
                GDK_TOUCH_UPDATE,
                GDK_TOUCH_END,
                GDK_TOUCH_CANCEL,
                GDK_TOUCHPAD_SWIPE,
                GDK_TOUCHPAD_PINCH
            }

            public struct GdkWindow
            {

            }

            public struct GdkDevice
            {

            }
        }
    }
}
