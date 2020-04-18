using System;
using System.Threading;
using KSBL_Class_Library.Components.CallModule;
using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm.CallGeneratorFactory
{
    public class CallGeneratorThread : CallGenerator
    {
        private int _index;

        public CallGeneratorThread(Mobile mobile) : base(mobile)
        {
            _index = 0;
        }

        public override void RunCallGenerator()
        {
            CallGeneratorIsOn = true;
            _index = 0;
            for (var i = 0; i < Calls.Count; i++)
            {
                var thread = new Thread(RunCallGeneratorThread);
                thread.Start();
            }
        }

        private void RunCallGeneratorThread()
        {
            try
            {
                RunMessageGenerator(Calls[_index], Delays[_index++]);
            }
            catch
            {
                // ignored
            }
        }

        private void RunMessageGenerator(Call message, int delay)
        {
            while (CallGeneratorIsOn)
            {
                message.CallTime = DateTime.Now;
                Mobile.InternalStorage.AddCall(message);
                Thread.Sleep(delay);
            }
        }
    }
}