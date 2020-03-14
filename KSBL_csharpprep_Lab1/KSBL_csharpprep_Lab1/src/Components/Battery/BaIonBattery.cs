namespace KSBL_csharpprep_Lab1
{
    public class BaIonBattery : BasicBattery
    {
        public BaIonBattery(int power, int capacity, bool fastRecovery) : base(power,
            capacity, fastRecovery)
        {
        }

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