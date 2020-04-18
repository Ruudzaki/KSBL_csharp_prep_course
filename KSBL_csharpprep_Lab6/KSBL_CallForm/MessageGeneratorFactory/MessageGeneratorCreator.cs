using KSBL_Class_Library.Mobile;

namespace KSBL_SmsWinForms_app.MessageGeneratorFactory
{
    public abstract class MessageGeneratorCreator
    {
        public abstract MessageGenerator Create(Mobile mobile);
    }
}