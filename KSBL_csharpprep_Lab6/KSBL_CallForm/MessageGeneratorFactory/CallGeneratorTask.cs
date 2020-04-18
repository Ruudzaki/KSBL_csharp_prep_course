using System;
using System.Threading;
using System.Threading.Tasks;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;

namespace KSBL_SmsWinForms_app.MessageGeneratorFactory
{
    public class CallGeneratorTask : MessageGenerator
    {
        public CallGeneratorTask(Mobile mobile) : base(mobile)
        {
        }

        public override void RunCallGenerator()
        {
            MessageGeneratorIsOn = true;
            for (var i = 0; i < Messages.Count; i++) RunMessageGenerator(Messages[i], Delays[i]);
        }

        private async void RunMessageGenerator(Message message, int delay)
        {
            await Task.Run(() =>
            {
                while (MessageGeneratorIsOn)
                {
                    message.ReceivingTime = DateTime.Now;
                    Mobile.InternalStorage.AddMessage(message);
                    Thread.Sleep(delay);
                }
            });
        }
    }
}