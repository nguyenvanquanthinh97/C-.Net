using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed_limit = 100;
            var speed = 158;

            if (speed < speed_limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demeritPoint = (speed - speed_limit) / 5;
                if (demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                    return;
                }
                Console.WriteLine(demeritPoint);
            }
        }
    }
}
