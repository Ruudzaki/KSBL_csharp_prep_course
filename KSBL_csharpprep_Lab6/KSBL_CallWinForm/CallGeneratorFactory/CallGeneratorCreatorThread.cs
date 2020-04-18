using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm.CallGeneratorFactory
{
    internal class CallGeneratorCreatorThread : CallGeneratorCreator
    {
        public override CallGenerator Create(Mobile mobile)
        {
            return new CallGeneratorThread(mobile);
        }
    }
}