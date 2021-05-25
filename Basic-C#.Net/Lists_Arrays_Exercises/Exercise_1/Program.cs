using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var likes = new List<string>();
            string input;
            do
            {
                Console.Write("Input name person like your post: ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    likes.Add(input);
                    continue;
                }
                break;
            } while (true);

            switch (likes.Count)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine("{0} likes your post", likes[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} {1} like your post", likes[0], likes[1]);
                    break;
                default:
                    Console.WriteLine("{0} {1} like your post and {2} others like your post", likes[0], likes[1], likes.Count - 2);
                    break;
            }
        }
    }
}
