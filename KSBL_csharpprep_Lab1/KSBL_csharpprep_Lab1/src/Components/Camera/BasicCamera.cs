namespace KSBL_csharpprep_Lab1
{
    public abstract class BasicCamera
    {
        public BasicCamera(double cameraDiafragm, int cameraResolution)
        {
            CameraDiafragm = cameraDiafragm;
            CameraResolution = cameraResolution;
        }

        public double CameraDiafragm { get; }
        public int CameraResolution { get; }

        public abstract void TakePhoto(ITakePhoto takePhoto);
    }
}