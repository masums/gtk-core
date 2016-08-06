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

            //buttonBox = new ButtonBox();
            //buttonBox.Name = "buttonBox";

            //Add(buttonBox);

            //button = new Button();
            //button.Name = "button";
            //button.Label = "Click me!";
            //button.Clicked += Button_Clicked;

            //buttonBox.Add(button);

            var drawingArea = new DrawingArea();
            drawingArea.Draw += DrawingArea_Draw;
            Add(drawingArea);
        }

        private void DrawingArea_Draw(object sender, CairoDrawEventArgs e)
        {
            var ctx = e.Context;

            ctx.SetSourceRgb(0, 0, 0);
            ctx.SelectFontFace("Sans");
            ctx.SetFontSize(40.0);
            ctx.MoveTo(10.0, 50.0);
            ctx.ShowText("Disziplin ist Macht.");

            ctx.End();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var app = Application.Current.ApplicationId;

            button.Label = $"{++clicks} click(s)";

            Resize(200, 300);
        }
    }
}