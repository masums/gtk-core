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

        protected override void OnActivated(object sender, EventArgs e)
        {
            new MainWindow().ShowAll();
        }
    }
}