using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{
    public interface IProcess
    {
    }

    public abstract class BasicCPU
    {
        public string CPUName { get; set; }
        public List<Core> Cores { get; set; }
        public int AmountOfCPUCores { get; set; }

        public abstract void Process(IProcess process);
    }

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

    public class GraphCPU : CPU
    {
        public GraphCPU(List<Core> GraphCPUCores) : base(GraphCPUCores)
        {
        }

        public override void Process(IProcess process)
        {
            //her logic for Graph CPU process
        }

        public override string ToString()
        {
            return string.Format("Graph CPU with {0} cores", AmountOfCPUCores);
        }
    }

    public class Core
    {
        public int CashMemory { get; set; }
        public double CoreFrequency { get; set; }
    }
}