using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{

    internal class MultiSimCard : SimCard
    {
        public MultiSimCard(List<SimCard> simCards)
        {
            SimCards = simCards;
        }

        public List<SimCard> SimCards { get; set; }

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