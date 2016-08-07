using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GtkTest
{
    public class App : Gtk.Application
    {
        public App() 
            : base("org.robertsundstrom.test", GIO.ApplicationFlags.None)
        {

        }

        protected override int OnActivated(object sender, EventArgs e)
        {
            base.OnActivated(sender, e);

            new MainWindow().ShowAll();

            return 0;
        }
    }
}
