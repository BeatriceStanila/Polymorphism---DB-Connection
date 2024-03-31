using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public abstract class DbConnection
    {
        //properties
        public string _connectionString;
        public TimeSpan Timeout {  get; private set; }


       

        //constructor
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) 
                throw new ArgumentNullException("Connection string cannot be empty or null.");
           
            _connectionString = connectionString;
            Timeout = TimeSpan.FromSeconds(30);
        }
        

        //opening method
        public abstract void OpenConnection();
        //closing method
       public abstract void CloseConnection();
    }
}
