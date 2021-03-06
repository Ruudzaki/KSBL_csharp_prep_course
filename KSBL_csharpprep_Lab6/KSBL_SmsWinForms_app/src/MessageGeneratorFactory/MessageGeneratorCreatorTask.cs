﻿using KSBL_Class_Library.Mobile;

namespace KSBL_SmsWinForms_app.MessageGeneratorFactory
{
    internal class MessageGeneratorCreatorTask : MessageGeneratorCreator
    {
        public override MessageGenerator Create(Mobile mobile)
        {
            return new MessageGeneratorTask(mobile);
        }
    }
}