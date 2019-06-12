namespace StudentTeacher
{
    using System;
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to classes!");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {Age} years old");
        }
    }
}