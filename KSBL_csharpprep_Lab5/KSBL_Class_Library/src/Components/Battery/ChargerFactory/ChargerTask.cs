using System.Threading;
using System.Threading.Tasks;

namespace KSBL_Class_Library.Components.Battery.ChargerFactory
{
    internal class ChargerTask : Charger
    {
        public bool WindowClosed { get; set; }

        public override async void Charge()
        {
            ChargerIsOn = true;

            await Task.Run(() =>
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
            });
        }

        protected override async void ChargeLevelDecreaseStart()
        {
            await Task.Run(() =>
            {
                while (true)
                    lock (Lock)
                    {
                        if (ChargeLevel > 0) ChargeLevel--;
                        OnChargerUpdated(ChargeLevel);
                        Thread.Sleep(1000);
                        if (WindowClosed) break;
                    }
            });
        }

        public override void ChargeLevelDecreaseStop()
        {
            WindowClosed = true;
        }
    }
}