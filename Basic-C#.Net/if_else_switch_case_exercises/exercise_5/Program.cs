using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[100];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach(var number in numbers)
            {
                if(number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
