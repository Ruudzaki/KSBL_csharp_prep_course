namespace KSBL_Class_Library
{

    public abstract class ScreenBase
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string ScreenType { get; set; }
        public string Size { get; set; }
        public string Density { get; set; }

        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
    }
}