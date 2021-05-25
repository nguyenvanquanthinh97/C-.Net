using System;
using System.Collections.Generic;

namespace exercise_2
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
            var numbers = GetIntList(input, '-');

            numbers.Sort();
            for(int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    Console.WriteLine("Duplicate!");
                    return;
                }
            }
        }

        public static List<int> GetIntList(string text, char separator = '-')
        {
            var nums = text.Split(separator);
            var numbers = new List<int>();

            foreach (var num in nums)
            {
                numbers.Add(Convert.ToInt32(num));
            }
            return numbers;
        }
    }
}
