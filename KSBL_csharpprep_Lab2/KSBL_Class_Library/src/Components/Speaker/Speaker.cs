using System;

namespace KSBL_Class_Library
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