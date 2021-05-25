using System;
using System.IO;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"d:\C#_.Net_projects\tmp");

            var files = Directory.GetFiles(@"C:\Users\NGUYENVANQUANTHINH\Documents", "*.pdf");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"d:\C#_.Net_projects", "*.*");
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }
    }
}
