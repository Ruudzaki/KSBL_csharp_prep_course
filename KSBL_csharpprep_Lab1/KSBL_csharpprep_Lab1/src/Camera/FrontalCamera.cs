﻿using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public class FrontalCamera : Camera
    {
        public override void TakePhoto(ITakePhoto takePhoto)
        {
            //here logic for Frontal Camera take photo action
        }

        public override string ToString()
        {
            return "Frontal camera";
        }
    }
}