using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SOLID
{ 

    public class SQL
    {
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source="
                + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID="
                + username + ";Password="
                + password;

            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }

        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-E9FPQ9F\SQLEXPRESS";

            string database = "University_my";
            string username = "University_myAdmin";
            string password = "QwertY";

            return GetDBConnection(datasource, database, username, password);
        }
    }
}