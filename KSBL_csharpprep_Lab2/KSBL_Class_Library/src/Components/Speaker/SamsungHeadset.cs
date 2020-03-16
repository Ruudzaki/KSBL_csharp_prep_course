using System;

namespace KSBL_Class_Library.Components.Speaker
{
    public class SamsungHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}