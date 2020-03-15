namespace KSBL_csharpprep_Lab1.Components.Screen
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


        public int Width { get; }
        public int Height { get; }
        public int Size { get; }
        public int Density { get; }

        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
    }
}