using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1.Components.Keyboard
{
    public abstract class BasicKeyboard
    {
        protected BasicKeyboard(List<char> figures, List<char> letters)
        {
            Figures = figures;
            Letters = letters;
        }

        public List<char> Figures { get; }
        public List<char> Letters { get; }

        public abstract void PressButton(IPressButton pressButton);
    }
}