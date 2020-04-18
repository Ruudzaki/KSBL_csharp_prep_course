using System;
using System.Text;
using KSBL_Class_Library.Components.Battery;
using KSBL_Class_Library.Components.Camera;
using KSBL_Class_Library.Components.CPU;
using KSBL_Class_Library.Components.Keyboard;
using KSBL_Class_Library.Components.Microphone;
using KSBL_Class_Library.Components.RAM;
using KSBL_Class_Library.Components.Screen;
using KSBL_Class_Library.Components.SimCardHolder;
using KSBL_Class_Library.Components.Speaker;
using KSBL_Class_Library.Components.Storage;
using KSBL_Class_Library.Components.TouchScreen;

namespace KSBL_Class_Library.Mobile
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
        public abstract BasicRam Ram { get; }
        public abstract BasicStorage InternalStorage { get; }
        public abstract BasicStorage ExternalStorage { get; }
        public abstract BasicSimCardHolder SimCardHolder { get; }
        public abstract BasicMicrophone Microphone { get; }
        public abstract BasicSpeaker Speaker { get; }

        public abstract BasicKeyboard Keyboard { get; }

        //public SmsProvider SmsProvider { get; set; }
        public IPlayback PlaybackComponent { get; set; }
        public IOutput Output { get; set; }
        public ICharge ChargeComponent { get; set; }

        public void SelectPlaybackComponent()
        {
            Console.WriteLine("Select playback component (specify index):");
            Console.WriteLine("0 - No playback component");
            Console.WriteLine("1 - Apple Headset");
            Console.WriteLine("2 - Samsung Headset");
            Console.WriteLine("3 - Unofficial Apple Headset");
            Console.WriteLine("4 - Speaker");

            int index;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < 5) break;
                Console.WriteLine("Please enter a valid integer value!");
            }

            SelectPlaybackComponent(index);
        }

        public string SelectPlaybackComponent(int index)
        {
            var selectionBuilder = new StringBuilder();

            switch (index)
            {
                case 1:
                    PlaybackComponent = new AppleHeadset(Output);
                    selectionBuilder.AppendLine(Output.WriteLine("Apple Headset playback selected"));
                    break;
                case 2:
                    PlaybackComponent = new SamsungHeadset(Output);
                    selectionBuilder.AppendLine(Output.WriteLine("Samsung Headset playback selected"));
                    break;
                case 3:
                    PlaybackComponent = new UnofficialAppleHeadset(Output);
                    selectionBuilder.AppendLine(Output.WriteLine("Unofficial Apple Headset playback selected"));
                    break;
                case 4:
                    PlaybackComponent = Speaker;
                    Speaker.Output = Output;
                    selectionBuilder.AppendLine(Output.WriteLine("Speaker playback selected"));
                    break;
                default:
                    selectionBuilder.AppendLine(Output.WriteLine("No playback selected"));
                    break;
            }

            if (PlaybackComponent != null)
                selectionBuilder.AppendLine(Output.WriteLine($"Set playback to {nameof(Mobile)}..."));

            return selectionBuilder.ToString();
        }

        public void SelectChargeComponent()
        {
            Console.WriteLine("Select charge component (specify index):");
            Console.WriteLine("0 - No charge component");
            Console.WriteLine("1 - Apple Charger");
            Console.WriteLine("2 - Xiaomi Charger");

            int index;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < 3) break;
                Console.WriteLine("Please enter a valid integer value!");
            }

            SelectChargeComponent(index);
        }

        public string SelectChargeComponent(int index)
        {
            var selectionBuilder = new StringBuilder();

            switch (index)
            {
                case 1:
                    ChargeComponent = new AppleCharger(110, Output);
                    selectionBuilder.AppendLine(Output.WriteLine("Apple Charger playback selected"));
                    break;
                case 2:
                    ChargeComponent = new XiaomiCharger(220, Output);
                    selectionBuilder.AppendLine(Output.WriteLine("Xiaomi Charger playback selected"));
                    break;
                default:
                    selectionBuilder.AppendLine(Output.WriteLine("No Charger selected"));
                    break;
            }

            if (ChargeComponent != null)
                selectionBuilder.AppendLine(Output.WriteLine($"Set charger to {nameof(Mobile)}..."));

            return selectionBuilder.ToString();
        }

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

        public string Charge()
        {
            if (Output == null) return "No Output!";
            if (ChargeComponent == null) return Output.WriteLine("No charge component to charge");
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(
                Output.WriteLine($"Charge battery in {nameof(Mobile)} by {Output.GetType()}:"));
            stringBuilder.AppendLine(ChargeComponent.Charge(""));
            return stringBuilder.ToString();
        }

        private void CpuProcess(IProcess process)
        {
            Cpu.Process(process);
        }

        private void GraphCpuProcess(IProcess process)
        {
            GraphCpu.Process(process);
        }

        private void LoadFromRam(ILoadFromRam loadFromRam)
        {
            Ram.LoadFromRam(loadFromRam);
        }

        private void LoadToRam(ILoadToRam loadToRam)
        {
            Ram.LoadToRam(loadToRam);
        }

        private void LoadFromIntHardMemory(ILoadFromStorage loadFromHardMemory)
        {
            InternalStorage.LoadFromHardMemory(loadFromHardMemory);
        }

        private void LoadFromExtHardMemory(ILoadFromStorage loadFromHardMemory)
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

        public string Play(object data)
        {
            if (Output == null) return "No Output!";
            if (PlaybackComponent != null)
            {
                var stringBuilder = new StringBuilder();

                stringBuilder.AppendLine(
                    Output.WriteLine($"Play sound in {nameof(Mobile)} by {Output.GetType()}:"));
                stringBuilder.AppendLine(PlaybackComponent.Play(data));
                return stringBuilder.ToString();
            }

            return Output.WriteLine("No playback component to play");
        }

        private void PressButton(IPressButton pressButton)
        {
            Keyboard.PressButton(pressButton);
        }

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Name: {GetType()}");
            descriptionBuilder.AppendLine();
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