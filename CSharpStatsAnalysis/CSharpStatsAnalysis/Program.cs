﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpStatsAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 2, 4, 5, 7 };
            NumberVector nv = new NumberVector(0, 5, arr);
            nv.displayStats();
        }
    }
}
