using System.Collections.Generic;
using System.Text;

namespace KSBL_csharpprep_Lab1
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract BasicTouch TouchScreen { get; }
        public abstract BasicCamera MainCamera { get; }
        public abstract BasicCamera FrontalCamera { get; }
        public abstract BasicBattery Battery { get; }
        public abstract BasicCPU CPU { get; }
        public abstract BasicCPU GraphCPU { get; }
        public abstract BasicRAM RAM { get; }
        public abstract BasicHardMemory InternalHardMemory { get; }
        public abstract BasicHardMemory ExternalHardMemory { get; }
        public abstract BasicSimCard SimCard { get; }
        public abstract BasicMicrophone Microphone { get; }
        public abstract BasicDynamic Dynamic { get; }
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

        private void LoadFromIntHardMemory(ILoadFromHardMemory loadFromHardMemory)
        {
            InternalHardMemory.LoadFromHardMemory(loadFromHardMemory);
        }

        private void LoadFromExtHardMemory(ILoadFromHardMemory loadFromHardMemory)
        {
            ExternalHardMemory.LoadFromHardMemory(loadFromHardMemory);
        }

        private void LoadToIntHardMemory(ILoadToHardMemory loadToHardMemory)
        {
            InternalHardMemory.LoadToHardMemory(loadToHardMemory);
        }

        private void LoadToExtHardMemory(ILoadToHardMemory loadToHardMemory)
        {
            ExternalHardMemory.LoadToHardMemory(loadToHardMemory);
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
            Dynamic.PlaySound(playSound);
        }

        private void PressButton(IPressButton pressButton)
        {
            Keyboard.PressButton(pressButton);
        }

        public string GetDescription()
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
            descriptionBuilder.AppendLine($"Internal Memory: {InternalHardMemory}");
            descriptionBuilder.AppendLine($"External Memory: {ExternalHardMemory}");
            descriptionBuilder.AppendLine($"SimCard: {SimCard}");
            descriptionBuilder.AppendLine($"Microphone: {Microphone}");
            descriptionBuilder.AppendLine($"Dynamic: {Dynamic}");
            descriptionBuilder.AppendLine($"Keyboard: {Keyboard}");
            return descriptionBuilder.ToString();
        }
    }

    public class SimCorpMobile : Mobile
    {
        private readonly CPU vCPU = new CPU(new List<Core> {new Core(), new Core()});
        private readonly Dynamic vDynamic = new Dynamic();
        private readonly ExternalHardMemory vExternalHardMemory = new ExternalHardMemory();
        private readonly FrontalCamera vFrontalCamera = new FrontalCamera();

        private readonly GraphCPU vGraphCPU = new GraphCPU(new List<Core>
            {new Core(), new Core(), new Core(), new Core()});

        private readonly InternalHardMemory vInternalHardMemory = new InternalHardMemory();
        private readonly DigitalKeyboard vKeyboard = new DigitalKeyboard();
        private readonly LiIonBattery vLiIonBattery = new LiIonBattery();
        private readonly Microphone vMicrophone = new Microphone();

        private readonly MultiMainCamera vMultiMainCamera = new MultiMainCamera(new List<MainCamera>
        {
            new MainCamera(),
            new MainCamera(),
            new MainCamera()
        });

        private readonly MultiSimCard vMultiSimCard = new MultiSimCard(new List<SimCard>
        {
            new SimCard(),
            new SimCard()
        });

        private readonly MultiTouchScreen vMultiTouchScreen = new MultiTouchScreen(10);
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();
        private readonly RAM vRAM = new RAM();


        public override ScreenBase Screen => vOLEDScreen;
        public override BasicTouch TouchScreen => vMultiTouchScreen;
        public override BasicCamera MainCamera => vMultiMainCamera;
        public override BasicBattery Battery => vLiIonBattery;
        public override BasicCamera FrontalCamera => vFrontalCamera;
        public override BasicCPU CPU => vCPU;
        public override BasicCPU GraphCPU => vGraphCPU;
        public override BasicRAM RAM => vRAM;
        public override BasicHardMemory ExternalHardMemory => vExternalHardMemory;
        public override BasicHardMemory InternalHardMemory => vInternalHardMemory;
        public override BasicSimCard SimCard => vMultiSimCard;
        public override BasicMicrophone Microphone => vMicrophone;
        public override BasicDynamic Dynamic => vDynamic;
        public override BasicKeyboard Keyboard => vKeyboard;
    }
}