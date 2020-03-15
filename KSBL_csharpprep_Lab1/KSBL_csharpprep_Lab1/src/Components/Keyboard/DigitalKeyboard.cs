using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1.Components.Keyboard
{
    public class DigitalKeyboard : BasicKeyboard
    {
        public DigitalKeyboard(List<char> figures, List<char> letters) : base(figures, letters)
        {
            TouchScreen = true;
        }

        public bool TouchScreen { get; }

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