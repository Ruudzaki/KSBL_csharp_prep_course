namespace KSBL_Class_Library.Components.Microphone
{
    public abstract class BasicMicrophone
    {
        public string MicroType { get; set; }
        public int Power { get; set; }
        public int Amount { get; set; }

        public abstract void RecordSound(IRecordSound recordSound);
    }
}