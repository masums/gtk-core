using GObj.Internal;
using Gtk.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static Interop.gio;
using static Interop.gtk;


namespace Gtk
{
    public class Image : Misc
    {
        private unsafe Image() : base()
        {

        }

        public Image(IntPtr handle)
            : base(handle)
        {

        }

        public static Image FromFile(string filename)
        {
            var ptr = gtk_image_new_from_file(filename);
            return ObjectManager.Resolve<Image>(ptr);
        }
    }
}
