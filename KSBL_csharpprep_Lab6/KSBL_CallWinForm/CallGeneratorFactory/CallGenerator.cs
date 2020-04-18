using System.Collections.Generic;
using KSBL_Class_Library.Components.CallModule;
using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm.CallGeneratorFactory
{
    public abstract class CallGenerator
    {
        protected readonly Mobile Mobile;

        protected CallGenerator(Mobile mobile)
        {
            Calls = new List<Call>();
            Delays = new List<int>();
            Mobile = mobile;

            Calls.Add(new Call(mobile.InternalStorage.GetContactsByNumber("111"), CallType.Incoming));
            Delays.Add(3000);

            Calls.Add(new Call(mobile.InternalStorage.GetContactsByNumber("222"), CallType.Incoming));
            Delays.Add(3500);

            Calls.Add(new Call(mobile.InternalStorage.GetContactsByNumber("333"), CallType.Incoming));
            Delays.Add(4000);

            Calls.Add(new Call(mobile.InternalStorage.GetContactsByNumber("444"), CallType.Incoming));
            Delays.Add(4500);

            Calls.Add(new Call(mobile.InternalStorage.GetContactsByNumber("424"), CallType.Outgoing));
            Delays.Add(4200);

            Calls.Add(new Call(mobile.InternalStorage.GetContactsByNumber("555"), CallType.Incoming));
            Delays.Add(6000);

            Calls.Add(new Call(mobile.InternalStorage.GetContactsByNumber("555"), CallType.Outgoing));
            Delays.Add(6500);
        }

        protected List<Call> Calls { get; }
        protected List<int> Delays { get; }
        public bool CallGeneratorIsOn { get; protected set; }

        public abstract void RunCallGenerator();

        public virtual void Stop()
        {
            CallGeneratorIsOn = false;
        }
    }
}