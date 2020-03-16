namespace KSBL_Class_Library.Components.Keyboard
{
    public abstract class BasicKeyboard
    {
        public string Figures { get; set; }
        public string Letters { get; set; }

        public abstract void PressButton(IPressButton pressButton);
    }
}