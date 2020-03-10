namespace KSBL_csharpprep_Lab1
{
    public interface IPressButton
    {
    }

    public abstract class BasicKeyboard
    {
        public string Figures { get; set; }
        public string Letters { get; set; }

        public abstract void PressButton(IPressButton pressButton);
    }

    public class Keyboard : BasicKeyboard
    {
        public override void PressButton(IPressButton pressButton)
        {
            //here logic for press button on ordinary keyboard
        }

        public override string ToString()
        {
            return "Ordinary Keyboard";
        }
    }

    public class DigitalKeyboard : BasicKeyboard
    {
        public override void PressButton(IPressButton pressButton)
        {
            //here logic for press button on digital keyboard
        }

        public override string ToString()
        {
            return "Digital Keyboard";
        }
    }
}