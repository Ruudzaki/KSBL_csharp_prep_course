namespace KSBL_csharpprep_Lab1
{
    public class ColorfulBasicScreen : BasicScreen
    {
        public ColorfulBasicScreen(int width, int height, int size, int density) : base(width, height, size, density)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            // here logic that draws colorful image can be added 
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            // here logic that draws colorful image can be added 
        }

        public override string ToString()
        {
            return "Colorful Screen";
        }
    }
}