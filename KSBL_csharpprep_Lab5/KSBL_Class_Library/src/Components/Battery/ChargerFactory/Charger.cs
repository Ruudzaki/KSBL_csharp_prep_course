namespace KSBL_Class_Library.Components.Battery.ChargerFactory
{
    public delegate void ChargerUpdatedDelegate(int chargeLevel);

    public abstract class Charger
    {
        protected object Lock = new object();
        private int _chargeLevel;

        protected Charger()
        {
            ChargeLevel = 100;
            ChargerIsOn = false;
            ChargeLevelDecreaseStart();
        }

        public int ChargeLevel
        {
            get { return _chargeLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                    _chargeLevel = value;
            }
        }

        public bool ChargerIsOn { get; protected set; }
        public event ChargerUpdatedDelegate ChargerUpdated;

        public abstract void Charge();

        public void Discharge()
        {
            ChargerIsOn = false;
        }

        protected abstract void ChargeLevelDecreaseStart();
        public abstract void Stop();

        protected void OnChargerUpdated(int chargeLevel)
        {
            var handler = ChargerUpdated;
            handler?.Invoke(chargeLevel);
        }
    }
}