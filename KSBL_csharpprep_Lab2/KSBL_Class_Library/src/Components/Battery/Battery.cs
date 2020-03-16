namespace KSBL_Class_Library.Components.Battery
{
    public abstract class Battery
    {
        public string BatteryType { get; set; }
        public int Power { get; set; }
        public int Capacity { get; set; }
        public bool FastRecovery { get; set; }

        public abstract void Charge(ICharge charge);
    }
}