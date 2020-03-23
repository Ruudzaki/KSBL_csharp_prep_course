using System.Collections.Generic;

namespace KSBL_Class_Library.Components.CPU
{
    public abstract class BasicCpu
    {
        protected BasicCpu(string cpuName, List<Core> cores)
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