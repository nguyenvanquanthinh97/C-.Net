using System;
using System.IO;

namespace exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C#_.Net_projects\File_FileInfo\Program.cs";
            if (!File.Exists(path))
            {
                Console.WriteLine("{0} does not exists", path);
                return;
            }
            var content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
    }
}
