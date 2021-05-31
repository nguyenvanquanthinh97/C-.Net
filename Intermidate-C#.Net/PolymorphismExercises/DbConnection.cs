using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("connection string is null");
            }
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}