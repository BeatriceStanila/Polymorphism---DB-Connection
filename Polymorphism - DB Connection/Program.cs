namespace DbConnection
{
public class Program
{
     static void Main(string[] args)
    {
            var sqlConnection = new SqlConnection("sqlconnection");
            var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Table");
            sqlCommand.Execute();

            Console.WriteLine();

            var oracleConnection = new OracleConnection("oracleconnection");
            var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Table");
            oracleCommand.Execute();




        }
}

}
