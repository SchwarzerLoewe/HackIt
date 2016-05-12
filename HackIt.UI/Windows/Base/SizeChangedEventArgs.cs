namespace ConsoleDraw.Windows.Base
{
    public class SizeChangedEventArgs
    {
        public int Height { get; }
        public int Width { get; }

        public SizeChangedEventArgs(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
    }
}