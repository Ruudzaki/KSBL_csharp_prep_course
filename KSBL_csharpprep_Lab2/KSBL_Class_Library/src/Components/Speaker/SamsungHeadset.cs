using System;

namespace KSBL_Class_Library.src.Components.Speaker
{
    public class SamsungHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}
