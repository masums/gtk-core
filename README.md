# gtk-core
GTK Core is a .NET Core binding to the GTK+ GUI toolkit

Compatibility with GTK# would be ideal.

This is just an early conceptual stage.

## Sample

From GtkTest.

```csharp
using System;
using Gtk;

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
    
    public class Program
    {
        public static int Main(string[] args)
        {
            Application.Run<App>(args);

            return 0;
        }
    }
}
```

## References

* GTK+ Doc: http://www.gtk.org/documentation.php
* Mono GNOME Doc: http://docs.go-mono.com/index.aspx?link=root:/classlib-gnome
