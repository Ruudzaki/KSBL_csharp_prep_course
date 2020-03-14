using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{


    internal class SimCard : BasicSimCard
    {
        public override void Call(ICall call)
        {
            //here logic for call with one SimCard
        }

        public override string ToString()
        {
            return "1 SimCard";
        }
    }
}