using System;
using System.Linq;

namespace Exercise_StopWatch
{
    class Program
    {
        public static readonly string[] Commands = new String[]{"start", "stop"};
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            while (true)
            {
                Console.Write("Input your command (Start/Stop): ");
                var command = Console.ReadLine().Trim().ToLower();
                if (!Commands.Contains(command))
                {
                    continue;
                }

                if (command == "start")
                {
                    stopWatch.Start();
                }
                else
                {
                    stopWatch.Stop();
                }
            }
        }
    }
}
