using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main()
        {
            List<Student> myStudents = new List<Student>
            {
                new Student("Muhammad", 640927, "excellent at hystory"),
                new Student("Ismail", 645820),
                new Student("Mail", 340981, "very badly behave yourself")
            };
            Student Agustus = new Student("Agustus", 123456, "very good at math");
            Student Colomonimbus = new Student("Colomonimbus", 356272);
            myStudents.Add(Agustus);
            myStudents.Add(Colomonimbus);

            //foreach (var student in myClass)
            //{
            //    Console.WriteLine(student);
            //}

            List<Discipline> myDisciplines = new List<Discipline>
            {
                new Discipline("Python", 10, myStudents, "3 times a week"),
                new Discipline("Swift", 8, myStudents),
                new Discipline("Ruby", 12, myStudents, "2 times a week")
            };
            Discipline CSharp = new Discipline("C#", 10, myStudents, "once a week");
            CSharp.AddStudent(new Student("Koko", 253789, "excellent at programming"));
            myDisciplines.Add(CSharp);

            //foreach (var discipline in myDisciplines)
            //{
            //    Console.WriteLine(discipline);
            //}      


            List<Teacher> myTeachers = new List<Teacher>
            {
                new Teacher("Akhmad", myDisciplines),
                new Teacher("Wibisono", myDisciplines, "CSharp professional"),
                new Teacher("Khaleed", myDisciplines, "PHP professional")
            };

            //foreach (var teacher in myTeachers)
            //{
            //    Console.WriteLine(teacher);
            //}

            Class myClass = new Class("7-B", myTeachers, "Back-end development class");
            Console.WriteLine(myClass);
        }
    }
}
