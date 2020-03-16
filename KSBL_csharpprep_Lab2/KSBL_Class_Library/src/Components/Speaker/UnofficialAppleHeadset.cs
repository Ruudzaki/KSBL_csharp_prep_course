namespace KSBL_Class_Library.Components.Speaker
{
    public class UnofficialAppleHeadset : IPlayback
    {
        public UnofficialAppleHeadset(IOutput output)
        {
            Output = output;
        }

        public IOutput Output { get; }

        public string Play(object data)
        {
            if (Output != null) return Output.WriteLine($"{nameof(UnofficialAppleHeadset)} sound");

            return "No Output!";
        }
    }
}