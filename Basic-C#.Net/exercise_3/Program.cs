using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = 30;
            var height = 40;

            if (width >= height)
            {
                Console.WriteLine("landscape");
            }else
            {
                Console.WriteLine("Portrait");
            }
        }
    }
}
