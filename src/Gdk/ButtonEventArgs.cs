using System;

namespace Gdk
{

    public unsafe class ButtonEventArgs : GdkEventArgs
    {
        private Gdk.Interop.gdk.GdkEventButton* structure;

        public ButtonEventArgs(IntPtr handle) : base(handle)
        {
            structure = (Gdk.Interop.gdk.GdkEventButton*)(void*)handle;
        }

        public bool IsButtonPress
        {
            get
            {
                return structure->type == Interop.gdk.GdkEventType.GDK_BUTTON_PRESS;
            }
        }

        public bool Is2ButtonPress
        {
            get
            {
                return structure->type == Interop.gdk.GdkEventType.GDK_2BUTTON_PRESS;
            }
        }

        public bool Is3ButtonPress
        {
            get
            {
                return structure->type == Interop.gdk.GdkEventType.GDK_3BUTTON_PRESS;
            }
        }

        public bool IsButtonRelease
        {
            get
            {
                return structure->type == Interop.gdk.GdkEventType.GDK_BUTTON_RELEASE;
            }
        }

        public bool IsDoubleButtonPress
        {
            get
            {
                return structure->type == Interop.gdk.GdkEventType.GDK_DOUBLE_BUTTON_PRESS;
            }
        }

        public TimeSpan Time
        {
            get
            {
                return TimeSpan.FromMilliseconds(structure->time);
            }
        }

        public Buttons Button
        {
            get
            {
                return (Buttons)structure->button;
            }
        }

        public double X
        {
            get
            {
                return structure->x;
            }
        }

        public double Y
        {
            get
            {
                return structure->y;
            }
        }

        public double XRoot
        {
            get
            {
                return structure->x_root;
            }
        }

        public double YRoot
        {
            get
            {
                return structure->y_root;
            }
        }
    }
}