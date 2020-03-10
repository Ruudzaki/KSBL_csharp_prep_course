namespace KSBL_csharpprep_Lab1
{
    public interface IScreenImage
    {
        int size { get; set; }
        int width { get; set; }
        int height { get; set; }
    }

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

    public class ColorfulScreen : ScreenBase
    {
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

    public class OLEDScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            // here logic for OLED screen can be added 
        }

        public override string ToString()
        {
            return "OLED Screen";
        }
    }

    public class RetinaScreen : ColorfulScreen
    {
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