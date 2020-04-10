namespace KSBL_Class_Library.Components.Battery.ChargerFactory
{
    internal class ChargerTaskCreator : ChargerCreator
    {
        public override Charger Create()
        {
            return new ChargerTask();
        }
    }
}