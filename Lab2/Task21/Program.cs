﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double R1;
            R1 = double.Parse(t1);
            double R2;
            R2 = double.Parse(t2);
            double R;
            R = 1 / R1 + 1 / R2;
            Console.WriteLine("{0:F4}", R);
        }
    }
}
