using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm.CallGeneratorFactory
{
    internal class CallGeneratorCreatorTask : CallGeneratorCreator
    {
        public override CallGenerator Create(Mobile mobile)
        {
            return new CallGeneratorTask(mobile);
        }
    }
}