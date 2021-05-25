using System;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine().Trim();
            var cName = new Char[name.Length];
            for(int i = 0; i < name.Length; i++)
            {
                cName[i] = name[i];
            }
            Array.Reverse(cName);
            var reverseName = string.Join("", cName);
            Console.WriteLine(reverseName);
        }
    }
}
