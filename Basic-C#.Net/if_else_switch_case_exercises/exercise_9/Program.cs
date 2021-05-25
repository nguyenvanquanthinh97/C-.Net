using System;

namespace exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers separated by comma: ");
            var input = Console.ReadLine();

            var splitStr = input.Split(',');

            var maxValue = int.MinValue;
            for(int i = 0; i< splitStr.Length; i++)
            {
                maxValue = Math.Max(Convert.ToInt32(splitStr[i]), maxValue);
            }
            Console.WriteLine(maxValue);
        }
    }
}
