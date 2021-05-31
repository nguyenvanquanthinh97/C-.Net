using System;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null || string.IsNullOrEmpty(instruction))
            {
                throw new InvalidOperationException("dbConnection is null");
            }
            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Run the instruction {0}", _instruction);
            _dbConnection.Close();
        }
    }
}