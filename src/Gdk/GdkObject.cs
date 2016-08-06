using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gdk
{
    public abstract class GdkObject
    {
        private IntPtr handle;

        public GdkObject(IntPtr handle)
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
