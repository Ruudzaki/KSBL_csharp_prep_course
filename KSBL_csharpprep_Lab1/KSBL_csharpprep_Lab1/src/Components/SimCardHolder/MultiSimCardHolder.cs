using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    internal class MultiSimCardHolder : BasicSimCardHolder
    {
        public MultiSimCardHolder(string simCardCaseType, List<SimCardHolder> simCards) : base(simCardCaseType)
        {
            SimCards = simCards;
        }

        public List<SimCardHolder> SimCards { get; }

        public override void Call(ICall call)
        {
            //here logic for call with multiple SimCard
        }

        public override string ToString()
        {
            return string.Format($"{SimCards.Count} SimCards");
        }
    }
}