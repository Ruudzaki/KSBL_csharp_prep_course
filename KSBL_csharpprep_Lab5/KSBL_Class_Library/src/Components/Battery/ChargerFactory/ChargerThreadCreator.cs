namespace KSBL_Class_Library.Components.Battery.ChargerFactory
{
    internal class ChargerThreadCreator : ChargerCreator
    {
        public override Charger Create()
        {
            return new ChargerThread();
        }
    }
}