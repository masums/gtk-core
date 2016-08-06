using System;
using Gtk;
using System.Linq;
using Gdk;

namespace GtkTest
{
    public class MainWindow : ApplicationWindow
    {
        ButtonBox buttonBox;
        Button button;
        private int clicks;
        private DrawingArea drawingArea;
        private Layout layout;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Title = "Test";

            SetDefaultSize(300, 300);

            //buttonBox = new ButtonBox();
            //buttonBox.Name = "buttonBox";

            layout = new Layout();
            layout.Name = "layout";

            Add(layout);

            drawingArea = new DrawingArea();
            drawingArea.SetSizeRequest(200, 200);
            drawingArea.Draw += DrawingArea_Draw;

            layout.Add(drawingArea);

            button = new Button();
            button.Name = "button";
            button.Label = "Click me!";
            button.ButtonReleased += Button_Clicked;
            button.SetMargin(20, 0);

            layout.Add(button);
        }

        private void DrawingArea_Draw(object sender, CairoEventArgs e)
        {
            using (var ctx = e.GetDrawingContext())
            {
                if (clicks > 2)
                {
                    ctx.SetSourceRgb(0, 0, 0);
                    ctx.SelectFontFace("Sans");
                    ctx.SetFontSize(40.0);
                    ctx.MoveTo(10.0, 50.0);
                    ctx.ShowText("Disziplin ist Macht.");
                }
            }
        }

        private void Button_Clicked(object sender, ButtonEventArgs e)
        {
            button.Label = $"{++clicks} click(s)";

            Resize(200, 300);

            drawingArea.QueueDraw();
        }
    }
}