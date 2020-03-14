﻿using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{

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
}