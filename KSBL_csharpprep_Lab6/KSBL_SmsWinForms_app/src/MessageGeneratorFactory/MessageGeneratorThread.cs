using System;
using System.Threading;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;

namespace KSBL_SmsWinForms_app.MessageGeneratorFactory
{
    public class MessageGeneratorThread : MessageGenerator
    {
        private int _index;

        public MessageGeneratorThread(Mobile mobile) : base(mobile)
        {
            _index = 0;
        }

        public override void RunMessageGenerator()
        {
            MessageGeneratorIsOn = true;
            _index = 0;
            for (var i = 0; i < Messages.Count; i++)
            {
                var thread = new Thread(RunMessageGeneratorThread);
                thread.Start();
            }
        }

        private void RunMessageGeneratorThread()
        {
            try
            {
                RunMessageGenerator(Messages[_index], Delays[_index++]);
            }
            catch
            {
                // ignored
            }
        }

        private void RunMessageGenerator(Message message, int delay)
        {
            while (MessageGeneratorIsOn)
            {
                message.ReceivingTime = DateTime.Now;
                Mobile.InternalStorage.AddMessage(message);
                Thread.Sleep(delay);
            }
        }
    }
}