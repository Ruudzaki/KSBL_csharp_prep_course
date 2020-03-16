namespace KSBL_csharpprep_Lab1.Components.CPU
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