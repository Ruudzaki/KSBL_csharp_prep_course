namespace KSBL_Class_Library
{


    public abstract class BasicKeyboard
    {
        public string Figures { get; set; }
        public string Letters { get; set; }

        public abstract void PressButton(IPressButton pressButton);
    }

}