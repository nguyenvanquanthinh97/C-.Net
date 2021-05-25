using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input time value: ");
            var time = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(time))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var times = time.Split(":");
            if (times.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hour = Convert.ToInt32(times[0]);
            var minute = Convert.ToInt32(times[1]);

            if (hour >= 0 && hour<=23 &&minute>=0 && minute <= 59)
            {
                Console.WriteLine("Ok");
                return;
            }
            Console.WriteLine("Invalid Time");
        }
    }
}
