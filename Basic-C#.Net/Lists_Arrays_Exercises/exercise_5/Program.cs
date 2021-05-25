using System;
using System.Collections.Generic;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("Input comma separated numbers: ");
                var input = Console.ReadLine();
                var cNums = input.Split(",");

                if (cNums.Length < 5)
                {
                    Console.WriteLine("Invalid, total numbers quantity must be > 5");
                    continue;
                }

                var numbers = new List<int>();
                foreach(var item in cNums)
                {
                    numbers.Add(Convert.ToInt32(item));
                }
                numbers.Sort();
                Console.WriteLine("Smallest 3 numbers {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
                break;
            }
        }
    }
}
