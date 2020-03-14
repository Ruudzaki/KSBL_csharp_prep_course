using System.Collections.Generic;
using System.Text;

namespace KSBL_csharpprep_Lab1
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract BasicTouch TouchScreen { get; }
        public abstract Camera MainCamera { get; }
        public abstract Camera FrontalCamera { get; }
        public abstract Battery Battery { get; }
        public abstract BasicCPU CPU { get; }
        public abstract BasicCPU GraphCPU { get; }
        public abstract BasicRAM RAM { get; }
        public abstract Storage InternalStorage { get; }
        public abstract Storage ExternalStorage { get; }
        public abstract BasicSimCard SimCard { get; }
        public abstract BasicMicrophone Microphone { get; }
        public abstract BasicSpeaker Speaker { get; }
        public abstract BasicKeyboard Keyboard { get; }


        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        private void Touch(IScreenTouch screenTouch)
        {
            TouchScreen.Touch(screenTouch);
        }

        private void TakeMainPhoto(ITakePhoto takePhoto)
        {
            MainCamera.TakePhoto(takePhoto);
        }

        private void TakeFrontalPhoto(ITakePhoto takePhoto)
        {
            FrontalCamera.TakePhoto(takePhoto);
        }

        private void Charge(ICharge charge)
        {
            Battery.Charge(charge);
        }

        private void CPUProcess(IProcess process)
        {
            CPU.Process(process);
        }

        private void GraphCPUProcess(IProcess process)
        {
            GraphCPU.Process(process);
        }

        private void LoadFromRAM(ILoadFromRAM loadFromRam)
        {
            RAM.LoadFromRAM(loadFromRam);
        }

        private void LoadToRAM(ILoadToRAM loadToRam)
        {
            RAM.LoadToRAM(loadToRam);
        }

        private void LoadFromIntHardMemory(LoadFromStorage loadFromHardMemory)
        {
            InternalStorage.LoadFromHardMemory(loadFromHardMemory);
        }

        private void LoadFromExtHardMemory(LoadFromStorage loadFromHardMemory)
        {
            ExternalStorage.LoadFromHardMemory(loadFromHardMemory);
        }

        private void LoadToIntHardMemory(ILoadToStorage loadToHardMemory)
        {
            InternalStorage.LoadToHardMemory(loadToHardMemory);
        }

        private void LoadToExtHardMemory(ILoadToStorage loadToHardMemory)
        {
            ExternalStorage.LoadToHardMemory(loadToHardMemory);
        }

        private void Call(ICall call)
        {
            SimCard.Call(call);
        }

        private void RecordSound(IRecordSound recordSound)
        {
            Microphone.RecordSound(recordSound);
        }

        private void PlaySound(IPlaySound playSound)
        {
            Speaker.PlaySound(playSound);
        }

        private void PressButton(IPressButton pressButton)
        {
            Keyboard.PressButton(pressButton);
        }

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen}");
            descriptionBuilder.AppendLine($"Touch Screen: {TouchScreen}");
            descriptionBuilder.AppendLine($"Main Camera: {MainCamera}");
            descriptionBuilder.AppendLine($"Frontal Camera: {FrontalCamera}");
            descriptionBuilder.AppendLine($"Battery: {Battery}");
            descriptionBuilder.AppendLine($"CPU: {CPU}");
            descriptionBuilder.AppendLine($"Graph CPU: {GraphCPU}");
            descriptionBuilder.AppendLine($"RAM: {RAM}");
            descriptionBuilder.AppendLine($"Internal Storage: {InternalStorage}");
            descriptionBuilder.AppendLine($"External Storage: {ExternalStorage}");
            descriptionBuilder.AppendLine($"SimCard: {SimCard}");
            descriptionBuilder.AppendLine($"Microphone: {Microphone}");
            descriptionBuilder.AppendLine($"Speaker: {Speaker}");
            descriptionBuilder.AppendLine($"Keyboard: {Keyboard}");
            return descriptionBuilder.ToString();
        }
    }
}