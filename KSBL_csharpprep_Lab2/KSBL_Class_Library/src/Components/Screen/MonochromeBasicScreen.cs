namespace KSBL_csharpprep_Lab1.Components.Screen
{
    public class MonochromeBasicScreen : BasicScreen
    {
        public MonochromeBasicScreen(int width, int height, int size, int density) : base(width, height, size, density)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            //here logic that draws monochrome image can be added 
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            //here logic that draws monochrome image can be added 
        }

        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}