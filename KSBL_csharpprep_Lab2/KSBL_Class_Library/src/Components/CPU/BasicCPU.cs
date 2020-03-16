using System.Collections.Generic;

namespace KSBL_Class_Library.Components.CPU
{
    public abstract class BasicCpu
    {
        public string CpuName { get; set; }
        public List<Core> Cores { get; set; }
        public int AmountOfCpuCores { get; set; }

        public abstract void Process(IProcess process);
    }
}