namespace StudentTeacher
{
    using System;    
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
