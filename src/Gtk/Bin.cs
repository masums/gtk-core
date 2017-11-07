using GObj.Internal;
using System;
using static Interop.gtk;


namespace Gtk
{
    public abstract class Bin : Container
    {
        public unsafe Bin() : base()
        {

        }

        public Bin(IntPtr handle)
            : base(handle)
        {

        }

        public override void Add(Widget widget)
        {
            if(Child != null)
            {
                throw new InvalidOperationException("Already has a child");
            }

            base.Add(widget);
        }

        public Widget Child
        {
            get
            {
                var parent = gtk_bin_get_child(handle);
                return ObjectManager.Resolve<Container>(parent);
            }
        }
    }
}
