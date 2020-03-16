using System;

namespace KSBL_Class_Library.Components.Speaker
{
    public class Speaker : BasicSpeaker
    {
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