namespace KSBL_Class_Library.Components.Speaker
{
    public abstract class BasicSpeaker : IPlayback
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

        public abstract void Play(object data);
    }
}