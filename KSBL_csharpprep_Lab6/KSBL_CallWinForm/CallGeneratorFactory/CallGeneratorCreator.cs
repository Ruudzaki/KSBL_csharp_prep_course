using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm.CallGeneratorFactory
{
    public abstract class CallGeneratorCreator
    {
        public abstract CallGenerator Create(Mobile mobile);
    }
}