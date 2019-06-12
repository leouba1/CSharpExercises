namespace House
{
    using System;
    
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public House House { get; set; }        

        public Person(string name)
        {
            Name = name;
        }
        
        public void SetAge(int age)
        {
            Age = age;
        }

        public void ShowHouse()
        {
            Console.WriteLine($"My name is {Name}");
            House.ShowData();
            House.Door.ShowData();
        }
    }
}
