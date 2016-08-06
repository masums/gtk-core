using System;

namespace Gdk
{
    public abstract class GdkEventArgs : EventArgs
    {
        private IntPtr handle;

        public GdkEventArgs(IntPtr handle)
        {
            this.handle = handle;
        }

        public IntPtr Handle
        {
            get
            {
                return handle;
            }
        }
    }
}
