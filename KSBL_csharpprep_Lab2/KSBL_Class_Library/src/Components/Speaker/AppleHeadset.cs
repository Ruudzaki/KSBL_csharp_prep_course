using System;

namespace KSBL_Class_Library.src.Components.Speaker
{
    public class AppleHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(AppleHeadset)} sound");
        }
    }
}
