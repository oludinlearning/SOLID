using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID
{
    class Model : IModel
    {
        protected int DBRecordCount { get ; set; } = 15;

        public int Get_DBRecordCount()
        {
            return DBRecordCount;
        }


        public Model()
        {
            NewDB();
        }

        static GPA gpa = new GPA();
        Faculty faculty = new Faculty();
        University university = new University();
        Student student = new Student();
        Subject subject = new Subject();

        public static List<GPA> DB = new List<GPA>();

        public void NewDB()
        {
            university.Name = "ПГТУ";

            faculty.Name = "Исторический";
            faculty.University = university;

            student.Name = "Петр";
            student.Surname = "Иванов";
            student.Patronimic = "Андреевич";
            student.Faculty = faculty;

            subject.Name = "История древнего мира";

            gpa.GradePointAverage = 0;
            gpa.Student = student;
            gpa.Student.Faculty = faculty;
            gpa.Subject = subject;
            gpa.GradePointAverage = GPA.gpa.great;
            ///////////////
            ///

            for (int i = 0; i < DBRecordCount; i++)
            {
                //gpa.ID = i;
                DB.Add(new GPA {
                    ID = i,
                    GradePointAverage = 0,
                    Student = student,
                    Subject = subject,                    
                });
            }            
        }
        
        public GPA GetGPA(int id) {
            
            ///////////////
            ///Заменить на верную реализацию
            ///
            
            return DB[id];
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
