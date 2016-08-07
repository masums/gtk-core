using Gtk;
using System;

namespace GtkTest
{
    public class Program
    {
        public static int Main(string[] args)
        {
            //Application app = new Application("org.robertsundstrom.test", GIO.ApplicationFlags.None);
            //app.Activated += (s, e) =>
            //{
            //    new MainWindow().ShowAll();
            //};

            var app = new App();
            return app.Run(args);
        }
    }
}
