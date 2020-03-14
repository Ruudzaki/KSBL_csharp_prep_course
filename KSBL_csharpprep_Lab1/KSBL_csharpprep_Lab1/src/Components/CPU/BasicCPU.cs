using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public abstract class BasicCpu
    {
        public BasicCpu(string cpuName, List<Core> cores)
        {
            CpuName = cpuName;
            Cores = cores;
            AmountOfCpuCores = Cores.Count;
        }

        public string CpuName { get; }
        public List<Core> Cores { get; }
        public int AmountOfCpuCores { get; }

        public abstract void Process(IProcess process);
    }
}