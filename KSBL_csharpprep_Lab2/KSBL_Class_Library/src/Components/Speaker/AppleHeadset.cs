using System;

namespace KSBL_Class_Library.Components.Speaker
{
    public class AppleHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(AppleHeadset)} sound");
        }
    }
}