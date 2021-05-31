using System;

namespace InterfaceExtensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string error)
        {
            Logging(error, ConsoleColor.Red);
        }

        public void LogInfo(string info)
        {
            Logging(info, ConsoleColor.Yellow);
        }

        private void Logging(string message, ConsoleColor color)
        {
            var oldForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = oldForegroundColor;
        }
    }
}