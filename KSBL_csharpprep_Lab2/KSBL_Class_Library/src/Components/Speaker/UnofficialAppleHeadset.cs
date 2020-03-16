using System;

namespace KSBL_Class_Library.Components.Speaker
{
    public class UnofficialAppleHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(UnofficialAppleHeadset)} sound");
        }
    }
}