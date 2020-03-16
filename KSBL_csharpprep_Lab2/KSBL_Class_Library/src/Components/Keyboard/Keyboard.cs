using System.Collections.Generic;

namespace KSBL_Class_Library.Components.Keyboard
{
    public class Keyboard : BasicKeyboard
    {
        public Keyboard(List<char> figures, List<char> letters, int amountOfButtons) : base(figures, letters)
        {
            AmountOfButtons = amountOfButtons;
        }

        public int AmountOfButtons { get; }

        public override void PressButton(IPressButton pressButton)
        {
            //here logic for press button on ordinary keyboard
        }

        public override string ToString()
        {
            return "Ordinary Keyboard";
        }
    }
}