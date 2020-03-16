namespace KSBL_Class_Library.Components.Speaker
{
    public abstract class BasicSpeaker : IPlayback
    {
        public int LowestDmp { get; set; }
        public int HighestDmp { get; set; }
        public double Power { get; set; }
        public int Amount { get; set; }

        public abstract void Play(object data);

        protected BasicSpeaker(int lowestDmp, int highestDmp, double power, int amount)
        {
            LowestDmp = lowestDmp;
            HighestDmp = highestDmp;
            Power = power;
            Amount = amount;
        }
    }
}