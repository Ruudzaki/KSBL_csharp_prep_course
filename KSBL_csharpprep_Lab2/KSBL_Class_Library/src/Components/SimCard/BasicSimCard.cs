namespace KSBL_Class_Library.Components.SimCard
{
    public abstract class BasicSimCard
    {
        public string SimCardType { get; set; }
        public string OperatorName { get; set; }

        public abstract void Call(ICall call);
    }
}