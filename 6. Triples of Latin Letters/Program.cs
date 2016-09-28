using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 'a';
            for (int i = 0; i < n; i++)
            {
                var letter = (char)num + i;
                for (int y = 0; y < n; y++)
               {
                   var letter1 = (char)num + y;
                    for (int t = 0; t < n ; t++)
                    {
                        var letter2 = (char)num + t;
                        Console.WriteLine("{0}{1}{2}", (char)letter, (char)letter1,(char)letter2);
                    }

                }
                //for (int t = 0; t < n-1; t++)
                //{
                //    var letter2 = (char)num + i;
                //    Console.WriteLine((char)letter2);
                //}
            }
        }
    }
}
