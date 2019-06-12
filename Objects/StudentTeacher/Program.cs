using System;

namespace StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.SetAge(21);

            student.ShowAge();
            student.GoToClasses();

            var teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Explain();
        }
    }
}
