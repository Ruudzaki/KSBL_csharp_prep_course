namespace KSBL_csharpprep_Lab1.Components.Speaker
{
    public abstract class BasicSpeaker
    {
        protected BasicSpeaker(int lowestDmp, int highestDmp, double power, int amount)
        {
            LowestDmp = lowestDmp;
            HighestDmp = highestDmp;
            Power = power;
            Amount = amount;
        }

        public int LowestDmp { get; }
        public int HighestDmp { get; }
        public double Power { get; }
        public int Amount { get; }

        public abstract void PlaySound(IPlaySound playSound);
    }
}