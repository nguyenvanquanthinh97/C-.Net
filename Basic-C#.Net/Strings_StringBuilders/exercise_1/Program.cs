using System;
using System.Collections.Generic;

namespace exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a few numbers separated by a hyphen: ");
            var input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid");
                return;
            }
            var nums = input.Split("-");
            var numbers = new List<int>();

            foreach(var num in nums)
            {
                numbers.Add(Convert.ToInt32(num));
            }

            var diff = numbers[0] - numbers[1];
            for(var i= 1; i < numbers.Count - 1; i++)
            {
                if (numbers[i]-numbers[i+1] != diff)
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
            }
            Console.WriteLine("Consecutive");
        }
    }
}
