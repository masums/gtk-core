namespace Gtk
{
    public struct Margin
    {
        private int bottom;
        private int left;
        private int right;
        private int top;

        internal Margin(int left, int right, int top, int bottom)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }

        internal Margin(int lr, int bt)
        {
            this.left = lr;
            this.right = lr;
            this.top = bt;
            this.bottom = bt;
        }

        public int Bottom
        {
            get
            {
                return bottom;
            }
        }

        public int Left
        {
            get
            {
                return left;
            }
        }

        public int Right
        {
            get
            {
                return right;
            }
        }

        public int Top
        {
            get
            {
                return top;
            }
        }
    }
}