using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public class MultiMainBasicCamera : MainBasicCamera
    {
        public MultiMainBasicCamera(double cameraDiafragm, int cameraResolution, List<MainBasicCamera> cameras) : base(
            cameraDiafragm, cameraResolution)
        {
            Cameras = cameras;
        }

        public List<MainBasicCamera> Cameras { get; set; }

        public override void TakePhoto(ITakePhoto takePhoto)
        {
            //here logic for Main Multi Camera take photo action
        }

        public override string ToString()
        {
            return $"Main multi camera with {Cameras.Count} cameras";
        }
    }
}