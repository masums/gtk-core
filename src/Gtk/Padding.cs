namespace Gtk
{
    public struct Padding
    {
        public Padding(float xpad, float ypad)
        {
            X = xpad;
            Y = ypad;
        }

        public float X { get; }

        public float Y { get; }
    }
}