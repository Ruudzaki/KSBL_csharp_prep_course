using System.Collections.Generic;

namespace KSBL_Class_Library.Components.CPU
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