﻿namespace KSBL_Class_Library
{


    public class Microphone : BasicMicrophone
    {
        public override void RecordSound(IRecordSound recordSound)
        {
            //here logic for record from microphone
        }

        public override string ToString()
        {
            return "Microphone";
        }
    }
}