using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public interface ITakePhoto
    {
    }

    public abstract class BasicCamera
    {
        public int CameraDiafragm { get; set; }
        public int CameraResolution { get; set; }

        public abstract void TakePhoto(ITakePhoto takePhoto);
    }

    internal class Camera : BasicCamera
    {
        public override void TakePhoto(ITakePhoto takePhoto)
        {
            //here logic for basic take photo action
        }

        public override string ToString()
        {
            return "Camera";
        }
    }

    internal class MainCamera : Camera
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

    internal class MultiMainCamera : MainCamera
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
            return string.Format("Main multi camera with {0} cameras", Cameras.Count);
        }
    }

    internal class FrontalCamera : Camera
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