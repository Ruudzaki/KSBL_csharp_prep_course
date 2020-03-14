using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{

    public abstract class BasicCPU
    {
        public string CPUName { get; set; }
        public List<Core> Cores { get; set; }
        public int AmountOfCPUCores { get; set; }

        public abstract void Process(IProcess process);
    }
}