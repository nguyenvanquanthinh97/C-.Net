using System;
using System.Collections.Generic;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Input a number: ");
                var input = Console.ReadLine();
                if (input.Trim().ToLower() == "quit")
                {
                    break;
                }
                var number = Convert.ToInt32(input);
                numbers.Add(number);
            }

            var uniques = new List<int>();
            foreach(var number in numbers)
            {
                if (uniques.Contains(number))
                {
                    continue;
                }
                uniques.Add(number);
            }
            foreach(var num in uniques)
            {
                Console.Write(num + "\t");
            }
        }
    }
}
