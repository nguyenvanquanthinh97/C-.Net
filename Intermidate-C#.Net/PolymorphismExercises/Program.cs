using System.Collections.Generic;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("http://localhost:3000");
            var oracleConnection = new OracleConnection("http://localhost:3456");

            var dbCommandSql = new DbCommand(sqlConnection, "T-SQL");
            dbCommandSql.Execute();
            var dbCommandOracle = new DbCommand(oracleConnection, "T-Oracle");
            dbCommandOracle.Execute();
        }
    }
}
