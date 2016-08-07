# gtk-core
GTK Core is a .NET Core binding to the GTK+ GUI toolkit

Kind of like a GTK# re-imagined.

Some compatibility with GTK# would be ideal.

This is still just in an early conceptual stage.

## Sample

From GtkTest.

```csharp
using Gdk;
using Gtk;
using System;

namespace GtkTest
{
    public class MainWindow : Window
    {
        ButtonBox buttonBox;
        Button button;
        int clicks;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Title = "Test";

            buttonBox = new ButtonBox();
            buttonBox.Name = "buttonBox";

            Add(buttonBox);

            button = new Button();
            button.Name = "button";
            button.Label = "Click me!";
            button.Clicked += Button_Clicked;
            button.Destroyed += Button_Destroyed;

            buttonBox.Add(button);
        }

        private void Button_Destroyed(object sender, EventArgs e)
        {
            Console.WriteLine((sender as Button).Label);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            button.Label = $"{++clicks} click(s)";
        }
    }
    
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
    
    public class Program
    {
        public static int Main(string[] args)
        {
            // Application app = new Application("org.robertsundstrom.test", GIO.ApplicationFlags.None);
            // app.Activated += (s, e) =>
            // {
            //     new MainWindow().ShowAll();
            // };
            // return app.Run(args);

            var app = new App();
            return app.Run(args);
        }
    }
}
```

## References

* GTK+ Doc: http://www.gtk.org/documentation.php
* Mono GNOME Doc: http://docs.go-mono.com/index.aspx?link=root:/classlib-gnome
