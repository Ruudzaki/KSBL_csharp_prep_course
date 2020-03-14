using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public class Cpu : BasicCpu
    {
        public Cpu(string cpuName, List<Core> cores) : base(cpuName, cores)
        {
        }

        public override void Process(IProcess process)
        {
            //her logic for CPU process
        }

        public override string ToString()
        {
            return $"CPU with {AmountOfCpuCores} cores";
        }
    }
}