namespace KSBL_csharpprep_Lab1
{
    public abstract class BasicBattery
    {
        public BasicBattery(int power, int capacity, bool fastRecovery)
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