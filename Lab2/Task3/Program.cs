﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double c;
            if (a <= 0)
            {
                Console.WriteLine("Значение A должно быть положительным");
                return;
            }
            c = a * a * a;
            Console.WriteLine(c);
        }
    }
}
