namespace KSBL_csharpprep_Lab1
{
    public interface IRecordSound
    {
    }

    public abstract class BasicMicrophone
    {
        public string MicroType { get; set; }
        public int Power { get; set; }
        public int Amount { get; set; }

        public abstract void RecordSound(IRecordSound recordSound);
    }

    public class Microphone : BasicMicrophone
    {
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