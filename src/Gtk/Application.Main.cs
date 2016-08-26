using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gtk
{
    public partial class Application : Gio.Application
    {
        internal class Main : Application
        {
            public Main()
            {

            }

            public override string ApplicationId
            {
                get
                {
                    throw new NotSupportedException();
                }

                set
                {
                    throw new NotSupportedException();
                }
            }

            public override Window ActiveWindow
            {
                get
                {
                    throw new NotSupportedException();
                }
            }

            public override IEnumerable<Window> Windows
            {
                get
                {
                    throw new NotSupportedException();
                }
            }

            public override event EventHandler<EventArgs> Activated
            {
                add
                {
                    throw new NotSupportedException();
                }

                remove
                {
                    throw new NotSupportedException();
                }
            }
        }
    }
}
