

namespace DbConnection
{
    public class DbCommand
    {
       
        private readonly DbConnection _connection;
        private readonly string _command;

        public DbCommand (DbConnection connection, string command)
        {
     

            _connection = connection ?? throw new ArgumentNullException (nameof (connection), "Connection can not be null");
            _command = !string.IsNullOrWhiteSpace(command) ? command : throw new ArgumentNullException (nameof (command), "Command can not be empty");
        }
        
        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Execition command:" + _command);
            _connection.CloseConnection();
        }
    }
}
