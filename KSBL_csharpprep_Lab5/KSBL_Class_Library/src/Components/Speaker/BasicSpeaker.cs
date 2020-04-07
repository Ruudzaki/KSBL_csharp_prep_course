namespace KSBL_Class_Library.Components.Speaker
{
    public abstract class BasicSpeaker : IPlayback
    {
        protected BasicSpeaker(int lowestDmp, int highestDmp, double power, int amount, IOutput output)
        {
            LowestDmp = lowestDmp;
            HighestDmp = highestDmp;
            Power = power;
            Amount = amount;
            Output = output;
        }

        public IOutput Output { get; set; }

        public int LowestDmp { get; }
        public int HighestDmp { get; }
        public double Power { get; }
        public int Amount { get; }

        public abstract string Play(object data);
    }
}