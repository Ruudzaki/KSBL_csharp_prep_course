namespace KSBL_csharpprep_Lab1.Components.Microphone
{
    public class Microphone : BasicMicrophone
    {
        public Microphone(string microType, double power, int amount) : base(microType, power, amount)
        {
        }

        public override void RecordSound(IRecordSound recordSound)
        {
            //here logic for record from microphone
        }

        public override string ToString()
        {
            return "Microphone";
        }
    }
}