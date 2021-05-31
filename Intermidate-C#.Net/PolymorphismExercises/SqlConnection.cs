using System;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString){}

        public override void Open()
        {
            Console.WriteLine("Open connection for SqlConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Close connection for SqlConnection");
        }
    }
}