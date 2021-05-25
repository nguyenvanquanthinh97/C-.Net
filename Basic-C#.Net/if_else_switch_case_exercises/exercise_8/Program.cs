using System;

namespace exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.WriteLine("Random number: {0}", randomNumber);
            for(int i = 0; i < 4; i++)
            {
                Console.Write("Input your guessed number: ");
                var guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }
            Console.WriteLine("You lost");
        }
    }
}
