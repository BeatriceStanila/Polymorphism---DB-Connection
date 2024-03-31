

namespace DbConnection
{
    public class OracleConnection: DbConnection
      
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            Console.WriteLine("Connect to Oracle database.");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection is open.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection has closed.");
        }
    }
}
