using System.Collections.Generic;
using KSBL_Class_Library.Components.Battery;
using KSBL_Class_Library.Components.Camera;
using KSBL_Class_Library.Components.CPU;
using KSBL_Class_Library.Components.Keyboard;
using KSBL_Class_Library.Components.Microphone;
using KSBL_Class_Library.Components.RAM;
using KSBL_Class_Library.Components.Screen;
using KSBL_Class_Library.Components.SimCard;
using KSBL_Class_Library.Components.Speaker;
using KSBL_Class_Library.Components.Storage;
using KSBL_Class_Library.Components.TouchScreen;

namespace KSBL_Class_Library.Mobile
{
    public class SimCorpMobile : Mobile
    {
        private readonly Cpu _vCpu = new Cpu(new List<Core> {new Core(), new Core()});
        private readonly ExternalStorage _vExternalStorage = new ExternalStorage();
        private readonly FrontalCamera _vFrontalCamera = new FrontalCamera();

        private readonly GraphCpu _vGraphCpu = new GraphCpu(new List<Core>
            {new Core(), new Core(), new Core(), new Core()});

        private readonly InternalStorage _vInternalStorage = new InternalStorage();
        private readonly DigitalKeyboard _vKeyboard = new DigitalKeyboard();
        private readonly LiIonBattery _vLiIonBattery = new LiIonBattery();
        private readonly Microphone _vMicrophone = new Microphone();

        private readonly MultiMainCamera _vMultiMainCamera = new MultiMainCamera(new List<MainCamera>
        {
            new MainCamera(),
            new MainCamera(),
            new MainCamera()
        });

        private readonly MultiSimCard _vMultiSimCard = new MultiSimCard(new List<SimCard>
        {
            new SimCard(),
            new SimCard()
        });

        private readonly MultiTouchScreen _vMultiTouchScreen = new MultiTouchScreen(10);
        private readonly OledScreen _vOledScreen = new OledScreen();
        private readonly Ram _vRam = new Ram();
        private readonly Speaker _vSpeaker = new Speaker();


        public override ScreenBase Screen => _vOledScreen;
        public override BasicTouch TouchScreen => _vMultiTouchScreen;
        public override Camera MainCamera => _vMultiMainCamera;
        public override Battery Battery => _vLiIonBattery;
        public override Camera FrontalCamera => _vFrontalCamera;
        public override BasicCpu Cpu => _vCpu;
        public override BasicCpu GraphCpu => _vGraphCpu;
        public override BasicRam Ram => _vRam;
        public override Storage ExternalStorage => _vExternalStorage;
        public override Storage InternalStorage => _vInternalStorage;
        public override BasicSimCard SimCard => _vMultiSimCard;
        public override BasicMicrophone Microphone => _vMicrophone;
        public override BasicSpeaker Speaker => _vSpeaker;
        public override BasicKeyboard Keyboard => _vKeyboard;
    }
}