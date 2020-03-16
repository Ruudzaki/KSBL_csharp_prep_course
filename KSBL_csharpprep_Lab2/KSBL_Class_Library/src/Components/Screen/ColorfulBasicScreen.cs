namespace KSBL_Class_Library.Components.Screen
{
    public class ColorfulBasicScreen : BasicScreen
    {
        public ColorfulBasicScreen(int width, int height, int size, int density, int amountOfColors) : base(width,
            height, size, density)
        {
            AmountOfColors = amountOfColors;
        }

        public int AmountOfColors { get; }

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