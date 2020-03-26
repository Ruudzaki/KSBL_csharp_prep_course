namespace KSBL_Class_Library.Components.Battery
{
    public abstract class BasicBattery
    {
        protected BasicBattery(int power, int capacity, bool fastRecovery)
        {
            Power = power;
            Capacity = capacity;
            FastRecovery = fastRecovery;
        }

        public int Power { get; }
        public int Capacity { get; }
        public bool FastRecovery { get; }

        public abstract void Charge(ICharge charge);
    }
}