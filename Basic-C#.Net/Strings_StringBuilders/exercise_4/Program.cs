using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a few words separated by a space: ");
            var input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            var words = input.Split(" ");
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }

            var pascalText = string.Join("", words);
            Console.WriteLine(pascalText);
        }
    }
}
