namespace KSBL_csharpprep_Lab1
{


    public abstract class BasicMicrophone
    {
        public string MicroType { get; set; }
        public int Power { get; set; }
        public int Amount { get; set; }

        public abstract void RecordSound(IRecordSound recordSound);
    }

}