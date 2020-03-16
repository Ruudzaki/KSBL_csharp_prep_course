using System;

namespace KSBL_Class_Library.Components.Speaker
{
    public class Speaker : BasicSpeaker
    {
        public Speaker(int lowestDmp, int highestDmp, double power, int amount) : base(lowestDmp, highestDmp, power,
            amount)
        {
        }

        public override void Play(object data)
        {
            Console.WriteLine($"{nameof(Speaker)} sound");
        }

        public override string ToString()
        {
            return "Dynamic";
        }
    }
}