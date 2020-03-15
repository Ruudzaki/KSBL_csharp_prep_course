namespace KSBL_Class_Library
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