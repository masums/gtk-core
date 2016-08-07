namespace Gtk
{

    public struct Alignment
    {
        public Alignment(float xalign, float yalign)
        {
            X = xalign;
            Y = xalign;
        }

        public float X { get; }

        public float Y { get; }
    }
}