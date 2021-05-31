using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            UseOut();
        }

        public static void UseOut()
        {
            int number;
            bool isSuccess = int.TryParse("abc", out number);

            if (isSuccess)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Error when try to parse string to Int32");
            }
        }

        public static void UseParams()
        {
            Console.WriteLine(Calc.Add(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(Calc.Add(1, 2, 3, 4, 5, 6));
        }

        public static void UsePoint()
        {
            var point = new Point(20, 30);
        /*            point.Move(null);
                    Console.WriteLine("Point is at {0} {1}", point.X, point.Y);
        */
            point.Move(200, 300);
            Console.WriteLine("Point is at {0} {1}", point.X, point.Y);

            point.Move(new Point(500, 600));
            Console.WriteLine("Point is at {0} {1}", point.X, point.Y);

        }
    }
}
