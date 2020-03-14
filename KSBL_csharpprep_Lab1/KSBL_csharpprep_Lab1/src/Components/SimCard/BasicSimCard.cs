using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{

    public abstract class BasicSimCard
    {
        public string SimCardType { get; set; }
        public string OperatorName { get; set; }

        public abstract void Call(ICall call);
    }
}