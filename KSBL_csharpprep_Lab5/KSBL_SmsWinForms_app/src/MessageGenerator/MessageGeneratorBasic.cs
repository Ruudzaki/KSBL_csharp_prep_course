using System;
using System.Collections.Generic;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;

namespace KSBL_SmsWinForms_app.MessageGenerator
{
    public abstract class MessageGeneratorBasic
    {
        protected readonly Mobile Mobile;

        protected MessageGeneratorBasic(Mobile mobile)
        {
            Messages = new List<Message>();
            Delays = new List<int>();
            Mobile = mobile;

            Messages.Add(new Message("KSBL", "Hello! This is a KSBL's (test analyst's) dummy incoming message.",
                DateTime.Now));
            Delays.Add(3000);

            Messages.Add(new Message("VZL", "Hello! This is a VZL's (tech-lead's) dummy incoming message.",
                DateTime.Now));
            Delays.Add(3500);

            Messages.Add(new Message("OKTK", "Hello! This is a OKTK's (scrum-master's) dummy incoming message.",
                DateTime.Now));
            Delays.Add(4000);
        }

        protected List<Message> Messages { get; }
        protected List<int> Delays { get; }
        public bool MessageGeneratorIsOn { get; protected set; }

        public abstract void RunMessageGenerator();

        public virtual void Stop()
        {
            MessageGeneratorIsOn = false;
        }
    }
}