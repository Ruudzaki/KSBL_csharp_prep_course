using System;
using System.Threading;
using System.Threading.Tasks;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;

namespace KSBL_SmsWinForms_app.MessageGenerator
{
    public class MessageGeneratorTask : MessageGeneratorBasic
    {
        public MessageGeneratorTask(Mobile mobile) : base(mobile)
        {
        }

        public override void RunMessageGenerator()
        {
            for (var i = 0; i < Messages.Count; i++) RunMessageGenerator(Messages[i], Delays[i]);
        }

        private async void RunMessageGenerator(Message message, int delay)
        {
            await Task.Run(() =>
            {
                while (MessageGeneratorOnSwitch)
                {
                    message.ReceivingTime = DateTime.Now;
                    Mobile.InternalStorage.AddMessage(message);
                    Thread.Sleep(delay);
                }
            });
        }
    }
}