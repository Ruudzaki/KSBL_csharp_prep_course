﻿namespace KSBL_Class_Library.Components.Camera
{
    public class MainBasicCamera : BasicCamera
    {
        public MainBasicCamera(double cameraDiafragm, int cameraResolution) : base(cameraDiafragm, cameraResolution)
        {
        }

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