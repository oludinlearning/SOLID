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
        public GPA GetGPA(int id) {
            GPA gpa = new GPA();
            Faculty faculty = new Faculty();
            University university = new University();
            Student student = new Student();
            Subject subject = new Subject();


            ///////////////
            ///Заменить на верную реализацию
            ///
            university.Name = "ПГТУ";

            faculty.Name = "Исторический";
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
            ///////////////
            ///

            return gpa;
        }

        // SetGPA записывает данные о средней оценке в базу данных
        public void SetGPA(int id, GPA gpa)
        {

        }
    }
}
