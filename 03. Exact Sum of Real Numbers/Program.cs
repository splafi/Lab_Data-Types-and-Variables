﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (decimal i = 0; i < n; i++)
            {
                var m = decimal.Parse(Console.ReadLine());
                sum = m + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
