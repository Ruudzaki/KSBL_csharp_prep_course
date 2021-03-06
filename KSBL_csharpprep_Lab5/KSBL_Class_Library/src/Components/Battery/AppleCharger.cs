﻿namespace KSBL_Class_Library.Components.Battery
{
    public class AppleCharger : ICharge
    {
        public AppleCharger(int voltage, IOutput output)
        {
            Voltage = voltage;
            Output = output;
        }

        public IOutput Output { get; }
        public int Voltage { get; }

        public string Charge(object data)
        {
            if (Output != null) return Output.WriteLine($"{nameof(AppleCharger)} charge with {Voltage} voltage.");

            return "No Output!";
        }
    }
}