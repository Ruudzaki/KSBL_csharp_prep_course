namespace KSBL_Class_Library.Components.CPU
{
    public class Core
    {
        public Core(int cache, double coreFrequency)
        {
            Cache = cache;
            CoreFrequency = coreFrequency;
        }

        public int Cache { get; }
        public double CoreFrequency { get; }
    }
}