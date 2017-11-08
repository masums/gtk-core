using Gtk;
using Gdk;

namespace GtkTest
{
    public class MainWindow : ApplicationWindow
    {
        private ButtonBox buttonBox;
        private Button button;
        private int clicks;
        private DrawingArea drawingArea;
        private Layout layout;
        private Image image;
        private Label label;

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
            //Add(buttonBox);

            layout = new Layout();
            layout.Name = "layout";

            Add(layout);

            label = new Label();
            label.Text = "test";
            label.SetMargin(50, 70);

            layout.Add(label);

            drawingArea = new DrawingArea();
            drawingArea.SetSizeRequest(200, 200);
            drawingArea.Draw += DrawingArea_Draw;

            layout.Add(drawingArea);

            button = new Button();
            button.Name = "button";
            button.Label = "Click me!";
            button.ButtonReleased += Button_Released;
            button.SetMargin(20, 0);

            image = Image.FromFile("Content/gnome-logo.png");
            layout.Add(image);

            layout.Add(button);
        }

        private void DrawingArea_Draw(object sender, CairoEventArgs e)
        {
            using (var ctx = e.GetDrawingContext())
            {
                if (clicks > 2)
                {
                    ctx.SetSourceRgb(255, 255, 255);
                    ctx.SelectFontFace("Arial");
                    ctx.SetFontSize(40.0);
                    ctx.MoveTo(10.0, 50.0);
                    ctx.ShowText("Disziplin ist Macht.");
                }

                if(clicks == 5)
                {
                    Application.Current.Exit(0);
                }
            }
        }

        private void Button_Released(object sender, ButtonEventArgs e)
        {
            var widget = sender as Widget;
            var gdkWindow = widget.GdkWindow;

            if (e.Button == Buttons.Left && e.IsButtonRelease)
            {
                button.Label = $"{++clicks} click(s)";
            }

            drawingArea.QueueDraw();
        }
    }
}