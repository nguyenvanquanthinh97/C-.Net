using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtesionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = "This is supposed to be a very long blog post ha ha ha ha...";
            var shortenPost = post.shorten(5);

            Console.WriteLine(shortenPost);

            var numbers = new List<int>() {1,2,10,4,3,2};
            Console.WriteLine(numbers.Max());
        }
    }
}
