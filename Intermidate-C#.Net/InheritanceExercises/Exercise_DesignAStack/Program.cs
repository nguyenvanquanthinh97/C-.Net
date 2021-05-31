using System;
using System.Collections.Generic;

namespace Exercise_DesignAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            execution(stack);
        }

        public static void execution(Stack stack)
        {
            while (true)
            {
                Console.Write("Input your selection push/pop/clear: ");
                var select = Console.ReadLine()?.Trim().ToLower();

                switch (select)
                {
                    case "push":
                    {
                        Console.Write("Input your item you want to add: ");
                        var input = Console.ReadLine()?.Trim();
                        stack.Push(input);
                        break;
                    }
                    case "pop":
                    {
                        stack.Pop();
                        break;
                    }
                    case "clear":
                    {
                        stack.Clear();
                        break;
                    }
                }

                stack.ToString();
            }
        }
    }
}
