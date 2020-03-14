using System.Collections.Generic;
using System.Text;

namespace KSBL_csharpprep_Lab1
{

    public class SimCorpMobile : Mobile
    {
        private readonly CPU vCPU = new CPU(new List<Core> {new Core(), new Core()});
        private readonly Speaker vSpeaker = new Speaker();
        private readonly ExternalStorage vExternalStorage = new ExternalStorage();
        private readonly FrontalCamera vFrontalCamera = new FrontalCamera();

        private readonly GraphCPU vGraphCPU = new GraphCPU(new List<Core>
            {new Core(), new Core(), new Core(), new Core()});

        private readonly InternalStorage vInternalStorage = new InternalStorage();
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
        public override Camera MainCamera => vMultiMainCamera;
        public override Battery Battery => vLiIonBattery;
        public override Camera FrontalCamera => vFrontalCamera;
        public override BasicCPU CPU => vCPU;
        public override BasicCPU GraphCPU => vGraphCPU;
        public override BasicRAM RAM => vRAM;
        public override Storage ExternalStorage => vExternalStorage;
        public override Storage InternalStorage => vInternalStorage;
        public override BasicSimCard SimCard => vMultiSimCard;
        public override BasicMicrophone Microphone => vMicrophone;
        public override BasicSpeaker Speaker => vSpeaker;
        public override BasicKeyboard Keyboard => vKeyboard;
    }
}