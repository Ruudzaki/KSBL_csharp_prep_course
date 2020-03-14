namespace KSBL_csharpprep_Lab1
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

        public int LowestDMP { get; set; }
        public int HighestDMP { get; set; }
        public double Power { get; set; }
        public int Amount { get; set; }

        public abstract void PlaySound(IPlaySound playSound);
    }
}