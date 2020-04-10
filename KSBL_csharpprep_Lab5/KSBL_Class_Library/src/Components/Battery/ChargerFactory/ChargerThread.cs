using System.Threading;

namespace KSBL_Class_Library.Components.Battery.ChargerFactory
{
    internal class ChargerThread : Charger
    {
        private Thread ChargeDecrease { get; set; }

        public override void Charge()
        {
            ChargerIsOn = true;
            var thread = new Thread(ChargeThreadStart);
            thread.Start();
        }

        private void ChargeThreadStart()
        {
            lock (Lock)
            {
                while (ChargerIsOn)
                {
                    if (ChargeLevel < 100) ChargeLevel++;
                    OnChargerUpdated(ChargeLevel);
                    Thread.Sleep(1000);
                }
            }
        }

        protected override void ChargeLevelDecreaseStart()
        {
            ChargeDecrease = new Thread(ChargeLevelDecrease);
            ChargeDecrease.Start();
        }

        public override void ChargeLevelDecreaseStop()
        {
            ChargeDecrease.Abort();
        }

        private void ChargeLevelDecrease()
        {
            while (true)
                lock (Lock)
                {
                    if (ChargeLevel > 0) ChargeLevel--;
                    OnChargerUpdated(ChargeLevel);
                    Thread.Sleep(1000);
                }
        }
    }
}