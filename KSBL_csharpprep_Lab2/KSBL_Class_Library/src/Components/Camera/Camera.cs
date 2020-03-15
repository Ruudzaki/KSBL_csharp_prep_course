using System.Collections.Generic;

namespace KSBL_Class_Library
{
    public abstract class Camera
    {
        public int CameraDiafragm { get; set; }
        public int CameraResolution { get; set; }

        public abstract void TakePhoto(ITakePhoto takePhoto);
    }
}