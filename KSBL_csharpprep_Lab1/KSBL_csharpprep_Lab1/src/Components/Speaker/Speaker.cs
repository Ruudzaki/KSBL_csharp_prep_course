namespace KSBL_csharpprep_Lab1
{
    public class Speaker : BasicSpeaker
    {
        public Speaker(int lowestDmp, int highestDmp, double power, int amount) : base(lowestDmp, highestDmp, power,
            amount)
        {
        }

        public override void PlaySound(IPlaySound playSound)
        {
            //here logic for play sound from dynamic
        }

        public override string ToString()
        {
            return "Dynamic";
        }
    }
}