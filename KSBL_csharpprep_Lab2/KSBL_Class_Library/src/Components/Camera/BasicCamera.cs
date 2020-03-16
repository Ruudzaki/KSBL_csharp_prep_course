namespace KSBL_Class_Library.Components.Camera
{
    public abstract class BasicCamera
    {
        protected BasicCamera(double cameraDiafragm, int cameraResolution)
        {
            CameraDiafragm = cameraDiafragm;
            CameraResolution = cameraResolution;
        }

        public double CameraDiafragm { get; }
        public int CameraResolution { get; }

        public abstract void TakePhoto(ITakePhoto takePhoto);
    }
}