using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)people / capacity);
            int courses2 = (int)Math.Ceiling((double)people % capacity);
            Console.WriteLine(courses);
         // if (courses == 1)
         // {
         //     Console.WriteLine("All the persons fit inside in the elevator.");
         //     Console.WriteLine("Only one course is needed.");
         // }
         // else if (people % capacity == 0)
         // {
         //     Console.WriteLine("{0} courses * {1} people",courses,capacity);
         // }
         // else
         // {
         //     Console.WriteLine("{0} courses * {1} people + 1 course * {2} persons", courses, capacity, courses2);
         // }
        }
    }
}
