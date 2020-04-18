using System;
using System.Collections.Generic;
using KSBL_Class_Library.Mobile;

namespace KSBL_SmsWinForms_app.MessageGeneratorFactory
{
    public abstract class MessageGenerator
    {
        protected readonly Mobile Mobile;

        protected CallGenerator(Mobile mobile)
        {
            Messages = new List<Call>();
            Delays = new List<int>();
            Mobile = mobile;

            Messages.Add(new Call("KSBL", "Hello! This is a KSBL's (test analyst's) dummy incoming message.",
                DateTime.Now));
            Delays.Add(3000);

            Messages.Add(new Call("VZL", "Hello! This is a VZL's (tech-lead's) dummy incoming message.",
                DateTime.Now));
            Delays.Add(3500);

            Messages.Add(new Call("OKTK", "Hello! This is a OKTK's (scrum-master's) dummy incoming message.",
                DateTime.Now));
            Delays.Add(4000);
        }

        protected List<Call> Messages { get; }
        protected List<int> Delays { get; }
        public bool CallGeneratorIsOn { get; protected set; }

        public abstract void RunMessageGenerator();

        public virtual void Stop()
        {
            CallGeneratorIsOn = false;
        }
    }
}