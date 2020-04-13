namespace KSBL_Class_Library.Components.Battery.ChargerFactory
{
    public class ChargerThreadCreator : ChargerCreator
    {
        public override Charger Create()
        {
            return new ChargerThread();
        }
    }
}