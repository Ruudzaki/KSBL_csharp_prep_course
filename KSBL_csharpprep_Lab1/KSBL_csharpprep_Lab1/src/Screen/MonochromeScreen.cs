﻿namespace KSBL_csharpprep_Lab1
{
    public class MonochromeScreen : ScreenBase
    {
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