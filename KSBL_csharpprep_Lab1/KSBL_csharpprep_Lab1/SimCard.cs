using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public interface ICall
    {
    }

    public abstract class BasicSimCard
    {
        public string SimCardType { get; set; }
        public string OperatorName { get; set; }

        public abstract void Call(ICall call);
    }

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