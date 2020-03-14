using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{

    public class CPU : BasicCPU
    {
        public CPU(List<Core> CPUCores)
        {
            Cores = CPUCores;
            AmountOfCPUCores = Cores.Count;
        }

        public override void Process(IProcess process)
        {
            //her logic for CPU process
        }

        public override string ToString()
        {
            return string.Format("CPU with {0} cores", AmountOfCPUCores);
        }
    }

 
}