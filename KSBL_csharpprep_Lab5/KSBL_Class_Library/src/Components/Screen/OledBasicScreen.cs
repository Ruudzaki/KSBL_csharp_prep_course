using System;

namespace KSBL_Class_Library.Components.Screen
{
    public class OLedBasicScreen : BasicScreen
    {
        public OLedBasicScreen(int width, int height, int size, int density) : base(width, height, size, density)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            // here logic for OLED screen can be added 
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "OLED Screen";
        }
    }
}