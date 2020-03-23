using System.Collections.Generic;
using KSBL_Class_Library.Components.Battery;
using KSBL_Class_Library.Components.Camera;
using KSBL_Class_Library.Components.CPU;
using KSBL_Class_Library.Components.Keyboard;
using KSBL_Class_Library.Components.Microphone;
using KSBL_Class_Library.Components.RAM;
using KSBL_Class_Library.Components.Screen;
using KSBL_Class_Library.Components.SimCardHolder;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Components.Speaker;
using KSBL_Class_Library.Components.Storage;
using KSBL_Class_Library.Components.TouchScreen;

namespace KSBL_Class_Library.Mobile
{
    public class SimCorpMobile : Mobile
    {
        private readonly Cpu _vCpu;
        private readonly ExternalStorage _vExternalStorage;
        private readonly FrontalBasicCamera _vFrontalBasicCamera;
        private readonly GraphCpu _vGraphCpu;
        private readonly InternalStorage _vInternalStorage;
        private readonly DigitalKeyboard _vKeyboard;
        private readonly LiIonBattery _vLiIonBattery;
        private readonly Microphone _vMicrophone;
        private readonly MultiMainBasicCamera _vMultiMainBasicCamera;
        private readonly MultiSimCardHolder _vMultiSimCardHolder;
        private readonly MultiTouchScreen _vMultiTouchScreen;
        private readonly OLedBasicScreen _vOLedBasicScreen;
        private readonly Ram _vRam;
        private readonly Speaker _vSpeaker;

        public SimCorpMobile()
        {
            _vCpu = new Cpu("Intel", new List<Core> {new Core(64, 2.1), new Core(64, 2.1)});
            _vExternalStorage = new ExternalStorage(128);
            _vFrontalBasicCamera = new FrontalBasicCamera(1.5, 5);

            _vGraphCpu = new GraphCpu("AMD", new List<Core>
                {new Core(64, 2.1), new Core(64, 2.1), new Core(64, 2.1), new Core(64, 2.1)});

            _vInternalStorage = new InternalStorage(64);
            _vKeyboard = new DigitalKeyboard(new List<char>(), new List<char>());
            _vLiIonBattery = new LiIonBattery(5, 2200, true);
            _vMicrophone = new Microphone("Internal", 3.5, 2);

            _vMultiMainBasicCamera = new MultiMainBasicCamera(2.5, 12,
                new List<MainBasicCamera>
                {
                    new MainBasicCamera(2.5, 12),
                    new MainBasicCamera(2.5, 12),
                    new MainBasicCamera(2.5, 12)
                });

            _vMultiSimCardHolder = new MultiSimCardHolder("DoubleSim",
                new List<SimCardHolder>
                {
                    new SimCardHolder("microSim"),
                    new SimCardHolder("microSim")
                });

            _vMultiTouchScreen = new MultiTouchScreen("Multi", 10);

            _vOLedBasicScreen = new OLedBasicScreen(1080, 1920, 7, 233);
            _vRam = new Ram(4);
            _vSpeaker = new Speaker(15, 15000, 4.5, 3, Output);
            SmsProvider = new SmsProvider(Output, "Hello");
        }

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