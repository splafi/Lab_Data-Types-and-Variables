using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var area = radius * radius * Math.PI;
            Console.WriteLine("{0:f12}",area);
        }
    }
}
