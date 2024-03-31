namespace DbConnection
{
public class Program
{
     static void Main(string[] args)
    {
            var sqlConnection = new SqlConnection("sqlconnection");
            sqlConnection.OpenConnection();
            Console.WriteLine("The sql connection works");
            sqlConnection.CloseConnection();


            var oracleConnection = new OracleConnection("oracleconnection");
            oracleConnection.OpenConnection();
            Console.WriteLine("The oracle connection works too");
            oracleConnection.CloseConnection();


        }
}

}
