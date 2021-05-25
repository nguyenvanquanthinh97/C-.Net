using System;
using System.IO;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C#_.Net_projects\File_FileInfo\Program.cs";
            if (!File.Exists(path))
            {
                Console.WriteLine("{0} is not exist", path);
                return;
            }
            var content = File.ReadAllText(path);
            var words = content.Split(new char[] { ' ' });

            string longestWord = "";
            foreach(var word in words)
            {
                if(longestWord.Length < word.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
