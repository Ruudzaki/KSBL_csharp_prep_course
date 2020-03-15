namespace KSBL_Class_Library
{


    public abstract class BasicMicrophone
    {
        public string MicroType { get; set; }
        public int Power { get; set; }
        public int Amount { get; set; }

        public abstract void RecordSound(IRecordSound recordSound);
    }

}