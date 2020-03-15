using System;

namespace KSBL_Class_Library.src.Components.Speaker
{
    public class UnofficialAppleHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(UnofficialAppleHeadset)} sound");
        }
    }
}
