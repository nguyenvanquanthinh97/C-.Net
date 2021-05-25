using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            // Add method
            numbers.Add(1);

            // Add Range method
            numbers.AddRange(new int[] { 5, 6, 7 });
            numbers.Add(1);
            Console.WriteLine("Affect of Add and AddRange method");
            foreach(var item in numbers)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            // Remove method
            numbers.Remove(1);
            Console.WriteLine("Affect of Remove method");
            foreach(var item in numbers)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            // RemoveAt method and Count property
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.RemoveAt(i);
                }
            }
            Console.WriteLine("Affect of using RemoveAd and Count property");
            foreach(var item in numbers)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            // Clear method
            numbers.Clear();
            Console.WriteLine("Affect of clear method");
            foreach(var item in numbers)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("Lenth of numbers list after clear: " + numbers.Count);
            Console.WriteLine();
        }
    }
}
