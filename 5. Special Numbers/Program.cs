using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var lastDigit = i % 10;
                var firstDigit = (i - i % 10)/10;
                if (i == 5 || i == 7    )
                {
                    Console.WriteLine(i + " -> True");
                }
                else if (lastDigit+firstDigit==5|| lastDigit + firstDigit == 7|| lastDigit + firstDigit == 11)
                {
                    Console.WriteLine(i + " -> True");
                }
                else
                {
                    Console.WriteLine(i + " -> False");
                }
            }
        }
    }
}
