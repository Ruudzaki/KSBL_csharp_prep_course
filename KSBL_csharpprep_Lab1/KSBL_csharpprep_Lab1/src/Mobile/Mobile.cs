using System.Text;

namespace KSBL_csharpprep_Lab1
{
    public abstract class Mobile
    {
        public abstract BasicScreen Screen { get; }
        public abstract BasicTouch TouchScreen { get; }
        public abstract BasicCamera MainCamera { get; }
        public abstract BasicCamera FrontalCamera { get; }
        public abstract BasicBattery Battery { get; }
        public abstract BasicCpu Cpu { get; }
        public abstract BasicCpu GraphCpu { get; }
        public abstract BasicRAM Ram { get; }
        public abstract BasicStorage InternalStorage { get; }
        public abstract BasicStorage ExternalStorage { get; }
        public abstract BasicSimCardHolder SimCardHolder { get; }
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

        private void CpuProcess(IProcess process)
        {
            Cpu.Process(process);
        }

        private void GraphCpuProcess(IProcess process)
        {
            GraphCpu.Process(process);
        }

        private void LoadFromRam(ILoadFromRAM loadFromRam)
        {
            Ram.LoadFromRAM(loadFromRam);
        }

        private void LoadToRam(ILoadToRAM loadToRam)
        {
            Ram.LoadToRAM(loadToRam);
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
            SimCardHolder.Call(call);
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
            descriptionBuilder.AppendLine($"CPU: {Cpu}");
            descriptionBuilder.AppendLine($"Graph CPU: {GraphCpu}");
            descriptionBuilder.AppendLine($"RAM: {Ram}");
            descriptionBuilder.AppendLine($"Internal Storage: {InternalStorage}");
            descriptionBuilder.AppendLine($"External Storage: {ExternalStorage}");
            descriptionBuilder.AppendLine($"SimCard: {SimCardHolder}");
            descriptionBuilder.AppendLine($"Microphone: {Microphone}");
            descriptionBuilder.AppendLine($"Speaker: {Speaker}");
            descriptionBuilder.AppendLine($"Keyboard: {Keyboard}");
            return descriptionBuilder.ToString();
        }
    }
}