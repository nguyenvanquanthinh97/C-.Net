using System;

namespace InterfaceExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {DateTime.Now}");
            Console.WriteLine("Migrating...");
            _logger.LogInfo($"Migrating ended at {DateTime.Now}");

            _logger.LogError($"No errors executed {DateTime.Now}");
        }
    }
}