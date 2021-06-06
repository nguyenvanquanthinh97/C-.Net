using System;

namespace Delegates
{
    public class Photo
    {
        private string _path;

        public Photo(string path)
        {
            _path = path;
        }
        public static Photo Load(string path)
        {
            return new Photo(path);
        }

        public void Save()
        {
            Console.WriteLine("Saving Photo...");
        }
    }
}