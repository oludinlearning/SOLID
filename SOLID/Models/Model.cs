using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Model : IModel
    {
        static string connectionString = @"";
        void AddStudent(List<object> addStudent)
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
                    Value = addStudent[0]
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
        void GetStudent()
        {
            string sqlExpression = "sp_GetStudents";

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

                    }
                }
                reader.Close();
            }
        }  
    }
}
