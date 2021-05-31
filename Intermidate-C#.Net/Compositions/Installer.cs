using System;

namespace Compositions
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            Console.WriteLine("Installing ....");
        }
    }
}