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
}