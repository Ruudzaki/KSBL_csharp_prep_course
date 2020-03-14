namespace KSBL_csharpprep_Lab1
{
    public abstract class BasicMicrophone
    {
        protected BasicMicrophone(string microType, double power, int amount)
        {
            MicroType = microType;
            Power = power;
            Amount = amount;
        }

        public string MicroType { get; }
        public double Power { get; }
        public int Amount { get; }

        public abstract void RecordSound(IRecordSound recordSound);
    }
}