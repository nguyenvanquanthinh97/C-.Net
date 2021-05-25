using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5];
            for(var i= 0; i< 5; i++)
            {
                Console.Write("Input a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if(Array.IndexOf(numbers, number) != -1)
                {
                    Console.WriteLine("number already exist, input again");
                    i--;
                    continue;
                }
                numbers[i] = number;
            }
            Array.Sort(numbers);
            foreach(var num in numbers)
            {
                Console.Write(num + "\t");
            }
            Console.WriteLine();
        }
    }
}
