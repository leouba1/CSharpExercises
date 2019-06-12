namespace StudentTeacher
{
    using System;
    public class Teacher : Person
    {
        private string Subject { get; }
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}