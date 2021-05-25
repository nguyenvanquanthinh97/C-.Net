using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.Write("Input a text (ok) to exit: ");
                input = Console.ReadLine();
            } while (input.Trim().ToLower() != "ok");
        }
    }
}
