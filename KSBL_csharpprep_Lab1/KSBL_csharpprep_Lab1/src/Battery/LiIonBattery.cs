namespace KSBL_csharpprep_Lab1
{

    public class LiIonBattery : Battery
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
}