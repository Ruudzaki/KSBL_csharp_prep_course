namespace KSBL_Class_Library.Components.Speaker
{
    public class AppleHeadset : IPlayback
    {
        public AppleHeadset(IOutput output)
        {
            Output = output;
        }

        public IOutput Output { get; }

        public string Play(object data)
        {
            if (Output != null) return Output.WriteLine($"{nameof(AppleHeadset)} sound");

            return "No Output!";
        }
    }
}