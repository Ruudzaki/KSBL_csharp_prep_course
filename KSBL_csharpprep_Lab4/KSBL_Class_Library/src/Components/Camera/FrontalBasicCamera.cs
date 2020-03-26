namespace KSBL_Class_Library.Components.Camera
{
    public class FrontalBasicCamera : BasicCamera
    {
        public FrontalBasicCamera(double cameraDiafragm, int cameraResolution) : base(cameraDiafragm, cameraResolution)
        {
        }

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