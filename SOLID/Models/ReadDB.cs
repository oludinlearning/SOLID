using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    class ReadDB : IReadDB
    {
        List<List<object>> listStudent = new List<List<object>>();
        int j = 0;
        public void ReadStudent(string connectionString)
        {
            string sqlExpression = "SELECT * FROM ____";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            listStudent[j].Add(reader.GetString(i));
                        }
                        ++j;
                    }
                }
                reader.Close();
            }
    }
}
