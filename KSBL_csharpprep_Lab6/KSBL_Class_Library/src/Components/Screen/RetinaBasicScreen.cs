using System;

namespace KSBL_Class_Library.Components.Screen
{
    public class RetinaBasicScreen : BasicScreen
    {
        private const int MINDPI = 300;

        public RetinaBasicScreen(int width, int height, int size, int density) : base(width, height, size, density)
        {
            if (density < MINDPI) Console.WriteLine("Not Retina Display!");
        }


        public override void Show(IScreenImage screenImage)
        {
            // here logic for Retina screen can be added        
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Retina Screen";
        }
    }
}