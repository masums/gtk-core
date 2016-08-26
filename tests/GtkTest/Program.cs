using Gtk;
using System;

namespace GtkTest
{
    public class Program
    {
        public static int Main(string[] args)
        {
Console.WriteLine("Hello");

            //return StaticInit(args);
            return AppInit1(args);
            //return AppInit2(args);
        }

        /// <summary>
        /// Instantiate a derived Application class that contains all the main logic.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static int AppInit2(string[] args)
        {
            var app = new App();
            return app.Run(args);
        }

        /// <summary>
        /// Classic initialization of the Main loop.
        /// </summary>
        /// <returns></returns>
        private static int StaticInit(string[] args)
        {
            Application.Init(args);

            new MainWindow().ShowAll();

            Application.GtkMain();
            return 0;
        }

        /// <summary>
        /// Instantiate an Application and hook up events.
        /// </summary>
        /// <returns></returns>
        private static int AppInit1(string[] args)
        {
            Application app = new Application("org.robertsundstrom.test", Gio.ApplicationFlags.None);
            app.Activated += (s, e) =>
            {
                new MainWindow().ShowAll();
            };
            return app.Run(args);
        }
    }
}
