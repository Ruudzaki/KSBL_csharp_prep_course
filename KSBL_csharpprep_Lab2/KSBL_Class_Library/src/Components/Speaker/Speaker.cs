namespace KSBL_Class_Library.Components.Speaker
{
    public class Speaker : BasicSpeaker
    {
        public Speaker(int lowestDmp, int highestDmp, double power, int amount, IOutput output) : base(lowestDmp,
            highestDmp, power,
            amount, output)
        {
        }

        public override string Play(object data)
        {
            if (Output != null) return Output.WriteLine($"{nameof(Speaker)} sound");

            return "No Output!";
        }

        public override string ToString()
        {
            return "Speaker";
        }
    }
}