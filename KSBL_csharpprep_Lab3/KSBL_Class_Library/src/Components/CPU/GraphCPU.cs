﻿using System.Collections.Generic;

namespace KSBL_Class_Library.Components.CPU
{
    public class GraphCpu : Cpu
    {
        public GraphCpu(string graphCpuName, List<Core> graphCpuCores) : base(graphCpuName, graphCpuCores)
        {
        }

        public override void Process(IProcess process)
        {
            //her logic for Graph CPU process
        }

        public override string ToString()
        {
            return $"Graph CPU with {AmountOfCpuCores} cores";
        }
    }
}