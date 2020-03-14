namespace KSBL_csharpprep_Lab1.Components.Speaker
{
    public abstract class BasicSpeaker
    {
        protected BasicSpeaker(int lowestDmp, int highestDmp, double power, int amount)
        {
            LowestDMP = lowestDmp;
            HighestDMP = highestDmp;
            Power = power;
            Amount = amount;
        }

        public int LowestDMP { get; }
        public int HighestDMP { get; }
        public double Power { get; }
        public int Amount { get; }

        public abstract void PlaySound(IPlaySound playSound);
    }
}