namespace KSBL_csharpprep_Lab1
{
    internal class SimCardHolder : BasicSimCardHolder
    {
        public SimCardHolder(string simCardCaseType) : base(simCardCaseType)
        {
        }

        public override void Call(ICall call)
        {
            //here logic for call with one SimCard
        }

        public override string ToString()
        {
            return "1 SimCard";
        }
    }
}