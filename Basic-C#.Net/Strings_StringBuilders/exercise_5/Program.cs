using System;

namespace exercise_5
{
    class Program
    {
        public static readonly char[] vowels = { 'a', 'e', 'o', 'u', 'i' };
        static void Main(string[] args)
        {
            Console.Write("Input an English word: ");
            var word = Console.ReadLine().Trim();

            var count = 0;
            foreach(var c in word)
            {
                if (Array.IndexOf(vowels, c) != -1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
