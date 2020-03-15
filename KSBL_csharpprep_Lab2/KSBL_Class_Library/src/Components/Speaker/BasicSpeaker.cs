using System;
using KSBL_Class_Library.src.Components.Speaker;

namespace KSBL_Class_Library
{

    public abstract class BasicSpeaker : IPlayback
    {
        public int LowestDMP { get; set; }
        public int HighestDMP { get; set; }
        public double Power { get; set; }
        public int Amount { get; set; }

        public abstract void Play(object data);
    }

  
}