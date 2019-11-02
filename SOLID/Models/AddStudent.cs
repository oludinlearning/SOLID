using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SOLID.Interfaces;

namespace SOLID.Models
{
    class AddStudent : IAddStudent
    {
        public void AddStudents(string connectionString, List<List<object>> listStudent)
        {
            string sqlExpression = "sp_AddStudent";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value =123
                };
                command.Parameters.Add(nameParam);
                //SqlParameter ageParam = new SqlParameter
                //{
                //    ParameterName = "@age",
                //    Value = addStudent[1]
                //};
                //command.Parameters.Add(ageParam);
                var result = command.ExecuteScalar();
            }
        }
    }
}
