namespace KSBL_Class_Library.Components.SimCard
{
    internal class SimCard : BasicSimCard
    {
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