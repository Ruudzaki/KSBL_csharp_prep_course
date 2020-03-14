namespace KSBL_csharpprep_Lab1
{
    public class RetinaBasicScreen : ColorfulBasicScreen
    {
        public RetinaBasicScreen(int width, int height, int size, int density) : base(width, height, size, density)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            // here logic for Retina screen can be added        
        }

        public override string ToString()
        {
            return "Retina Screen";
        }
    }
}