using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using GIO;

namespace Gtk.Internal
{
    public static class WidgetHelpers
    {
        public static Window GetWindow(Widget widget)
        {
            if (widget == null)
                throw new ArgumentNullException(nameof(Widget));

            var parent = widget.Parent;
            while(parent != null)
            {
                bool check = parent.GetType().GetTypeInfo().IsSubclassOf(typeof(Window));
                if (check) break;
                parent = widget.Parent;
            }
            return parent as Window;
        }

        public static bool IsApplicationMain(GIO.Application app)
        {
            return app is Application.Main;
        }
    }
}
