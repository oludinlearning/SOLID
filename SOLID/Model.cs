using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID
{
    class Model : IModel
    {
        static GPA gpa = new GPA();
        Faculty faculty = new Faculty();
        University university = new University();
        Student student = new Student();
        Subject subject = new Subject();
        protected int DBRecordCount { get ; set; }

        public int Get_DBRecordCount()
        {
            string stmt = "SELECT COUNT(*) FROM gpa";
            int count = 0;

            SqlConnection thisConnection = SQL.GetDBConnection();
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            DBRecordCount = count;
            return DBRecordCount;
        }

        private static GPA QueryGPA(SqlConnection conn, int id_GPA)
        {
            string sql = "Select gpa, id_Subject, id_Student, id from GPA where id = " + id_GPA;

            // Создать объект Command.
            SqlCommand sqlcmd_GPA = new SqlCommand();
            sqlcmd_GPA.Connection = conn;
            sqlcmd_GPA.CommandText = sql;
            GPA gpa = new GPA();
            int id_GPA_quered = 1;
            int id_Student_quered = 1;
            int id_Subject_quered = 1;

            using (DbDataReader reader_GPA = sqlcmd_GPA.ExecuteReader())
            {
                if (reader_GPA.HasRows)
                {

                    while (reader_GPA.Read())
                    {
                        id_GPA_quered = Convert.ToInt32(reader_GPA.GetValue(reader_GPA.GetOrdinal("id")));
                        id_Student_quered = Convert.ToInt32(reader_GPA.GetValue(reader_GPA.GetOrdinal("id_Student")));
                        id_Subject_quered = Convert.ToInt32(reader_GPA.GetValue(reader_GPA.GetOrdinal("id_Subject")));
                        gpa.GradePointAverage = (GPA.gpa)(reader_GPA.GetValue(reader_GPA.GetOrdinal("gpa")));                        
                    }
                    reader_GPA.Close();
                    gpa.Student = QueryStudent(conn, id_Student_quered);
                    gpa.Subject = QuerySubject(conn, id_Subject_quered);
                    gpa.ID = id_GPA_quered;
                }
            }
            return gpa;
        }

        private static Subject QuerySubject(SqlConnection conn, int id_Subject)
        {
            string sql = "Select Name from Subject where id = " + id_Subject;

            // Создать объект Command.
            SqlCommand sqlcmd_Subject = new SqlCommand();
            sqlcmd_Subject.Connection = conn;
            sqlcmd_Subject.CommandText = sql;
            Subject subject = new Subject();

            using (DbDataReader reader_Subject = sqlcmd_Subject.ExecuteReader())
            {
                if (reader_Subject.HasRows)
                {
                    while (reader_Subject.Read())
                    {
                        subject.Name = Convert.ToString(reader_Subject.GetValue(reader_Subject.GetOrdinal("Name")));
                    }
                    reader_Subject.Close();
                }
            }
            return subject;
        }
        private static Student QueryStudent(SqlConnection conn, int id)
        {
            string sql = "Select Name, Surname, Patronimyc, id_Faculty from Student where id = " + id;

            // Создать объект Command.
            SqlCommand sqlcmd_Student = new SqlCommand();
            sqlcmd_Student.Connection = conn;
            sqlcmd_Student.CommandText = sql;
            Student student = new Student();

            int id_Faculty = 1;
            using (DbDataReader reader_Student = sqlcmd_Student.ExecuteReader())
            {

                if (reader_Student.HasRows)
                {

                    while (reader_Student.Read())
                    {
                        id_Faculty = Convert.ToInt32(reader_Student.GetValue(reader_Student.GetOrdinal("id_Faculty")));
                        student.Name = Convert.ToString(reader_Student.GetValue(reader_Student.GetOrdinal("Name")));
                        student.Surname = Convert.ToString(reader_Student.GetValue(reader_Student.GetOrdinal("Surname")));
                        student.Patronimic = Convert.ToString(reader_Student.GetValue(reader_Student.GetOrdinal("Patronimyc")));                        
                    }
                    reader_Student.Close();
                    student.Faculty = QueryFaculty(conn, id_Faculty);
                }
            }
            return student;
        }
        private static Faculty QueryFaculty(SqlConnection conn, int id)
        {
            string sql = "Select Name, id, id_University from Faculty where id = " + id;

            // Создать объект Command.
            SqlCommand sqlcmd_Faculty = new SqlCommand();
            sqlcmd_Faculty.Connection = conn;
            sqlcmd_Faculty.CommandText = sql;
            Faculty faculty = new Faculty();
            int id_University = 1;
            using (DbDataReader reader_Faculty = sqlcmd_Faculty.ExecuteReader())
            {
                if (reader_Faculty.HasRows)
                {

                    while (reader_Faculty.Read())
                    {
                        id_University = Convert.ToInt32(reader_Faculty.GetValue(reader_Faculty.GetOrdinal("id_University")));
                        faculty.Name = Convert.ToString(reader_Faculty.GetValue(reader_Faculty.GetOrdinal("Name")));
                    }
                    reader_Faculty.Close();
                    faculty.University = QueryUniversity(conn, id_University);
                }
            }
            return faculty;
        }
        private static University QueryUniversity(SqlConnection conn, int id_University)
        {
            string sql = "Select Name from University where id = " + id_University;

            // Создать объект Command.
            SqlCommand sqlcmd_University = new SqlCommand();
            sqlcmd_University.Connection = conn;
            sqlcmd_University.CommandText = sql;
            University university = new University();

            using (DbDataReader reader_University = sqlcmd_University.ExecuteReader())
            {
                if (reader_University.HasRows)
                {

                    while (reader_University.Read())
                    {
                        university.Name = Convert.ToString(reader_University.GetValue(reader_University.GetOrdinal("Name")));
                    }
                    reader_University.Close();
                }
            }
            return university;
        }



        public GPA GetGPA(int id)
        {

            GPA gpa = new GPA();
            SqlConnection conn = SOLID.SQL.GetDBConnection();

            try
            {
                conn.Open();
                gpa = QueryGPA(conn, id);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Error: " + e);
                //Console.WriteLine(e.StackTrace)
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return gpa;
        }

        // SetGPA записывает данные о средней оценке в базу данных
        public void SetGPA(int id, GPA gpa)
        {
            university.Name = "ПНИПУ";

            faculty.Name = "Юридический";
            faculty.University = university;

            student.Name = "Петр";
            student.Surname = "Иванов";
            student.Patronimic = "Андреевич";
            student.Faculty = faculty;

            subject.Name = "История древнего мира";

            gpa.Student = student;
            gpa.Student.Faculty = faculty;
            gpa.Subject = subject;
            gpa.GradePointAverage = GPA.gpa.great;
        }

        public void DeleteGPA(int id)
        {

        }
    }
}
