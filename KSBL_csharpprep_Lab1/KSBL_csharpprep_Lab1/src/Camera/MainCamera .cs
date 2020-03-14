using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public class MainCamera : Camera
    {
        public override void TakePhoto(ITakePhoto takePhoto)
        {
            //here logic for Main Camera take photo action
        }

        public override string ToString()
        {
            return "Main camera";
        }
    }
}