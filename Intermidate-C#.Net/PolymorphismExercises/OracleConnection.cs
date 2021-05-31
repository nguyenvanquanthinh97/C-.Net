using System;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString):base(connectionString){}
        public override void Open()
        {
            Console.WriteLine("Open connection for OracleConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Close connection for OracleConnection");
        }
    }
}