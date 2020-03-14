using System.Collections.Generic;
using KSBL_csharpprep_Lab1.Components.Battery;
using KSBL_csharpprep_Lab1.Components.Camera;
using KSBL_csharpprep_Lab1.Components.CPU;
using KSBL_csharpprep_Lab1.Components.Keyboard;
using KSBL_csharpprep_Lab1.Components.Microphone;
using KSBL_csharpprep_Lab1.Components.RAM;
using KSBL_csharpprep_Lab1.Components.Screen;
using KSBL_csharpprep_Lab1.Components.SimCardHolder;
using KSBL_csharpprep_Lab1.Components.Speaker;
using KSBL_csharpprep_Lab1.Components.Storage;
using KSBL_csharpprep_Lab1.Components.TouchScreen;

namespace KSBL_csharpprep_Lab1.Mobile
{
    public class SimCorpMobile : Mobile
    {
        private readonly Cpu _vCpu = new Cpu("Intel", new List<Core> {new Core(64, 2.1), new Core(64, 2.1)});
        private readonly ExternalStorage _vExternalStorage = new ExternalStorage(128);
        private readonly FrontalBasicCamera _vFrontalBasicCamera = new FrontalBasicCamera(1.5, 5);

        private readonly GraphCpu _vGraphCpu = new GraphCpu("AMD", new List<Core>
            {new Core(64, 2.1), new Core(64, 2.1), new Core(64, 2.1), new Core(64, 2.1)});

        private readonly InternalStorage _vInternalStorage = new InternalStorage(64);
        private readonly DigitalKeyboard _vKeyboard = new DigitalKeyboard(new List<char>(), new List<char>());
        private readonly LiIonBattery _vLiIonBattery = new LiIonBattery(5, 2200, true);
        private readonly Microphone _vMicrophone = new Microphone("Internal", 3.5, 2);

        private readonly MultiMainBasicCamera _vMultiMainBasicCamera = new MultiMainBasicCamera(2.5, 12,
            new List<MainBasicCamera>
            {
                new MainBasicCamera(2.5, 12),
                new MainBasicCamera(2.5, 12),
                new MainBasicCamera(2.5, 12)
            });

        private readonly MultiSimCardHolder _vMultiSimCardHolder = new MultiSimCardHolder("DoubleSim",
            new List<SimCardHolder>
            {
                new SimCardHolder("microSim"),
                new SimCardHolder("microSim")
            });

        private readonly MultiTouchScreen _vMultiTouchScreen = new MultiTouchScreen("Multi", 10);

        private readonly OLedBasicScreen _vOLedBasicScreen = new OLedBasicScreen(1080, 1920, 7, 233);
        private readonly Ram _vRam = new Ram(4);
        private readonly Speaker _vSpeaker = new Speaker(15, 15000, 4.5, 3);


        public override BasicScreen Screen => _vOLedBasicScreen;
        public override BasicTouch TouchScreen => _vMultiTouchScreen;
        public override BasicCamera MainCamera => _vMultiMainBasicCamera;
        public override BasicBattery Battery => _vLiIonBattery;
        public override BasicCamera FrontalCamera => _vFrontalBasicCamera;
        public override BasicCpu Cpu => _vCpu;
        public override BasicCpu GraphCpu => _vGraphCpu;
        public override BasicRam Ram => _vRam;
        public override BasicStorage ExternalStorage => _vExternalStorage;
        public override BasicStorage InternalStorage => _vInternalStorage;
        public override BasicSimCardHolder SimCardHolder => _vMultiSimCardHolder;
        public override BasicMicrophone Microphone => _vMicrophone;
        public override BasicSpeaker Speaker => _vSpeaker;
        public override BasicKeyboard Keyboard => _vKeyboard;
    }
}