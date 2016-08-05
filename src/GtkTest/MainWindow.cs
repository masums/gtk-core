using System;
using Gtk;

namespace GtkTest
{
    public class MainWindow : Window
    {
        ButtonBox buttonBox;
        Button button;
        private int clicks;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Title = "Test";

            SetDefaultSize(200, 200);

            buttonBox = new ButtonBox();
            buttonBox.Name = "buttonBox";

            Add(buttonBox);

            button = new Button();
            button.Name = "button";
            button.Label = "Click me!";
            button.Clicked += Button_Clicked;

            buttonBox.Add(button);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var app = Application.Current.ApplicationId;

            button.Label = $"{++clicks} click(s)";

            Resize(200, 300);
        }
    }
}