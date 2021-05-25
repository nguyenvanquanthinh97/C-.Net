using System;

namespace exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number to calc factory: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine("{0}! = {1}", number, result);
        }
    }
}
