using System;
using System.Threading;
using System.Threading.Tasks;
using KSBL_Class_Library.Components.CallModule;
using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm.CallGeneratorFactory
{
    public class CallGeneratorTask : CallGenerator
    {
        public CallGeneratorTask(Mobile mobile) : base(mobile)
        {
        }

        public override void RunCallGenerator()
        {
            CallGeneratorIsOn = true;
            for (var i = 0; i < Calls.Count; i++) RunCallGenerator(Calls[i], Delays[i]);
        }

        private async void RunCallGenerator(Call call, int delay)
        {
            await Task.Run(() =>
            {
                while (CallGeneratorIsOn)
                {
                    call.CallTime = DateTime.Now;
                    Mobile.InternalStorage.AddCall(call);
                    Thread.Sleep(delay);
                }
            });
        }
    }
}