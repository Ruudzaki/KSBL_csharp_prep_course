namespace KSBL_csharpprep_Lab1
{
    public class OLedBasicScreen : ColorfulBasicScreen
    {
        public OLedBasicScreen(int width, int height, int size, int density) : base(width, height, size, density)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            // here logic for OLED screen can be added 
        }

        public override string ToString()
        {
            return "OLED Screen";
        }
    }
}