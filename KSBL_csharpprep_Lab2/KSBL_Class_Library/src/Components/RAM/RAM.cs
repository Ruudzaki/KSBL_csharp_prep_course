﻿namespace KSBL_Class_Library
{

    public class RAM : BasicRAM
    {
        public override void LoadFromRAM(ILoadFromRAM loadFromRam)
        {
            //here logic for Load from RAM process 
        }

        public override void LoadToRAM(ILoadToRAM loadFromRam)
        {
            //here logic for Load to RAM process
        }

        public override string ToString()
        {
            return "RAM";
        }
    }
}