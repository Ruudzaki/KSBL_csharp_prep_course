using KSBL_Class_Library.Components.Battery.ChargerFactory;

namespace KSBL_Class_Library.Components.Battery
{
    public abstract class BasicBattery
    {
        protected BasicBattery(int power, int capacity, bool fastRecovery)
        {
            Power = power;
            Capacity = capacity;
            FastRecovery = fastRecovery;
            ChargeLevel = 100;

            ChargerCreator chargerCreator1 = new ChargerTaskCreator();
            ChargerCreator chargerCreator2 = new ChargerThreadCreator();

            Charger = chargerCreator1.Create();
        }

        public int ChargeLevel { get; set; }
        public Charger Charger { get; set; }

        public int Power { get; }
        public int Capacity { get; }
        public bool FastRecovery { get; }

        public abstract void Charge(ICharge charge);
    }
}