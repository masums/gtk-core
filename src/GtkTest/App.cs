using System;
using Gtk;

namespace GtkTest
{
    public class App : Application
    {
        public App()
        {
            ApplicationId = "org.robertsundstrom.test";
        }

        public override int OnActivated(Application application, string[] args)
        {
            new MainWindow().Show();
            return 0;
        }
    }
}