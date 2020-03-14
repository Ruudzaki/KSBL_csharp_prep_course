namespace KSBL_csharpprep_Lab1
{


    public abstract class BasicKeyboard
    {
        public string Figures { get; set; }
        public string Letters { get; set; }

        public abstract void PressButton(IPressButton pressButton);
    }

}