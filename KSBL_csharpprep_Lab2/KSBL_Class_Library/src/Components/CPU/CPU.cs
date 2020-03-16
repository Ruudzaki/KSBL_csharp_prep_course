using System.Collections.Generic;

namespace KSBL_Class_Library.Components.CPU
{
    public class Cpu : BasicCpu
    {
        public Cpu(List<Core> cpuCores)
        {
            Cores = cpuCores;
            AmountOfCpuCores = Cores.Count;
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