using KSBL_Class_Library.src.Components.Speaker;
using System.Text;
using System;

namespace KSBL_Class_Library.Mobile
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract BasicTouch TouchScreen { get; }

        public void SelectPlaybackComponent()
        {
            Console.WriteLine("Select playback component (specify index):");
            Console.WriteLine("1 - Apple Headset");
            Console.WriteLine("2 - Samsung Headset");
            Console.WriteLine("3 - Unofficial Apple Headset");
            Console.WriteLine("4 - Speaker");

            int index = 0;

            try
            {
                index = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Wrong input.");
            }

            switch (index)
            {
                case (1):
                    PlaybackComponent = new AppleHeadset();
                    Console.WriteLine("Apple Headset playback selected");
                    break;
                case (2):
                    PlaybackComponent = new SamsungHeadset();
                    Console.WriteLine("Samsung Headset playback selected");
                    break;
                case (3):
                    PlaybackComponent = new UnofficialAppleHeadset();
                    Console.WriteLine("Unofficial Apple Headset playback selected");
                    break;
                case (4):
                    PlaybackComponent = new Speaker();
                    Console.WriteLine("Speaker playback selected");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
                
            }

            Console.WriteLine($"Set playback to {nameof(Mobile)}...");
        }

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

        public IPlayback PlaybackComponent { get; set; }


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

        public void Play(object data)
        {
            Console.WriteLine($"Play sound in {nameof(Mobile)}:");
            PlaybackComponent.Play(data);
        }

        private void PressButton(IPressButton pressButton)
        {
            Keyboard.PressButton(pressButton);
        }

        public override string ToString()
        {
            Console.WriteLine($"{this.GetType().Name} description:");
            Console.WriteLine();
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