namespace InterfaceExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var path = @"D:\log.txt";
            var dbMigratorToFile = new DbMigrator(new FileLogger(path));
            dbMigratorToFile.Migrate();
        }
    }
}
