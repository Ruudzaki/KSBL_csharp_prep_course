using System.Collections.Generic;

namespace KSBL_Class_Library.Components.Camera
{
    public class MultiMainCamera : MainCamera
    {
        public MultiMainCamera(List<MainCamera> cameras)
        {
            Cameras = cameras;
        }

        public List<MainCamera> Cameras { get; set; }

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