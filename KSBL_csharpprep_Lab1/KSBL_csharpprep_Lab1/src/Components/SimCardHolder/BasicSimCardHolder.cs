namespace KSBL_csharpprep_Lab1
{
    public abstract class BasicSimCardHolder
    {
        protected BasicSimCardHolder(string simCardCaseType)
        {
            SimCardCaseType = simCardCaseType;
        }

        public string SimCardCaseType { get; }

        public abstract void Call(ICall call);
    }
}