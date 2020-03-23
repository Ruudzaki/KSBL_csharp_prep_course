namespace KSBL_Class_Library.Components.Speaker
{
    public class SamsungHeadset : IPlayback
    {
        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }

        public IOutput Output { get; }

        public string Play(object data)
        {
            if (Output != null) return Output.WriteLine($"{nameof(SamsungHeadset)} sound");

            return "No Output!";
        }
    }
}