namespace KSBL_csharpprep_Lab1
{

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


}