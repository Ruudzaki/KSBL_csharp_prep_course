namespace KSBL_csharpprep_Lab1
{
    public class LiIonBattery : BasicBattery
    {
        public LiIonBattery(int power, int capacity, bool fastRecovery) : base(power,
            capacity, fastRecovery)
        {
        }

        public override void Charge(ICharge charge)
        {
            //here logic how to charge Li-Ion Batteries
        }

        public override string ToString()
        {
            return "Li-Ion Battery";
        }
    }
}