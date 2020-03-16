namespace KSBL_Class_Library.Components.Battery
{
    public class BaIonBattery : Battery
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