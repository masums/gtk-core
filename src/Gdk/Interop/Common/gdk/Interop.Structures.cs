using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Gdk
{
    internal static partial class Interop
    {
        internal static partial class gdk
        {
            //[StructLayout(LayoutKind.Explicit)]
            public unsafe struct GdkEvent
            {
                public GdkEventType type;
                public GdkEventAny* any;
                public GdkEventExpose* expose;
                public GdkEventVisibility* visibility;
                public GdkEventMotion* motion;
                public GdkEventButton* button;
                public GdkEventTouch* touch;
                public GdkEventScroll* scroll;
                public GdkEventKey* key;
                public GdkEventCrossing* crossing;
                public GdkEventFocus* focus_change;
                public GdkEventConfigure configure;
                public GdkEventProperty property;
                public GdkEventSelection selection;
                public GdkEventOwnerChange owner_change;
                //public GdkEventProximity proximity;
                public GdkEventDND dnd;
                public GdkEventWindowState window_state;
                //public GdkEventSetting setting;
                //public GdkEventGrabBroken grab_broken;
                //public GdkEventTouchpadSwipe touchpad_swipe;
                //public GdkEventTouchpadPinch touchpad_pinch;
            };

            public enum GdkEventType
            {
                GDK_NOTHING = -1,
                GDK_DELETE = 0,
                GDK_DESTROY = 1,
                GDK_EXPOSE = 2,
                GDK_MOTION_NOTIFY = 3,
                GDK_BUTTON_PRESS = 4,
                GDK_2BUTTON_PRESS = 5,
                GDK_DOUBLE_BUTTON_PRESS = 5,
                GDK_3BUTTON_PRESS = 6,
                GDK_BUTTON_RELEASE = 7,
                GDK_KEY_PRESS = 8,
                GDK_KEY_RELEASE = 9,
                GDK_ENTER_NOTIFY = 10,
                GDK_LEAVE_NOTIFY = 11,
                GDK_FOCUS_CHANGE = 12,
                GDK_CONFIGURE = 13,
                GDK_MAP = 14,
                GDK_UNMAP = 15,
                GDK_PROPERTY_NOTIFY = 16,
                GDK_SELECTION_CLEAR = 17,
                GDK_SELECTION_REQUEST = 18,
                GDK_SELECTION_NOTIFY = 19,
                GDK_PROXIMITY_IN = 20,
                GDK_PROXIMITY_OUT = 21,
                GDK_DRAG_BEGIN = 22,
                GDK_DRAG_REQUEST = 23,
                GDK_DROP_ENTER = 24,
                GDK_DROP_LEAVE = 25,
                GDK_DROP_DATA_AVAIL = 26,
                GDK_CLIENT_EVENT = 27,
                GDK_VISIBILITY_NOTIFY = 28,
                GDK_NO_EXPOSE = 29,
                GDK_OTHER_EVENT = 9999  /* Deprecated, use filters instead */
            }

            public unsafe struct GdkEventAny
            {
                public GdkEventType type;
                public GdkWindow* window;
                public byte send_event;
            };

            public unsafe struct GdkEventKey
            {
                public GdkEventType type;
                public GdkWindow* window;
                [MarshalAs(UnmanagedType.U1)]
                public int send_event;
                public uint time;
                public uint state;
                public uint keyval;
                public int length;
                public char* @string;
                public ushort hardware_keycode;
                [MarshalAs(UnmanagedType.U1)]
                public int group;
                public uint is_modifier;
            };

            public unsafe struct GdkEventButton
            {
                public GdkEventType type;
                public GdkWindow* window;
                public short send_event;
                public uint time;
                public double x;
                public double y;
                public double* axes;
                public uint state;
                public uint button;
                public GdkDevice* device;
                public double x_root, y_root;
            };

            public unsafe struct GdkEventTouch
            {
                public GdkEventType type;
                public GdkWindow* window;
                public short send_event;
                public uint time;
                public double x;
                public double y;
                public double* axes;
                public uint state;
                public void* sequence;
                public bool emulating_pointer;
                public GdkDevice* device;
                public double x_root, y_root;
            };

            public unsafe struct GdkEventScroll
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                uint time;
                double x;
                double y;
                uint state;
                GdkScrollDirection direction;
                GdkDevice* device;
                double x_root, y_root;
                double delta_x;
                double delta_y;
                uint is_stop;
            };

            public enum GdkScrollDirection
            {
                GDK_SCROLL_UP,
                GDK_SCROLL_DOWN,
                GDK_SCROLL_LEFT,
                GDK_SCROLL_RIGHT,
                GDK_SCROLL_SMOOTH
            }

            public unsafe struct GdkEventMotion
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                uint time;
                double x;
                double y;
                double* axes;
                uint state;
                short is_hint;
                GdkDevice* device;
                double x_root, y_root;
            };

            public unsafe struct GdkEventExpose
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkRectangle area;
                cairo_region_t* region;
                int count; /* If non-zero, how many more events follow. */
            };

            public unsafe struct GdkEventVisibility
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkVisibilityState state;
            };

            public unsafe struct GdkEventCrossing
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkWindow* subwindow;
                uint time;
                double x;
                double y;
                double x_root;
                double y_root;
                GdkCrossingMode mode;
                GdkNotifyType detail;
                bool focus;
                uint state;
            };

            public unsafe struct GdkEventFocus
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                short @in;
            };

            public unsafe struct GdkEventConfigure
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                int x, y;
                int width;
                int height;
            };

            public unsafe struct GdkEventProperty
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkAtom atom;
                uint time;
                uint state;
            };

            public unsafe struct GdkEventSelection
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkAtom selection;
                GdkAtom target;
                GdkAtom property;
                uint time;
                GdkWindow* requestor;
            };

            public unsafe struct GdkEventDND
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkDragContext* context;

                uint time;
                short x_root, y_root;
            };

            public unsafe struct GdkEventOwnerChange
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkWindow* owner;
                GdkOwnerChange reason;
                GdkAtom selection;
                uint time;
                uint selection_time;
            };

            public unsafe struct GdkEventWindowState
            {
                GdkEventType type;
                GdkWindow* window;
                short send_event;
                GdkWindowState changed_mask;
                GdkWindowState new_window_state;
            };

            public enum GdkWindowState
            {
                GDK_WINDOW_STATE_WITHDRAWN,
                GDK_WINDOW_STATE_ICONIFIED,
                GDK_WINDOW_STATE_MAXIMIZED,
                GDK_WINDOW_STATE_STICKY,
                GDK_WINDOW_STATE_FULLSCREEN,
                GDK_WINDOW_STATE_ABOVE,
                GDK_WINDOW_STATE_BELOW,
                GDK_WINDOW_STATE_FOCUSED,
                GDK_WINDOW_STATE_TILED
            }

            public enum GdkOwnerChange
            {
                GDK_OWNER_CHANGE_NEW_OWNER,
                GDK_OWNER_CHANGE_DESTROY,
                GDK_OWNER_CHANGE_CLOSE
            }

            public struct GdkDragContext
            {

            }

            public struct GdkAtom
            {

            }

            public enum GdkCrossingMode
            {
                GDK_CROSSING_NORMAL,
                GDK_CROSSING_GRAB,
                GDK_CROSSING_UNGRAB,
                GDK_CROSSING_GTK_GRAB,
                GDK_CROSSING_GTK_UNGRAB,
                GDK_CROSSING_STATE_CHANGED,
                GDK_CROSSING_TOUCH_BEGIN,
                GDK_CROSSING_TOUCH_END,
                GDK_CROSSING_DEVICE_SWITCH
            }

            public enum GdkNotifyType
            {
                GDK_NOTIFY_ANCESTOR,
                GDK_NOTIFY_VIRTUAL,
                GDK_NOTIFY_INFERIOR,
                GDK_NOTIFY_NONLINEAR,
                GDK_NOTIFY_NONLINEAR_VIRTUAL,
                GDK_NOTIFY_UNKNOWN
            }

            public enum GdkVisibilityState
            {
                GDK_VISIBILITY_UNOBSCURED,
                GDK_VISIBILITY_PARTIAL,
                GDK_VISIBILITY_FULLY_OBSCURED
            }

            public struct cairo_region_t
            {

            }

            public struct GdkRectangle
            {

            }

            public struct GdkWindow
            {

            }

            public struct GdkDevice
            {

            }

			public enum GdkModifierType
            {
                GDK_SHIFT_MASK,
				GDK_LOCK_MASK,
				GDK_CONTROL_MASK,
				GDK_MOD1_MASK,
				GDK_MOD2_MASK,
				GDK_MOD3_MASK,
				GDK_MOD4_MASK,
				GDK_MOD5_MASK,
				GDK_BUTTON1_MASK,
				GDK_BUTTON2_MASK,
				GDK_BUTTON3_MASK,
				GDK_BUTTON4_MASK,
				GDK_BUTTON5_MASK,
				GDK_MODIFIER_RESERVED_13_MASK,
				GDK_MODIFIER_RESERVED_14_MASK,
				GDK_MODIFIER_RESERVED_15_MASK,
				GDK_MODIFIER_RESERVED_16_MASK,
				GDK_MODIFIER_RESERVED_17_MASK,
				GDK_MODIFIER_RESERVED_18_MASK,
				GDK_MODIFIER_RESERVED_19_MASK,
				GDK_MODIFIER_RESERVED_20_MASK,
				GDK_MODIFIER_RESERVED_21_MASK,
				GDK_MODIFIER_RESERVED_22_MASK,
				GDK_MODIFIER_RESERVED_23_MASK,
				GDK_MODIFIER_RESERVED_24_MASK,
				GDK_MODIFIER_RESERVED_25_MASK,
				GDK_SUPER_MASK,
				GDK_HYPER_MASK,
				GDK_META_MASK,
				GDK_MODIFIER_RESERVED_29_MASK,
				GDK_RELEASE_MASK,
				GDK_MODIFIER_MASK
            }
        }
    }
}