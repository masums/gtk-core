using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk.Internal
{
    public static class GTypeHelper
    {
        private static Dictionary<string, Type> typeMapping = new Dictionary<string, Type>();

        static GTypeHelper()
        {
            typeMapping.Add("widget", typeof(Widget));
            typeMapping.Add("label", typeof(Label));
        }

        public static Type GetType(string gTypeName)
        {
            return typeMapping[gTypeName];
        }

        public static unsafe uint GetGType(IntPtr instance)
        {
            return 0; // Interop.gtk.gtk_widget_get_type(instance);
        }

        public static string GetTypeName(uint typeId)
        {
            var ptr = Interop.gobj.g_type_name(typeId);
            return StringHelpers.Utf8PtrToString(ptr);
        }

        struct GTypeInstance
        {
            public uint g_class;
        }
    }
}
