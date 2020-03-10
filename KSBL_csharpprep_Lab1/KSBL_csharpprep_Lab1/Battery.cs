namespace KSBL_csharpprep_Lab1
{
    public interface ICharge
    {
    }

    public abstract class BasicBattery
    {
        public string BatteryType { get; set; }
        public int Power { get; set; }
        public int Capacity { get; set; }
        public bool FastRecovery { get; set; }

        public abstract void Charge(ICharge charge);
    }

    public class LiIonBattery : BasicBattery
    {
        public override void Charge(ICharge charge)
        {
            //here logic how to charge Li-Ion Batteries
        }

        public override string ToString()
        {
            return "Li-Ion Battery";
        }
    }

    public class BaIonBattery : BasicBattery
    {
        public override void Charge(ICharge charge)
        {
            //here logic how to charge Ba-Ion Batteries
        }

        public override string ToString()
        {
            return "Ba-Ion Battery";
        }
    }
}