using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int second = 0;  bool condition = false;
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                while (i > 0)
                {
                    second += i % 10;
                    i = i / 10;
                }
                condition = (second == 5) || (second == 7) || (second == 11);
                Console.WriteLine($"{number} -> {condition}");
                second = 0;
                i = number;
            }

        }
    }
}
