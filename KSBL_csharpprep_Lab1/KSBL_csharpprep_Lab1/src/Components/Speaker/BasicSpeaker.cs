namespace KSBL_csharpprep_Lab1
{

    public abstract class BasicSpeaker
    {
        public int LowestDMP { get; set; }
        public int HighestDMP { get; set; }
        public double Power { get; set; }
        public int Amount { get; set; }

        public abstract void PlaySound(IPlaySound playSound);
    }

  
}