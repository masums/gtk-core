using System;

namespace Gdk
{
    public class DeleteEventArgs : GdkEventArgs
    {
        public DeleteEventArgs(IntPtr handle) : base(handle)
        {
        }
    }

    public class DestroyEventArgs : GdkEventArgs
    {
        public DestroyEventArgs(IntPtr handle) : base(handle)
        {
        }
    }

    public class ExposeEventArgs : GdkEventArgs
    {
        public ExposeEventArgs(IntPtr handle) : base(handle)
        {
        }
    }
}