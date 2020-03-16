namespace KSBL_Class_Library.Components.Keyboard
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