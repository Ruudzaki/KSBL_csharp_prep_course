namespace KSBL_csharpprep_Lab1
{
    public abstract class BasicScreen
    {
        protected BasicScreen(int width, int height, int size, int density)
        {
            Width = width;
            Height = height;
            Size = size;
            Density = density;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public int Density { get; set; }

        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
    }
}