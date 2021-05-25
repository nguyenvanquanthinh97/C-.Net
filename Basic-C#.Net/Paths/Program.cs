using System;
using System.IO;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C#_.Net_projects\Classes\Classes.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("Filename: " + Path.GetFileName(path));
            Console.WriteLine("Filename without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
