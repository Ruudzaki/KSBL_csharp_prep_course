namespace KSBL_csharpprep_Lab1
{
    public interface IPlaySound
    {
    }

    public abstract class BasicDynamic
    {
        public int LowestDMP { get; set; }
        public int HighestDMP { get; set; }
        public double Power { get; set; }
        public int Amount { get; set; }

        public abstract void PlaySound(IPlaySound playSound);
    }

    public class Dynamic : BasicDynamic
    {
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