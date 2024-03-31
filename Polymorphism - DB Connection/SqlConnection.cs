

namespace DbConnection
{
    public class SqlConnection: DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Connect to SQL Database");

        }

        public override void OpenConnection()
        {
            Console.WriteLine("The SQL Connection is open.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("The SQL Connection has closed.");
        }
    }
}
