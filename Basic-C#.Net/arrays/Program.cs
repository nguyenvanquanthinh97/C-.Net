using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;
            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "Jack", "John", "Mary" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            var numbers = new int[] { 3, 5, 7, 9, 2, 14, 6 };
            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            Console.WriteLine("Index of 9 in array: " + Array.IndexOf(numbers, 9));

            // Clear
            Array.Clear(numbers, 2, 3);
            Console.WriteLine("Effect of clear");
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Affect of Copy");
            foreach(var item in another)
            {
                Console.WriteLine(item);
            }

            // Sort 
            Array.Sort(numbers);
            Console.WriteLine("Affect of sort");
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of reverse");
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
