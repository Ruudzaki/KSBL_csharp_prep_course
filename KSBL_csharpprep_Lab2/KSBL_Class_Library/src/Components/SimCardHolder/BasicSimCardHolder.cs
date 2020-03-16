namespace KSBL_Class_Library.Components.SimCardHolder
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